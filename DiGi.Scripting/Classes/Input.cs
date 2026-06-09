using DiGi.Scripting.Interfaces;
using System;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// Represents a script input variable, extending the base <see cref="Variable"/> class and implementing <see cref="IInput"/>.
    /// </summary>
    public class Input : Variable, IInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Input"/> class by copying another input variable.
        /// </summary>
        /// <param name="input">The source <see cref="Input"/> object to copy from.</param>
        public Input(Input? input)
            : base(input)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Input"/> class with a specified name, type, and value.
        /// </summary>
        /// <param name="name">The name of the input variable.</param>
        /// <param name="type">The <see cref="Type"/> of the input variable.</param>
        /// <param name="value">The initial value of the input variable.</param>
        public Input(string? name, Type? type, object? value)
            : base(name, type, value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Input"/> class using a <see cref="VariableType"/> and a value.
        /// </summary>
        /// <param name="variableType">The <see cref="VariableType"/> defining the name and type of the variable.</param>
        /// <param name="value">The initial value of the input variable.</param>
        public Input(VariableType? variableType, object? value)
            : base(variableType, value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Input"/> class.
        /// </summary>
        protected Input()
            : base()
        {
        }
    }
}