using System;
using ComputerFunda.ProgrammingProblem.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.DynamicProgramming
{
    [TestCategory("DynamicProgramming")]
    [TestClass]
    public class CoinChangeTest
    {
        [TestMethod]
        public void GetMeChange_PositiveTest()
        {
            CoinChange coinChange = new CoinChange();

            int actual = coinChange.GetMeChange(611, 5);
            int expected = 123;

            Assert.AreEqual(actual, expected);
        }
    }
}
