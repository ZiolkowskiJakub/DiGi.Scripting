using DiGi.Scripting.Classes;
using DiGi.Scripting.Interfaces;
using System.Collections.Generic;

namespace DiGi.Scripting.Core
{
#pragma warning disable CS1591

    public static partial class Create
#pragma warning restore CS1591
    {
        /// <summary>
        /// Converts a collection of <see cref="IInput"/> objects into a <see cref="Data"/> object.
        /// </summary>
        /// <typeparam name="TInput">The type of input variables, which must implement <see cref="IInput"/>.</typeparam>
        /// <param name="inputs">A collection of input variables to be converted.</param>
        /// <returns>A <see cref="Data"/> instance containing the name-value pairs from the inputs, or <c>null</c> if the input collection is null.</returns>
        public static Data? Data<TInput>(this IEnumerable<TInput> inputs) where TInput : IInput
        {
            if (inputs == null)
            {
                return null;
            }
            Data result = [];
            foreach (IInput input in inputs)
            {
                if (input == null || string.IsNullOrWhiteSpace(input.Name))
                {
                    continue;
                }

                result[input.Name!] = input.Value;
            }

            return result;
        }
    }
}