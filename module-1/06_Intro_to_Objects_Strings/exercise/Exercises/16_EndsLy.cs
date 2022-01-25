﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if it ends in "ly".
        EndsLy("oddly") → true
        EndsLy("y") → false
        EndsLy("oddy") → false
        */
        public bool EndsLy(string str)
        {
            bool endsWithLy = str.EndsWith("ly");
            if (endsWithLy)
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
