using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.ArrayList
{
    public static class ArrayOperations
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="a"></param>
        /// <param name="d"></param>
        /// <returns>array</returns>
        public static int[] LeftRotation(int[] a, int d)
        {
            int size = a.Length;
            if (d > size)
                d = d % size;
            int[] result = new int[size];
            int index = 0;
            for (int i = d; i < size; i++)
            {
                result[index] = a[i];
                index += 1;
            }
            index = size - d;
            for (int i = 0; i < d; i++)
            {
                result[index] = a[i];
                index += 1;
            }
            return result;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="q"></param>
        public static string MinimumBribes(int[] q)
        {
            int Bribes = 0;
            for (int i = q.Length; i > 0; i--)
            {
                int arrValue = q[i - 1];
                if (arrValue - i > 2)
                {
                    //Console.WriteLine();
                    return "Too chaotic";
                }
                int maxSwap = Math.Max(0, arrValue - 2);

                for (int j = maxSwap; j < i - 1; j++)
                {
                    if (q[j] > arrValue)
                    {
                        Bribes++;
                    }
                }
            }
            return Bribes.ToString();
            //Console.WriteLine(Bribes);

        }
    }
}
