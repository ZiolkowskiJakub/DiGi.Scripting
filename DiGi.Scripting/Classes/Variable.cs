using DiGi.Core.Interfaces;
using DiGi.Scripting.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// Abstract base class for script variables, providing a link between a <see cref="VariableType"/> and its current value.
    /// </summary>
    public abstract class Variable : IScriptingObject, INamedObject
    {
        [JsonInclude, JsonPropertyName("Value")]
        private readonly object? value;

        [JsonInclude, JsonPropertyName("VariableType")]
        private readonly VariableType? variableType;

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable"/> class with the specified type and value.
        /// </summary>
        /// <param name="variableType">The <see cref="VariableType"/> defining the variable's metadata.</param>
        /// <param name="value">The initial value of the variable.</param>
        public Variable(VariableType? variableType, object? value)
        {
            this.variableType = variableType;
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable"/> class by creating a <see cref="VariableType"/> from the provided name and type.
        /// </summary>
        /// <param name="name">The name of the variable.</param>
        /// <param name="type">The system <see cref="Type"/> of the variable.</param>
        /// <param name="value">The initial value of the variable.</param>
        public Variable(string? name, Type? type, object? value)
        {
            variableType = new VariableType(name, type);
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable"/> class by copying another variable.
        /// </summary>
        /// <param name="variable">The source <see cref="Variable"/> to copy from.</param>
        public Variable(Variable? variable)
        {
            if (variable is not null)
            {
                variableType = DiGi.Core.Query.Clone(variable.variableType);
                value = variable.value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable"/> class.
        /// </summary>
        protected Variable()
        {
        }

        /// <summary>
        /// Gets the name of the variable as defined in its <see cref="VariableType"/>.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return variableType?.Name;
            }
        }

        /// <summary>
        /// Gets the current value of the variable.
        /// </summary>
        [JsonIgnore]
        public object? Value
        {
            get
            {
                return value;
            }
        }

        /// <summary>
        /// Gets a clone of the <see cref="VariableType"/> associated with this variable.
        /// </summary>
        [JsonIgnore]
        public VariableType? VariableType
        {
            get
            {
                return DiGi.Core.Query.Clone(variableType);
            }
        }
    }
}