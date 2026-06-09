using DiGi.Scripting.Classes;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Scripting.Python.Classes
{
    /// <summary>
    /// Provides an implementation of <see cref="Scripting.Classes.Script"/> for executing Python scripts using the IronPython engine.
    /// </summary>
    public class Script : Scripting.Classes.Script
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Script"/> class with specified code and variable definitions.
        /// </summary>
        /// <param name="code">The source code to be executed.</param>
        /// <param name="inputVariableTypes">A collection of expected input variable types.</param>
        /// <param name="outputVariableTypes">A collection of expected output variable types.</param>
        public Script(Code? code, IEnumerable<VariableType> inputVariableTypes, IEnumerable<VariableType> outputVariableTypes)
            : base(code, inputVariableTypes, outputVariableTypes)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Script"/> class by copying an existing script.
        /// </summary>
        /// <param name="script">The source script to copy from.</param>
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
        /// Executes the Python script using the provided input data.
        /// </summary>
        /// <param name="inputData">The data to be passed as inputs to the script. Can be null.</param>
        /// <returns>A <see cref="Response"/> containing either the resulting output variables or an exception encountered during execution.</returns>
        public override Response Execute(Data? inputData = null)
        {
            Code? code = Code;

            if (string.IsNullOrWhiteSpace(code))
            {
                return new Response(new CodeMissingException());
            }

            IEnumerable<VariableType>? inputVariableTypes = InputVariableTypes;
            IEnumerable<VariableType>? outputVariableTypes = OutputVariableTypes;

            ScriptEngine scriptEngine = IronPython.Hosting.Python.CreateEngine();

            ScriptScope scriptScope = scriptEngine.CreateScope();
            if (inputData != null && inputData.Count != 0)
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
                        if (string.IsNullOrWhiteSpace(variableType?.Name) || !dictionary.TryGetValue(variableType!.Name!, out object? value))
                        {
                            continue;
                        }

                        scriptScope.SetVariable(variableType.Name, value);
                    }
                }
            }

            try
            {
                scriptEngine.Execute(code, scriptScope);
            }
            catch (Exception exception)
            {
                return new Response(exception);
            }

            List<Output>? outputs = null;
            if (outputVariableTypes != null)
            {
                outputs = [];
                foreach (VariableType variableType in outputVariableTypes)
                {
                    if (string.IsNullOrWhiteSpace(variableType?.Name))
                    {
                        continue;
                    }

                    if (!scriptScope.TryGetVariable(variableType!.Name, out dynamic value))
                    {
                        continue;
                    }

                    outputs.Add(new Output(variableType, value));
                }
            }

            return new Response(outputs);
        }
    }
}