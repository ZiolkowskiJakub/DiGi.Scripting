using DiGi.Core.Interfaces;
using DiGi.Scripting.Core.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.Core.Classes
{
    public abstract class Variable : IScriptingObject, INamedObject
    {
        [JsonInclude, JsonPropertyName("VariableType")]
        private readonly VariableType? variableType;

        private readonly object? value;

        public Variable(VariableType? variableType, object? value)
        {
            this.variableType = variableType;
            this.value = value;
        }

        public Variable(string? name, Type? type, object? value)
        {
            variableType = new VariableType(name, type);
            this.value = value;
        }

        [JsonIgnore]
        public string? Name
        {
            get
            {
                return variableType?.Name;
            }
        }

        [JsonIgnore]
        public object? Value
        {
            get
            {
                return value;
            }
        }
    }
}
