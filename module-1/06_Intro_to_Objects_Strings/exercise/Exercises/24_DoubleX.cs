namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
        DoubleX("axxbb") → true
        DoubleX("axaxax") → false
        DoubleX("xxxxx") → true
        */
        public bool DoubleX(string str)
        {
            bool isThereX = str.Contains("x");
            int firstX = str.IndexOf("x");

            if (str == "")
            {
                return false;
            }
            else if ((str[str.Length - 1] == 'x') && (firstX == str.Length - 1))
            {
                return false;
            }
            else if ((isThereX) && (str[firstX + 1] == 'x')) //&& (firstX != str[str.Length - 1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
