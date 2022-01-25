﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string
        on the outside and the longer string on the inside. The strings will not be the same length, but
        they may be empty (length 0).
        ComboString("Hello", "hi") → "hiHellohi"
        ComboString("hi", "Hello") → "hiHellohi"
        ComboString("aaa", "b") → "baaab"
        */
        public string ComboString(string a, string b)
        {
            if ((a.Length > b.Length) && (b.Length > 0))
            {
                return b + a + b;
            }
            else if ((b.Length > a.Length) && (a.Length > 0))
            {
                return a + b + a;
            }        
            else if ((a.Length > b.Length) && (b.Length == 0))
            {
                return a;
            }
            else if ((b.Length > a.Length) && (a.Length == 0))
            {
                return b;
            }
            else
            {
                return "";
            }
        }
    }
}
