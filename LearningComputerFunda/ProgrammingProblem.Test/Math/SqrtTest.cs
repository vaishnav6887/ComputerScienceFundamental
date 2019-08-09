using System;
using ComputerFunda.ProgrammingProblem.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Math
{
    [TestCategory("Math")]
    [TestClass]
    public class SqrtTest
    {
        [TestMethod]
        public void Sqrt_Positive_Test()
        {
            int input = 13*13;
            Sqrt sqrt = new Sqrt();
            int actual = sqrt.CalculateSqrt(input);

            int expected = 13;

            Assert.AreEqual(expected, actual);
        }
    }
}
