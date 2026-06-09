using DiGi.Scripting.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// Represents the result of a script execution, containing either the produced <see cref="Output"/> variables or an exception if the execution failed.
    /// </summary>
    public class Response : IScriptingObject
    {
        private readonly Exception? exception;
        private Dictionary<string, Output>? outputDictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Response"/> class with the specified exception.
        /// </summary>
        /// <param name="exception">The exception that occurred during script execution, or null if none.</param>
        public Response(Exception? exception)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response"/> class with the specified collection of outputs.
        /// </summary>
        /// <param name="outputs">The collection of <see cref="Output"/> variables produced by the script.</param>
        public Response(IEnumerable<Output>? outputs)
        {
            Outputs = outputs;
        }

        /// <summary>
        /// Gets the exception that occurred during script execution, if any.
        /// </summary>
        public Exception? Exception
        {
            get
            {
                return exception;
            }
        }

        /// <summary>
        /// Gets the collection of <see cref="Output"/> variables produced by the script.
        /// </summary>
        public IEnumerable<Output>? Outputs
        {
            get
            {
                return outputDictionary?.Values;
            }

            private set
            {
                outputDictionary = null;
                if (value == null)
                {
                    return;
                }

                outputDictionary = [];
                foreach (Output output in value)
                {
                    if (string.IsNullOrWhiteSpace(output?.Name))
                    {
                        continue;
                    }

                    outputDictionary[output!.Name!] = output;
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether the script execution succeeded without throwing an exception.
        /// </summary>
        public bool Succeeded
        {
            get
            {
                return exception == null;
            }
        }
    }
}