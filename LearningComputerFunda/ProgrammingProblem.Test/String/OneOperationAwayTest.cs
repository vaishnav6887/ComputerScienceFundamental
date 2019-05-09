using System;
using ComputerFunda.ProgrammingProblem.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.String
{
    [TestCategory("String")]
    [TestClass]
    public class OneOperationAwayTest
    {
        private OneOperationAway _obj;

        [TestInitialize]
        public void Init()
        {
            this._obj = new OneOperationAway();
        }

        [TestMethod]
        public void IsOneAway_Positive()
        {
            string argA = "pale";
            string argB = "ple";

            bool actual = _obj.IsOneAway(argA, argB);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsOneAway_Positive_LastLetterNotMatching()
        {
            string argA = "pales";
            string argB = "pale";

            bool actual = _obj.IsOneAway(argA, argB);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsOneAway_Positive_FirstLetterNotMatching()
        {
            string argA = "pale";
            string argB = "bale";

            bool actual = _obj.IsOneAway(argA, argB);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsOneAway_Negative()
        {
            string argA = "pale";
            string argB = "bake";

            bool actual = _obj.IsOneAway(argA, argB);

            Assert.IsFalse(actual);
        }
    }
}
