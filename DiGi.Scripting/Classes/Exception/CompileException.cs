using System;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// The exception that is thrown when an error occurs during the compilation of a script.
    /// </summary>
    public class CompileException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompileException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public CompileException(string? message)
            : base(message)
        {
        }
    }
}