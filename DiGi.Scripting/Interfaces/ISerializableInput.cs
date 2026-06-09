namespace DiGi.Scripting.Interfaces
{
    /// <summary>
    /// Defines a script input variable that is serializable, combining the properties of <see cref="IInput"/> and <see cref="DiGi.Core.Interfaces.ISerializableObject"/>.
    /// </summary>
    public interface ISerializableInput : IInput, DiGi.Core.Interfaces.ISerializableObject
    {
    }
}