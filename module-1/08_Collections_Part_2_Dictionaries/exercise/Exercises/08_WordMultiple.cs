using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, int> temp = new Dictionary<string, int>();
            Dictionary<string, bool> result = new Dictionary<string, bool>();

            foreach (string item in words)
            {
                if (temp.ContainsKey(item))
                {
                    temp[item] += 1;
                }
                else
                {
                    temp[item] = 1;
                }
            } 

            foreach (KeyValuePair<string, int> item in temp)
            {
                if (item.Value > 1)
                {
                    result[item.Key] = true;
                }
                else
                {
                    result[item.Key] = false;
                }
            }
            return result;
        }
    }
}
