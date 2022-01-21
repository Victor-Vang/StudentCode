﻿namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        4a. Return the first element of the array from the parameters
            TOPIC: Accessing Array Elements
        */
        public int ReturnFirstElementOfParam(int[] passedInArray)
        {
            return passedInArray [0];
        }

        /*
        4b. Set the first element in the array to 100.
            TOPIC: Setting Array Elements
        */
        public void SetFirstElement(int[] passedInArray)
        {
            passedInArray[0] = 100;
            return;
        }
    }
}
