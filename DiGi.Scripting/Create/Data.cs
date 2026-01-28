using DiGi.Scripting.Classes;
using DiGi.Scripting.Interfaces;
using System.Collections.Generic;

namespace DiGi.Scripting.Core
{
    public static partial class Create
    {
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