namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a non-empty string like "Code" return a string like "CCoCodCode".
        StringSplosion("Code") → "CCoCodCode"
        StringSplosion("abc") → "aababc"
        StringSplosion("ab") → "aab"
        */
        public string StringSplosion(string str)
        {
            string stringSplosion = "";
            string recurring = "";
            for (int i = 0; i < str.Length; i++)
            {
                stringSplosion = stringSplosion + str[i];
                recurring = recurring + stringSplosion;
            }
            return recurring;
        }
    }
}
