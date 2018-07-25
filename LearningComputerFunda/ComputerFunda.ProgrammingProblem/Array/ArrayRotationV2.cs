using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Array
{
    public static class ArrayRotationV2
    {
        /// <summary>
        /// Rotates array less space then LeftRotation version build above.
        /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
        /// Idea: 
        /// Keep 0-d items in a new array
        /// Then move all the elements from d to length - 1 index with the same array starting from 0th index. This will cause d to length-1 indexed item in array as junk which we need to replace next with the temp array saved in previous step.
        /// Then Starting from d to length-1 in main array replace all the elements form temp array to main array.
        /// Return the result.
        /// Time complexity is n and space Auxilary complexity is d where d is number of rotations
        /// </summary>
        /// <param name="arr">Main array to be rotated</param>
        /// <param name="rotations">Number of rotations</param>
        /// <returns></returns>
        public static int[] RotateLeft(this int[] arr, int rotations)
        {
            /// handle edge conditions
            if (arr == null || arr.Length == 0 || arr.Length < rotations)
            {
                return arr;
            }

            /// temporarily store the elements in the swap array.
            int[] swap = new int[rotations];
            for (int i = 0; i < rotations; i++)
            {
                swap[i] = arr[i];
            }

            /// Move elements in place in the main array
            int index = 0;
            for (int i = rotations; i < arr.Length; i++)
            {
                arr[index] = arr[i];
                index++;
            }

            /// Add the swap array items at the back of the main array.
            int reIndex = 0;
            for (int i = arr.Length - rotations; i < arr.Length; i++)
            {
                arr[i] = swap[reIndex];
                reIndex++;
            }

            /// Return the result
            return arr;
        }
    }
}
