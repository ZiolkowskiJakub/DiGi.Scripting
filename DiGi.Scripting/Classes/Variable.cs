using DiGi.Core.Interfaces;
using DiGi.Scripting.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.Classes
{
    public abstract class Variable : IScriptingObject, INamedObject
    {
        [JsonInclude, JsonPropertyName("Value")]
        private readonly object? value;

        [JsonInclude, JsonPropertyName("VariableType")]
        private readonly VariableType? variableType;
        
        protected Variable()
        {

        }

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

        public Variable(Variable? variable)
        {
            if(variable is not null)
            {
                variableType = DiGi.Core.Query.Clone(variable.variableType);
                value = variable.value;
            }
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

        [JsonIgnore]
        public VariableType? VariableType
        {
            get
            {
                return DiGi.Core.Query.Clone(variableType);
            }
        }
    }
}
