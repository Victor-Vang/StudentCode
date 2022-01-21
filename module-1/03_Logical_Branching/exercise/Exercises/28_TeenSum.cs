﻿namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Given 2 ints, a and b, return their sum. However, "teen" values in the range 13..19 inclusive, are
         extra lucky. So if either value is a teen, just return 19.
         TeenSum(3, 4) → 7
         TeenSum(10, 13) → 19
         TeenSum(13, 2) → 19
         */
        public int TeenSum(int a, int b)
        {
            if (((a < 13) || (a > 19)) && ((b < 13) || (b > 19)))
            {
                return (a + b);
            }
           else if (((a > 12) || (a < 20)) || ((b > 12) || (b < 20)))
            {
                return 19;
            }
            else
            {
                return (a + b);
            }
        }
    }
}
