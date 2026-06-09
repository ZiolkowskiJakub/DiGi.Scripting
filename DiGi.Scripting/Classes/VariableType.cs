using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Scripting.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// Describes a named, typed script variable.
    /// </summary>
    public class VariableType : SerializableObject, INamedObject, IScriptingSerializableObject
    {
        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        [JsonInclude, JsonPropertyName("Type")]
        private readonly Type? type;

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableType"/> class.
        /// </summary>
        /// <param name="name">The name of the variable.</param>
        /// <param name="type">The <see cref="Type"/> of the variable.</param>
        public VariableType(string? name, Type? type)
        {
            this.name = name;
            this.type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableType"/> class from a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public VariableType(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableType"/> class by copying another variable type.
        /// </summary>
        /// <param name="variableType">The source <see cref="VariableType"/> to copy.</param>
        public VariableType(VariableType? variableType)
            : base(variableType)
        {
            if (variableType != null)
            {
                name = variableType.Name;
                type = variableType.Type;
            }
        }

        /// <summary>
        /// Gets the name of the variable type.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the system <see cref="Type"/> associated with this variable type.
        /// </summary>
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