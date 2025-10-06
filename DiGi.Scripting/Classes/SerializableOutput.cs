using DiGi.Core.Interfaces;
using DiGi.Scripting.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Scripting.Classes
{
    public class SerializableOutput : Output, ISerializableOutput
    {
        public SerializableOutput(SerializableOutput? serializableOutput)
            : base(serializableOutput)
        {

        }

        public SerializableOutput(JsonObject? jsonObject)
            :base()
        {
            FromJsonObject(jsonObject);
        }

        public SerializableOutput(string? name, double value)
            :base(name, typeof(double), value)
        {

        }

        public SerializableOutput(string? name, string value)
            : base(name, typeof(string), value)
        {

        }

        public SerializableOutput(string? name, System.Guid value)
            : base(name, typeof(System.Guid), value)
        {

        }

        public SerializableOutput(string? name, int value)
            : base(name, typeof(int), value)
        {

        }

        public SerializableOutput(string? name, byte value)
            : base(name, typeof(byte), value)
        {

        }

        public SerializableOutput(string? name, long value)
            : base(name, typeof(long), value)
        {

        }

        public SerializableOutput(string? name, ISerializableObject value)
            : base(name, value?.GetType() ?? typeof(ISerializableObject), value)
        {

        }

        public SerializableOutput(string? name, System.DateTime value)
            : base(name, typeof(System.DateTime), value)
        {

        }

        public SerializableOutput(string? name, double[] value)
            : base(name, typeof(double[]), value)
        {

        }

        public SerializableOutput(string? name, string[] value)
            : base(name, typeof(string[]), value)
        {

        }

        public SerializableOutput(string? name, System.Guid[] value)
            : base(name, typeof(System.Guid[]), value)
        {

        }

        public SerializableOutput(string? name, int[] value)
            : base(name, typeof(int[]), value)
        {

        }

        public SerializableOutput(string? name, byte[] value)
            : base(name, typeof(byte[]), value)
        {

        }

        public SerializableOutput(string? name, long[] value)
            : base(name, typeof(long[]), value)
        {

        }

        public SerializableOutput(string? name, ISerializableObject[] value)
            : base(name, value?.GetType() ?? typeof(ISerializableObject[]), value)
        {

        }

        public SerializableOutput(string? name, System.DateTime[] value)
            : base(name, typeof(System.DateTime[]), value)
        {

        }

        public ISerializableObject? Clone()
        {
            return new SerializableOutput(this);
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
