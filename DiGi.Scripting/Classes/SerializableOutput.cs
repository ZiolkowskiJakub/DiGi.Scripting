using DiGi.Core.Interfaces;
using DiGi.Scripting.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// Represents a serializable script output variable that implements <see cref="ISerializableOutput"/>.
    /// </summary>
    public class SerializableOutput : Output, ISerializableOutput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class by copying another serializable output.
        /// </summary>
        /// <param name="serializableOutput">The source <see cref="SerializableOutput"/> to copy from.</param>
        public SerializableOutput(SerializableOutput? serializableOutput)
            : base(serializableOutput)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to populate the instance.</param>
        public SerializableOutput(JsonObject? jsonObject)
            : base()
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with a double value.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The double value to assign.</param>
        public SerializableOutput(string? name, double value)
            : base(name, typeof(double), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with a string value.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The string value to assign.</param>
        public SerializableOutput(string? name, string value)
            : base(name, typeof(string), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with a GUID value.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The <see cref="System.Guid"/> value to assign.</param>
        public SerializableOutput(string? name, System.Guid value)
            : base(name, typeof(System.Guid), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an integer value.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The integer value to assign.</param>
        public SerializableOutput(string? name, int value)
            : base(name, typeof(int), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with a byte value.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The byte value to assign.</param>
        public SerializableOutput(string? name, byte value)
            : base(name, typeof(byte), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with a long value.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The long value to assign.</param>
        public SerializableOutput(string? name, long value)
            : base(name, typeof(long), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an <see cref="ISerializableObject"/> value.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The serializable object value to assign.</param>
        public SerializableOutput(string? name, ISerializableObject value)
            : base(name, value?.GetType() ?? typeof(ISerializableObject), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with a DateTime value.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The <see cref="System.DateTime"/> value to assign.</param>
        public SerializableOutput(string? name, System.DateTime value)
            : base(name, typeof(System.DateTime), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an array of doubles.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The double array value to assign.</param>
        public SerializableOutput(string? name, double[] value)
            : base(name, typeof(double[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an array of strings.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The string array value to assign.</param>
        public SerializableOutput(string? name, string[] value)
            : base(name, typeof(string[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an array of GUIDs.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The <see cref="System.Guid"/> array value to assign.</param>
        public SerializableOutput(string? name, System.Guid[] value)
            : base(name, typeof(System.Guid[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an array of integers.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The integer array value to assign.</param>
        public SerializableOutput(string? name, int[] value)
            : base(name, typeof(int[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an array of bytes.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The byte array value to assign.</param>
        public SerializableOutput(string? name, byte[] value)
            : base(name, typeof(byte[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an array of longs.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The long array value to assign.</param>
        public SerializableOutput(string? name, long[] value)
            : base(name, typeof(long[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an array of <see cref="ISerializableObject"/>.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The serializable object array value to assign.</param>
        public SerializableOutput(string? name, ISerializableObject[] value)
            : base(name, value?.GetType() ?? typeof(ISerializableObject[]), value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOutput"/> class with an array of DateTimes.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="value">The <see cref="System.DateTime"/> array value to assign.</param>
        public SerializableOutput(string? name, System.DateTime[] value)
            : base(name, typeof(System.DateTime[]), value)
        {
        }

        /// <summary>
        /// Creates a deep copy of the serializable output.
        /// </summary>
        /// <returns>A cloned instance as an <see cref="ISerializableObject"/>.</returns>
        public ISerializableObject? Clone()
        {
            return new SerializableOutput(this);
        }

        /// <summary>
        /// Populates the object's properties from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> to read data from.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return DiGi.Core.Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Converts the object to a JSON representation.
        /// </summary>
        /// <returns>A <see cref="JsonObject"/> representing this instance.</returns>
        public JsonObject? ToJsonObject()
        {
            return DiGi.Core.Convert.ToJson(this);
        }
    }
}