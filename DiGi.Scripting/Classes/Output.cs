using System;

namespace DiGi.Scripting.Classes
{
    public class Output : Variable
    {
        public Output(Output? output)
            : base(output)
        {
        }

        public Output(string? name, Type? type, object? value)
            : base(name, type, value)
        {
        }

        public Output(VariableType? variableType, object? value)
            : base(variableType, value)
        {
        }

        protected Output()
                                    : base()
        {
        }
    }
}