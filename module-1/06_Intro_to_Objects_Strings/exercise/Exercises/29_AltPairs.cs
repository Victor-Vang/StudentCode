namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
        AltPairs("kitten") → "kien"
        AltPairs("Chocolate") → "Chole"
        AltPairs("CodingHorror") → "Congrr"
        */
        public string AltPairs(string str)
        {
            string finalResult = "";
            string everyOtherTwo = "";
            if (str.Length <= 2)
            {
                return str;
            }
            for (int i = 0; i < str.Length; i += 4)
            {
                if (i < str.Length - 1)
                {
                    everyOtherTwo = "" + str[i] + str[i + 1];
                    finalResult = finalResult + everyOtherTwo;
                }
                else
                {
                    everyOtherTwo = "" + str[i];
                    finalResult = finalResult + everyOtherTwo;
                }
            }
            return finalResult; //come back and check out to simplify
        }
    }
}
