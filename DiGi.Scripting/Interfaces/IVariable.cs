namespace DiGi.Scripting.Interfaces
{
    /// <summary>
    /// Defines a script variable that possesses a name and a value. This interface extends <see cref="IScriptingObject"/>.
    /// </summary>
    public interface IVariable : IScriptingObject
    {
        /// <summary>
        /// Gets the name of the variable.
        /// </summary>
        string? Name { get; }

        /// <summary>
        /// Gets the value associated with the variable.
        /// </summary>
        object? Value { get; }
    }
}