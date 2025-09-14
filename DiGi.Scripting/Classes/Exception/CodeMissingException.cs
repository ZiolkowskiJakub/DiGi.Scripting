using System;

namespace DiGi.Scripting.Core.Classes
{
    public class CodeMissingException : Exception
    {
        public CodeMissingException() 
            :base("Code missing")
        { 
        }
    }
}
