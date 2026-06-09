using System;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// Represents a script output variable.
    /// </summary>
    public class Output : Variable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Output"/> class by copying another output variable.
        /// </summary>
        /// <param name="output">The source output variable to copy.</param>
        public Output(Output? output)
            : base(output)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Output"/> class with specified name, type, and value.
        /// </summary>
        /// <param name="name">The name of the output variable.</param>
        /// <param name="type">The data type of the output variable.</param>
        /// <param name="value">The initial value of the output variable.</param>
        public Output(string? name, Type? type, object? value)
            : base(name, type, value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Output"/> class with specified variable type and value.
        /// </summary>
        /// <param name="variableType">The <see cref="VariableType"/> defining the name and type of the output variable.</param>
        /// <param name="value">The initial value of the output variable.</param>
        public Output(VariableType? variableType, object? value)
            : base(variableType, value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Output"/> class.
        /// </summary>
        protected Output()
                                    : base()
        {
        }
    }
}