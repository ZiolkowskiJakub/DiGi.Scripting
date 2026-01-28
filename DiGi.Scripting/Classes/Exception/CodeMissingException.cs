using System;

namespace DiGi.Scripting.Classes
{
    public class CodeMissingException : Exception
    {
        public CodeMissingException()
            : base("Code missing")
        {
        }
    }
}