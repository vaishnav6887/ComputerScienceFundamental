using ComputerFunda.ProgrammingProblem.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Array
{
    [TestCategory("Matrix")]
    [TestClass]
    public class RotateMatrixTest
    {
        private RotateMatrix obj;

        [TestInitialize]
        public void Init()
        {
            int[,] input = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            obj = new RotateMatrix(input, 3);
        }

        [TestMethod]
        public void RotateMatrixBy90DegreeAntiClockWise_Positive_Test_3()
        {
            obj.RotateMatrixBy90DegreeAntiClockWise();

            int[,] expected = new int[,] { { 3, 6, 9 }, { 2, 5, 8 }, { 1, 4, 7 } };

            Assert.AreEqual(expected[0, 0], obj.Matrix[0, 0]);
            Assert.AreEqual(expected[0, 2], obj.Matrix[0, 2]);
            Assert.AreEqual(expected[2, 2], obj.Matrix[2, 2]);
            Assert.AreEqual(expected[2, 0], obj.Matrix[2, 0]);
        }

        [TestMethod]
        public void RotateMatrixBy180DegreeAntiClockWise_Positive_Test_3()
        {
            obj.RotateMatrixBy180DegreeAnticlockWise();

            int[,] expected = new int[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

            Assert.AreEqual(expected[0, 0], obj.Matrix[0, 0]);
            Assert.AreEqual(expected[0, 2], obj.Matrix[0, 2]);
            Assert.AreEqual(expected[2, 2], obj.Matrix[2, 2]);
            Assert.AreEqual(expected[2, 0], obj.Matrix[2, 0]);
        }
    }
}
