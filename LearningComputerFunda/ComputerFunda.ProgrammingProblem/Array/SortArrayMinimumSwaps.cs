namespace ComputerFunda.ProgrammingProblem.Array
{
    public static class SortArrayMinimumSwaps
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/minimum-swaps-2/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /// </summary>
        /// <param name="a"></param>
        /// <param name="d"></param>
        /// <returns>array</returns>
        public static int MinimumSwaps(int[] arr)
        {
            int count = 0;
            int size = arr.Length;
            //int lowestnumberindex = 0;
            for (int i = 0; i < size; i++)
            {

                if (arr[i] != i + 1 && i + 1 < size)
                {
                    again:
                    int j = System.Math.Min(size - 1, arr[i] - 1);
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    count++;
                    if (arr[i] != i + 1)
                        goto again;
                }
            }
            return count;
            //		lowestnumberindex = i;
            //		for (int j = i + 1; j < size; j++)
            //		{
            //			if (arr[j] < arr[lowestnumberindex] && arr[j] < arr[i])
            //			{
            //				lowestnumberindex = j;
            //			}
            //		}
            //		if (lowestnumberindex != i )
            //		{
            //			int temp = arr[i]; ;
            //			arr[i] = arr[lowestnumberindex];
            //			arr[lowestnumberindex] = temp;
            //			count++;
            //		}
            //}

        }
    }
}
