using DiGi.Core.Classes;
using DiGi.Scripting.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// Wraps script source code as a serializable string value.
    /// </summary>
    public sealed class Code : SerializableObject, IScriptingSerializableObject
    {
        [JsonInclude, JsonPropertyName("Value")]
        private readonly string? value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Code"/> class with the specified source code.
        /// </summary>
        /// <param name="value">The script source code.</param>
        public Code(string? value)
        {
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Code"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the code data.</param>
        public Code(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Code"/> class by copying another <see cref="Code"/> instance.
        /// </summary>
        /// <param name="code">The source <see cref="Code"/> object to copy from.</param>
        public Code(Code? code)
            : base(code)
        {
            if (code != null)
            {
                value = code.value;
            }
        }

        /// <summary>
        /// Gets the script source code value.
        /// </summary>
        [JsonIgnore]
        public string? Value
        {
            get
            {
                return value;
            }
        }

        /// <summary>
        /// Implicitly converts a string to a <see cref="Code"/> instance.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        /// <returns>A new <see cref="Code"/> instance wrapping the provided string.</returns>
        public static implicit operator Code?(string? value)
        {
            return new Code(value);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Code"/> instance to its underlying string value.
        /// </summary>
        /// <param name="code">The <see cref="Code"/> object to convert.</param>
        /// <returns>The source code string, or null if the object is null.</returns>
        public static implicit operator string?(Code? code)
        {
            return code?.value;
        }
    }
}