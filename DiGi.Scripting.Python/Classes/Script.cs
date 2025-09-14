using DiGi.Scripting.Core.Classes;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Scripting.Python.Classes
{
    public class Script : Core.Classes.Script
    {
        public Script(Code code, IEnumerable<VariableType> inputVariableTypes, IEnumerable<VariableType> outputVariableTypes) 
            : base(code, inputVariableTypes, outputVariableTypes)
        {
        }

        public Script(Script script)
            : base(script)
        {

        }

        public Script(JsonObject jsonObject)
            : base(jsonObject) 
        {
            
        }

        public override Response Execute(Data? inputData = null)
        {
            Code? code = Code;

            if(string.IsNullOrWhiteSpace(code))
            {
                return new Response(new CodeMissingException());
            }

            IEnumerable<VariableType>? inputVariableTypes = InputVariableTypes;
            IEnumerable<VariableType>? outputVariableTypes = OutputVariableTypes;

            ScriptEngine scriptEngine = IronPython.Hosting.Python.CreateEngine();

            ScriptScope scriptScope = scriptEngine.CreateScope();
            if(inputData != null && inputData.Count != 0)
            {
                Dictionary<string, object> dictionary = [];
                foreach(KeyValuePair<string, object> input in inputData)
                {
                    if(string.IsNullOrWhiteSpace(input.Key))
                    {
                        continue;
                    }

                    dictionary[input.Key] = input.Value;
                }

                if(inputVariableTypes is not null)
                {
                    foreach (VariableType variableType in inputVariableTypes)
                    {
                        if (string.IsNullOrWhiteSpace(variableType?.Name) || !dictionary.TryGetValue(variableType!.Name!, out object value))
                        {
                            continue;
                        }

                        scriptScope.SetVariable(variableType.Name, value);
                    }
                }
            }

            try
            {
                scriptEngine.Execute(code, scriptScope);
            }
            catch(Exception exception)
            {
                return new Response(exception);
            }

            List<Output>? outputs = null;
            if(outputVariableTypes != null)
            {
                outputs = [];
                foreach(VariableType variableType in outputVariableTypes)
                {
                    if(string.IsNullOrWhiteSpace(variableType?.Name))
                    {
                        continue;
                    }

                    if(!scriptScope.TryGetVariable(variableType!.Name, out dynamic value))
                    {
                        continue;
                    }

                    outputs.Add(new Output(variableType, value));
                }
            }

            return new Response(outputs);
        }
    }
}
