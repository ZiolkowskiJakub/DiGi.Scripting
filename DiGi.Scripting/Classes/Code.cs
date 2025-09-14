using DiGi.Core.Classes;
using DiGi.Scripting.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.Core.Classes
{
    public sealed class Code : SerializableObject, IScriptingSerializableObject
    {
        [JsonInclude, JsonPropertyName("Value")]
        private readonly string? value;

        public Code(string? value)
        {
            this.value = value;
        }

        public Code(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public Code(Code? code)
            :base(code)
        {
            if(code != null)
            {
                value = code.value;
            }
        }

        [JsonIgnore]
        public string? Value
        {
            get
            {
                return value;
            }
        }

        public static implicit operator Code?(string? value)
        {
            return new Code(value);
        }

        public static implicit operator string?(Code? code)
        {
            return code?.value;
        }
    }
}
