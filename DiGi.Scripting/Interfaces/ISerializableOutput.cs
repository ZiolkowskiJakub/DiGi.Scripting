namespace DiGi.Scripting.Interfaces
{
    /// <summary>
    /// Defines a script output variable that is serializable, combining the properties of <see cref="IOutput"/> and <see cref="DiGi.Core.Interfaces.ISerializableObject"/>.
    /// </summary>
    public interface ISerializableOutput : IOutput, DiGi.Core.Interfaces.ISerializableObject
    {
    }
}