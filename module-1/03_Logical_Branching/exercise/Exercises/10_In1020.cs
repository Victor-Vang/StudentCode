﻿namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Given 2 int values, return true if either of them is in the range 10..20 inclusive.
         In1020(12, 99) → true
         In1020(21, 12) → true
         In1020(8, 99) → false
         */
        public bool In1020(int a, int b)
        {
            if (((a > 9) && (a < 21)) || ((b > 9) && (b < 21)))
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
