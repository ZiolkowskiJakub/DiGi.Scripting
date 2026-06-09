using System.Collections.Generic;

namespace DiGi.Scripting.Classes
{
    /// <summary>
    /// A key/value store for script execution data, extending <see cref="Dictionary{TKey, TValue}"/>.
    /// </summary>
    public class Data : Dictionary<string, dynamic?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data"/> class.
        /// </summary>
        public Data()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data"/> class using an existing dictionary.
        /// </summary>
        /// <param name="dictionary">The source dictionary containing values to be copied into this instance.</param>
        public Data(IDictionary<string, object?>? dictionary)
        {
            if (dictionary != null)
            {
                foreach (KeyValuePair<string, dynamic?> keyValuePair in dictionary)
                {
                    this[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data"/> class using a collection of key-value pairs.
        /// </summary>
        /// <param name="keyValuePairs">The collection of key-value pairs to initialize this instance with.</param>
        public Data(IEnumerable<KeyValuePair<string, dynamic?>>? keyValuePairs)
        {
            if (keyValuePairs != null)
            {
                foreach (KeyValuePair<string, dynamic?> keyValuePair in keyValuePairs)
                {
                    this[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        /// <summary>
        /// Gets a <see cref="Dictionary{TKey, TValue}"/> representation of the current data.
        /// </summary>
        public Dictionary<string, dynamic?> Dictionary
        {
            get
            {
                return new Dictionary<string, dynamic?>(this);
            }
        }
    }
}