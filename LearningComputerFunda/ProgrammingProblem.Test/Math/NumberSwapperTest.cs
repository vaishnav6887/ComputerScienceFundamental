using System;
using ComputerFunda.ProgrammingProblem.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Math
{
    [TestClass]
    [TestCategory("Math")]
    public class NumberSwapperTest
    {
        [TestMethod]
        public void Swap_Test()
        {
            NumberSwapper s = new NumberSwapper(5, -2);

            s.SwapInPlace();

            Assert.AreEqual(s.Num2, 5);
            Assert.AreEqual(s.Num1, -2);
        }
    }
}
