﻿using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> result = new List<int>(listOne.Count + listTwo.Count);

            if (listOne.Count >= listTwo.Count)
            {
                foreach (int item in listOne)
                {
                    result.Add(item);
                }
                for (int i = 0; i < listTwo.Count; i++)
                {
                    int spot = listTwo[i];
                    result.Insert(((i * 2) + 1), spot);
                }
            }
            else if (listTwo.Count > listOne.Count)
            {
                foreach (int item in listTwo)
                {
                    result.Add(item);
                }
                for (int i = 1; i < listOne.Count; i++)
                {
                    int spot = listOne[i];
                    result.Insert((i * 2) - 1, spot);
                }
                result.Insert(0, listOne[0]);
            }
            return result;
        }
    }
}
