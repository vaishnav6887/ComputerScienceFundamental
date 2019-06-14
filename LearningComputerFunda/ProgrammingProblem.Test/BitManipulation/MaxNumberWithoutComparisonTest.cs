using System;
using ComputerFunda.ProgrammingProblem.BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.BitManipulation
{
    [TestCategory("BitManipulation")]
    [TestClass]
    public class MaxNumberWithoutComparisonTest
    {
        [TestMethod]
        public void IsPositiveTest()
        {
            MaxNumberWithoutComparison obj = new MaxNumberWithoutComparison();

            bool actual = obj.IsPositive(-5);
            bool positiveActual = obj.IsPositive(5);

            Assert.IsTrue(positiveActual);
            Assert.IsFalse(actual);
        }
    }
}
