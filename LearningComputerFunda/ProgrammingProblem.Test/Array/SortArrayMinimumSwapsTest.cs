using ComputerFunda.ProgrammingProblem.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerFunda.DataStructure.Test.ArrayList
{
    [TestClass]
    public class SortArrayMinimumSwapsTest
    {
        [TestMethod]
        public void TestLeftRotation_RotationLessThanSize()
        {
            int[] arr = new int[] { 1, 3, 5, 2, 4, 6, 8 };
                       
            Assert.AreEqual(3, SortArrayMinimumSwaps.MinimumSwaps(arr));
        }
      
    }
}
