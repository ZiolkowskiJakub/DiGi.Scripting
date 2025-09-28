using System.Collections.Generic;

namespace DiGi.Scripting.Classes
{
    public class Data : Dictionary<string, dynamic>
    {
        public Data() 
        {
            
        }

        public Data(IDictionary<string, object>? dictionary)
        {
            if (dictionary != null)
            {
                foreach (KeyValuePair<string, dynamic> keyValuePair in dictionary)
                {
                    this[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        public Data(IEnumerable<KeyValuePair<string, dynamic>>? keyValuePairs)
        {
            if(keyValuePairs != null)
            {
                foreach (KeyValuePair<string, dynamic> keyValuePair in keyValuePairs)
                {
                    this[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        public Dictionary<string, dynamic> Dictionary
        {
            get
            {
                return new Dictionary<string, dynamic>(this);
            }
        }
    }
}
