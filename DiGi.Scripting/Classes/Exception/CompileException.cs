using System;

namespace DiGi.Scripting.Core.Classes
{
    public class CompileException : Exception
    {
        public CompileException(string message) 
            :base(message)
        { 
        }
    }
}
