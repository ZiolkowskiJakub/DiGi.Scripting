using DiGi.Scripting.Classes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.CSharp.Classes
{
    /// <summary>
    /// Represents a C# script implementation that can be compiled and executed using the Roslyn scripting API.
    /// </summary>
    public class Script : Scripting.Classes.Script
    {
        [JsonInclude, JsonPropertyName("Imports")]
        private HashSet<string>? imports;

        [JsonInclude, JsonPropertyName("References")]
        private HashSet<string>? references;

        /// <summary>
        /// Initializes a new instance of the <see cref="Script"/> class.
        /// </summary>
        /// <param name="code">The source code to be executed.</param>
        /// <param name="inputVariableTypes">The collection of variable types used as inputs.</param>
        /// <param name="outputVariableTypes">The collection of variable types expected as outputs.</param>
        public Script(Code? code, IEnumerable<VariableType>? inputVariableTypes, IEnumerable<VariableType>? outputVariableTypes)
            : base(code, inputVariableTypes, outputVariableTypes)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Script"/> class by copying an existing script.
        /// </summary>
        /// <param name="script">The source script to copy.</param>
        public Script(Script? script)
            : base(script)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Script"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON representation of the script.</param>
        public Script(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the set of namespaces to be imported during script execution.
        /// </summary>
        [JsonIgnore]
        public HashSet<string>? Imports
        {
            get
            {
                return imports == null ? null : [.. imports];
            }
            set
            {
                imports = value == null ? null : [.. value];
            }
        }

        /// <summary>
        /// Gets or sets the set of assembly references required for script compilation and execution.
        /// </summary>
        [JsonIgnore]
        public HashSet<string>? References
        {
            get
            {
                return references == null ? null : [.. references];
            }
            set
            {
                references = value == null ? null : [.. value];
            }
        }

        /// <summary>
        /// Executes the C# script using the provided input data.
        /// </summary>
        /// <param name="inputData">The data to be passed into the script as globals.</param>
        /// <returns>A <see cref="Response"/> containing the execution results or any encountered exceptions.</returns>
        public override Response? Execute(Data? inputData = null)
        {
            string? code = Code;

            if (string.IsNullOrWhiteSpace(code))
            {
                return new Response(new CodeMissingException());
            }

            IEnumerable<VariableType>? inputVariableTypes = InputVariableTypes;
            IEnumerable<VariableType>? outputVariableTypes = OutputVariableTypes;

            Data inputData_Temp = [];
            if (inputData != null && inputData.Count() != 0)
            {
                Dictionary<string, object?> dictionary = [];
                foreach (KeyValuePair<string, object?> input in inputData)
                {
                    if (string.IsNullOrWhiteSpace(input.Key))
                    {
                        continue;
                    }

                    dictionary[input.Key] = input.Value;
                }

                if (inputVariableTypes is not null)
                {
                    foreach (VariableType variableType in inputVariableTypes)
                    {
                        string? name = variableType?.Name;

                        if (string.IsNullOrWhiteSpace(name) || !dictionary.TryGetValue(name!, out object? value))
                        {
                            continue;
                        }

                        code = code?.Replace(string.Format("[{0}]", name), string.Format(@"Dictionary[""{0}""]", name));
                        inputData_Temp[name!] = value;
                    }
                }
            }

            ScriptOptions scriptOptions = ScriptOptions.Default;
            if (references != null)
            {
                scriptOptions = scriptOptions.AddReferences(references);
            }

            if (imports != null)
            {
                scriptOptions = scriptOptions.AddImports(imports);
            }

            Script<object> script = CSharpScript.Create(code, scriptOptions, typeof(Data));

            ImmutableArray<Diagnostic> immutableArray = script.Compile();
            if (immutableArray != null)
            {
                foreach (Diagnostic diagnostic in immutableArray)
                {
                    if (diagnostic.Severity == DiagnosticSeverity.Error)
                    {
                        return new Response(new CompileException(diagnostic.GetMessage()));
                    }
                }
            }

            ScriptState<object>? scriptState = null;

            try
            {
                scriptState = script.RunAsync(globals: inputData_Temp).GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                return new Response(exception);
            }

            if (scriptState?.Exception != null)
            {
                return new Response(scriptState.Exception);
            }

            List<Output>? outputs = null;
            if (outputVariableTypes != null && outputVariableTypes.Count() != 0)
            {
                outputs ??= [];

                Dictionary<string, ScriptVariable>? dictionary = scriptState?.Variables.ToDictionary(x => x.Name);
                if (dictionary != null)
                {
                    foreach (VariableType variableType in outputVariableTypes)
                    {
                        string? name = variableType?.Name;
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            continue;
                        }

                        if (!dictionary.TryGetValue(name!, out ScriptVariable scriptVariable) || scriptVariable == null)
                        {
                            continue;
                        }

                        outputs.Add(new Output(variableType, scriptVariable.Value));
                    }
                }

                foreach (VariableType variableType in outputVariableTypes)
                {
                    if (variableType?.Name == Constants.VariableType.Name.Return)
                    {
                        outputs.Add(new Output(variableType, scriptState?.ReturnValue));
                        break;
                    }
                }
            }

            return new Response(outputs);
        }
    }
}