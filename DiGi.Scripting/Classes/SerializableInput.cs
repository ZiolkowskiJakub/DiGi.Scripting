using DiGi.Core.Interfaces;
using DiGi.Scripting.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Scripting.Classes
{
    public class SerializableInput : Input, ISerializableInput
    {
        public SerializableInput(SerializableInput? serializableInput)
            : base(serializableInput)
        {
        }

        public SerializableInput(JsonObject? jsonObject)
            : base()
        {
            FromJsonObject(jsonObject);
        }

        public SerializableInput(string? name, double value)
            : base(name, typeof(double), value)
        {
        }

        public SerializableInput(string? name, string value)
            : base(name, typeof(string), value)
        {
        }

        public SerializableInput(string? name, System.Guid value)
            : base(name, typeof(System.Guid), value)
        {
        }

        public SerializableInput(string? name, int value)
            : base(name, typeof(int), value)
        {
        }

        public SerializableInput(string? name, byte value)
            : base(name, typeof(byte), value)
        {
        }

        public SerializableInput(string? name, long value)
            : base(name, typeof(long), value)
        {
        }

        public SerializableInput(string? name, ISerializableObject value)
            : base(name, value?.GetType() ?? typeof(ISerializableObject), value)
        {
        }

        public SerializableInput(string? name, System.DateTime value)
            : base(name, typeof(System.DateTime), value)
        {
        }

        public SerializableInput(string? name, double[] value)
            : base(name, typeof(double[]), value)
        {
        }

        public SerializableInput(string? name, string[] value)
            : base(name, typeof(string[]), value)
        {
        }

        public SerializableInput(string? name, System.Guid[] value)
            : base(name, typeof(System.Guid[]), value)
        {
        }

        public SerializableInput(string? name, int[] value)
            : base(name, typeof(int[]), value)
        {
        }

        public SerializableInput(string? name, byte[] value)
            : base(name, typeof(byte[]), value)
        {
        }

        public SerializableInput(string? name, long[] value)
            : base(name, typeof(long[]), value)
        {
        }

        public SerializableInput(string? name, ISerializableObject[] value)
            : base(name, value?.GetType() ?? typeof(ISerializableObject[]), value)
        {
        }

        public SerializableInput(string? name, System.DateTime[] value)
            : base(name, typeof(System.DateTime[]), value)
        {
        }

        public ISerializableObject? Clone()
        {
            return new SerializableInput(this);
        }

        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return DiGi.Core.Modify.FromJsonObject(this, jsonObject);
        }

        public JsonObject? ToJsonObject()
        {
            return DiGi.Core.Convert.ToJson(this);
        }
    }
}