using System;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// The exception that is thrown when script source code is missing.
    /// </summary>
    public class CodeMissingException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeMissingException"/> class.
        /// </summary>
        public CodeMissingException()
            : base("Code missing")
        {
        }
    }
}