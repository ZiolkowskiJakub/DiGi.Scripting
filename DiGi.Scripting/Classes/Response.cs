using DiGi.Scripting.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Scripting.Classes
{
    public class Response : IScriptingObject
    {
        private readonly Exception? exception;
        private Dictionary<string, Output>? outputDictionary;

        public Response(Exception? exception)
        {
            this.exception = exception;
        }

        public Response(IEnumerable<Output>? outputs)
        {
            Outputs = outputs;
        }

        public Exception? Exception
        {
            get
            {
                return exception;
            }
        }

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
        
        public bool Succeeded
        {
            get
            {
                return exception == null;
            }
        }

    }
}
