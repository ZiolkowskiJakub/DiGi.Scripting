using DiGi.Core.Interfaces;
using DiGi.Scripting.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// Represents a script input variable that can be serialized and deserialized.
    /// </summary>
    public class SerializableInput : Input, ISerializableInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class by copying another serializable input.
        /// </summary>
        /// <param name="serializableInput">The source serializable input to copy from.</param>
        public SerializableInput(SerializableInput? serializableInput)
            : base(serializableInput)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data.</param>
        public SerializableInput(JsonObject? jsonObject)
            : base()
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and double value.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The double value to assign.</param>
        public SerializableInput(string? name, double value)
            : base(name, typeof(double), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and string value.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The string value to assign.</param>
        public SerializableInput(string? name, string value)
            : base(name, typeof(string), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and Guid value.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The Guid value to assign.</param>
        public SerializableInput(string? name, System.Guid value)
            : base(name, typeof(System.Guid), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and integer value.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The integer value to assign.</param>
        public SerializableInput(string? name, int value)
            : base(name, typeof(int), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and byte value.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The byte value to assign.</param>
        public SerializableInput(string? name, byte value)
            : base(name, typeof(byte), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and long value.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The long value to assign.</param>
        public SerializableInput(string? name, long value)
            : base(name, typeof(long), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and serializable object value.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The <see cref="ISerializableObject"/> value to assign.</param>
        public SerializableInput(string? name, ISerializableObject value)
            : base(name, value?.GetType() ?? typeof(ISerializableObject), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and DateTime value.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The DateTime value to assign.</param>
        public SerializableInput(string? name, System.DateTime value)
            : base(name, typeof(System.DateTime), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and array of doubles.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The double array to assign.</param>
        public SerializableInput(string? name, double[] value)
            : base(name, typeof(double[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and array of strings.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The string array to assign.</param>
        public SerializableInput(string? name, string[] value)
            : base(name, typeof(string[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and array of Guids.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The Guid array to assign.</param>
        public SerializableInput(string? name, System.Guid[] value)
            : base(name, typeof(System.Guid[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and array of integers.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The integer array to assign.</param>
        public SerializableInput(string? name, int[] value)
            : base(name, typeof(int[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and array of bytes.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The byte array to assign.</param>
        public SerializableInput(string? name, byte[] value)
            : base(name, typeof(byte[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and array of longs.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The long array to assign.</param>
        public SerializableInput(string? name, long[] value)
            : base(name, typeof(long[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and array of serializable objects.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The <see cref="ISerializableObject"/> array to assign.</param>
        public SerializableInput(string? name, ISerializableObject[] value)
            : base(name, value?.GetType() ?? typeof(ISerializableObject[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableInput"/> class with a specified name and array of DateTimes.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="value">The DateTime array to assign.</param>
        public SerializableInput(string? name, System.DateTime[] value)
            : base(name, typeof(System.DateTime[]), value)
        {
        }

        /// <summary>
        /// Creates a deep copy of the serializable input.
        /// </summary>
        /// <returns>A clone of the current instance as an <see cref="ISerializableObject"/>.</returns>
        public ISerializableObject? Clone()
        {
            return new SerializableInput(this);
        }

        /// <summary>
        /// Populates the properties of the serializable input from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to read data from.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return DiGi.Core.Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Converts the serializable input to its JSON representation.
        /// </summary>
        /// <returns>A <see cref="JsonObject"/> representing the current instance.</returns>
        public JsonObject? ToJsonObject()
        {
            return DiGi.Core.Convert.ToJson(this);
        }
    }
}