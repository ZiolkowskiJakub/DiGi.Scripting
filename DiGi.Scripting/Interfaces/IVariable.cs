namespace DiGi.Scripting.Interfaces
{
    public interface IVariable : IScriptingObject
    {
        string? Name { get; }

        object? Value { get; }
    }
}