using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.ProgrammingProblem.String;

namespace ProgrammingProblem.Test.String
{
    [TestClass]
    [TestCategory("String")]
    public class CheckStringsArePermutationTest
    {
        [TestMethod]
        public void CheckPermutation_Positive()
        {
            string argA = "abcdd";
            string argB = "dbcad";

            Assert.IsTrue(CheckStringsArePermutation.CheckPermutation(argA, argB));
        }

        [TestMethod]
        public void CheckPermutation_Negative()
        {
            string argA = "abcd";
            string argB = "dbcad";

            Assert.IsFalse(CheckStringsArePermutation.CheckPermutation(argA, argB));
        }

        [TestMethod]
        public void CheckPermutation_Negative_Same_Len()
        {
            string argA = "abcdz";
            string argB = "dbcad";

            Assert.IsFalse(CheckStringsArePermutation.CheckPermutation(argA, argB));
        }
    }
}
