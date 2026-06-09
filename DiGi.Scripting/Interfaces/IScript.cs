namespace DiGi.Scripting.Interfaces
{
    /// <summary>
    /// Defines the contract for a script object that is both scripting-compatible and serializable, 
    /// inheriting from <see cref="IScriptingSerializableObject"/>.
    /// </summary>
    public interface IScript : IScriptingSerializableObject
    {
    }
}