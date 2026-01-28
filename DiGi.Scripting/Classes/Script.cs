using DiGi.Core.Classes;
using DiGi.Scripting.Core;
using DiGi.Scripting.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.Classes
{
    public abstract class Script : SerializableObject, IScript
    {
        [JsonInclude, JsonPropertyName("Code")]
        private Code? code;

        [JsonIgnore]
        private Dictionary<string, VariableType>? inputDictionary;

        [JsonIgnore]
        private Dictionary<string, VariableType>? outputDictionary;

        public Script(Code? code, IEnumerable<VariableType>? inputVariableTypes, IEnumerable<VariableType>? outputVariableTypes)
        {
            this.code = DiGi.Core.Query.Clone(code);
            InputVariableTypes = inputVariableTypes;
            OutputVariableTypes = outputVariableTypes;
        }

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

        public Script(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

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

        public abstract Response? Execute(Data? inputData = null);

        public Response? Execute<TInput>(IEnumerable<TInput>? inputs = null) where TInput : IInput
        {
            return Execute(inputs != null ? Create.Data(inputs) : null);
        }
    }
}