﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of ints, divide each int by 2, and return a List of Doubles.
        ArrayInt2ListDouble( {5, 8, 11, 200, 97} ) -> [2.5, 4.0, 5.5, 100, 48.5]
        ArrayInt2ListDouble( {745, 23, 44, 9017, 6} ) -> [372.5, 11.5, 22, 4508.5, 3]
        ArrayInt2ListDouble( {84, 99, 3285, 13, 877} ) -> [42, 49.5, 1642.5, 6.5, 438.5]
        */
        public List<double> ArrayInt2ListDouble(int[] intArray)
        {
            //List<double> result = new List<double>();

            //double[] convertedArray = new double[intArray.Length];

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    double conversion = intArray[i] / 2.0;
            //    convertedArray[i] = conversion;
            //}

            //foreach (double item in convertedArray)
            //{
            //    result.Add(item);
            //}

            //return result;

            List<double> result = new List<double>();

            foreach (int item in intArray)
            {
                result.Add(item / 2.0);
            }

            return result;
        }
    }
}
