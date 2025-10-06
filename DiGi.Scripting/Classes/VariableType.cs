using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Scripting.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.Classes
{
    public class VariableType : SerializableObject, INamedObject, IScriptingSerializableObject
    {
        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        [JsonInclude, JsonPropertyName("Type")]
        private readonly Type? type;

        public VariableType(string? name, Type? type) 
        { 
            this.name = name;
            this.type = type;
        }

        public VariableType(JsonObject? jsonObject)
            :base(jsonObject)
        {

        }

        public VariableType(VariableType? variableType)
            : base(variableType)
        {
            if(variableType != null)
            {
                name= variableType.Name;
                type= variableType.Type;
            }
        }

        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        [JsonIgnore]
        public Type? Type
        {
            get
            {
                return type;
            }
        }
    }
}
