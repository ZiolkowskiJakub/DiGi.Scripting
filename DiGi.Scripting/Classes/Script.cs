using DiGi.Core.Classes;
using DiGi.Scripting.Core;
using DiGi.Scripting.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// Abstract base class for language-specific script runners, implementing <see cref="IScript"/>.
    /// </summary>
    public abstract class Script : SerializableObject, IScript
    {
        [JsonInclude, JsonPropertyName("Code")]
        private Code? code;

        [JsonIgnore]
        private Dictionary<string, VariableType>? inputDictionary;

        [JsonIgnore]
        private Dictionary<string, VariableType>? outputDictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Script"/> class with specified source code and variable type definitions.
        /// </summary>
        /// <param name="code">The <see cref="Code"/> containing the script source.</param>
        /// <param name="inputVariableTypes">A collection of <see cref="VariableType"/> defining the expected inputs.</param>
        /// <param name="outputVariableTypes">A collection of <see cref="VariableType"/> defining the expected outputs.</param>
        public Script(Code? code, IEnumerable<VariableType>? inputVariableTypes, IEnumerable<VariableType>? outputVariableTypes)
        {
            this.code = DiGi.Core.Query.Clone(code);
            InputVariableTypes = inputVariableTypes;
            OutputVariableTypes = outputVariableTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Script"/> class by copying another script instance.
        /// </summary>
        /// <param name="script">The source <see cref="Script"/> to copy from.</param>
        public Script(Script? script)
            : base(script)
        {
            if (script != null)
            {
                code = DiGi.Core.Query.Clone(script.code);
                InputVariableTypes = script.InputVariableTypes;
                OutputVariableTypes = script.OutputVariableTypes;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Script"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the serialized script data.</param>
        public Script(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the source code of the script wrapped in a <see cref="Code"/> object.
        /// </summary>
        [JsonIgnore]
        public Code? Code
        {
            get
            {
                return DiGi.Core.Query.Clone(code);
            }

            set
            {
                code = DiGi.Core.Query.Clone(value);
            }
        }

        /// <summary>
        /// Gets or sets the collection of <see cref="VariableType"/> defining the input variables for the script.
        /// </summary>
        [JsonInclude, JsonPropertyName("InputVariableTypes")]
        public IEnumerable<VariableType>? InputVariableTypes
        {
            get
            {
                return inputDictionary?.Values;
            }

            set
            {
                inputDictionary = null;
                if (value == null)
                {
                    return;
                }

                inputDictionary = [];
                foreach (VariableType variableType in value)
                {
                    if (string.IsNullOrWhiteSpace(variableType?.Name))
                    {
                        continue;
                    }

                    inputDictionary[variableType!.Name!] = variableType;
                }
            }
        }

        /// <summary>
        /// Gets or sets the collection of <see cref="VariableType"/> defining the output variables for the script.
        /// </summary>
        [JsonInclude, JsonPropertyName("OutputVariableTypes")]
        public IEnumerable<VariableType>? OutputVariableTypes
        {
            get
            {
                return outputDictionary?.Values;
            }

            set
            {
                outputDictionary = null;
                if (value == null)
                {
                    return;
                }

                outputDictionary = [];
                foreach (VariableType variableType in value)
                {
                    if (string.IsNullOrWhiteSpace(variableType?.Name))
                    {
                        continue;
                    }

                    outputDictionary[variableType!.Name!] = variableType;
                }
            }
        }

        /// <summary>
        /// Executes the script using the provided input data.
        /// </summary>
        /// <param name="inputData">The <see cref="Data"/> containing inputs for execution.</param>
        /// <returns>A <see cref="Response"/> object containing the result of the execution or an exception.</returns>
        public abstract Response? Execute(Data? inputData = null);

        /// <summary>
        /// Executes the script using a collection of <see cref="IInput"/> objects as inputs.
        /// </summary>
        /// <typeparam name="TInput">A type that implements <see cref="IInput"/>.</typeparam>
        /// <param name="inputs">The collection of input variables.</param>
        /// <returns>A <see cref="Response"/> object containing the result of the execution or an exception.</returns>
        public Response? Execute<TInput>(IEnumerable<TInput>? inputs = null) where TInput : IInput
        {
            return Execute(inputs != null ? Create.Data(inputs) : null);
        }
    }
}