using DiGi.Core.Interfaces;
using DiGi.Scripting.Interfaces;
using System;

namespace DiGi.Scripting.Classes
{
    public class Input : Variable, IInput
    {
        public Input(Input? input)
            : base(input)
        {

        }

        public Input(string? name, Type? type, object? value)
            : base(name, type, value)
        {

        }

        public Input(VariableType? variableType, object? value)
            : base(variableType, value)
        {
        }

        protected Input()
                                    : base()
        {
        }
    }
}
