using ComputerFunda.ProgrammingProblem.Sorting;
using System.Collections.Generic;

namespace ComputerFunda.ProgrammingProblem.BackTracking
{
    public class CombinationSum
    {
        private int[] _arr;
        private ISort _sortHelper;
        private List<int[]> consoleResult = new List<int[]>();

        public CombinationSum(int[] arr, ISort sortHelper)
        {
            _arr = arr;
            _sortHelper = sortHelper;
        }

        public List<int[]> FindCombinationSum(int sum)
        {
            _arr = _sortHelper.Sort(_arr);
            List<int> v = new List<int>();
            PerformUnitWork(sum, _arr.Length, v);

            return consoleResult;
        }

        private void PerformUnitWork(int sum, int n, List<int> v)
        {
            
        }
    }
}
