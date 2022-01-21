namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Given 2 int values, return the larger value that is in the range 10..20 inclusive,
         or return 0 if neither is in that range.
         Max1020(11, 19) → 19
         Max1020(19, 11) → 19
         Max1020(11, 9) → 11
         */
        public int Max1020(int a, int b)
        {
            if ((((a > 9) && (a < 21)) && ((b > 9) && (b < 21))) && (a > b))
            {
                return a;
            }
            else if ((((a > 9) && (a < 21)) && ((b > 9) && (b < 21))) && (b > a))
            {
                return b;
            } 
            else if (((a > 9) && (a < 21)) && ((b < 10) || (b > 20)))
            {
                return a;
            }
            else if (((b > 9) && (b < 21)) && ((a < 10) || (a > 20)))
            {
                return b;
            }
          else
            {
                return 0;
            }
        }
    }
}
