using DiGi.Core.Interfaces;

namespace DiGi.Scripting.Interfaces
{
    /// <summary>
    /// Defines a contract for an object that is both compatible with the scripting system (<see cref="IScriptingObject"/>) and serializable (<see cref="ISerializableObject"/>).
    /// </summary>
    public interface IScriptingSerializableObject : IScriptingObject, ISerializableObject
    {
    }
}