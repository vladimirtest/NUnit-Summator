using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            // the initial sum is equal to 0
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            // return sum
            return sum;
        }

        public static double Average(int[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i--)
            {
                sum += arr[i];
            }

            // return sum
            return sum / arr.Length;
        }

        // some comment for the new function
        public static long findMax(int[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            // return sum
            return sum;
        }
    }
}
