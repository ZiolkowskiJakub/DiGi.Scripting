using System;

namespace DiGi.Scripting.Classes
{
    public class CompileException : Exception
    {
        public CompileException(string? message)
            : base(message)
        {
        }
    }
}