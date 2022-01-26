namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            bool startsWithX = str.StartsWith("x");
            bool endsWithX = str.EndsWith("x");

            string replacement = "";
            string fullStringReplacement = replacement;

            for (int i = 0; i < str.Length; i++)
            {
                if (str == "x")
                {
                    return str;
                }    
                else if ((str.Contains("x")) && ((startsWithX) && (endsWithX)))
                {
                    replacement = str.Replace("x", "");
                    return "x" + replacement + "x";
                }

                else if ((str.Contains("x")) && ((startsWithX) && (!endsWithX)))
                {
                    replacement = str.Replace("x", "");
                    return "x" + replacement;
                }
                else if ((str.Contains("x")) && ((!startsWithX) && (endsWithX)))
                {
                    replacement = str.Replace("x", "");
                    return replacement + "x";
                }
                else if (str.Contains("x"))
                {
                    replacement = str.Replace("x", "");
                    return replacement;
                }
            }
            return str;
        }
    }
}
