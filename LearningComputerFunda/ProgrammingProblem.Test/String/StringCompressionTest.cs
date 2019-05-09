using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.ProgrammingProblem.String;
using System;

namespace ProgrammingProblem.Test.String
{
    [TestCategory("String")]
    [TestClass]
    public class StringCompressionTest
    {
        private StringCompression _obj;

        [TestInitialize]
        public void Initialize()
        {
            _obj = new StringCompression();
        }

        [TestMethod]
        public void StringComparission_Positive_Test()
        {
            string input = "aabcccccddaaa";

            string actual = this._obj.Compress(input);

            string expected = "a2b1c5d2a3";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void StringComparission_Negative_Test()
        {
            string input = "abcdefgh";

            string actual = this._obj.Compress(input);

            string expected = "a1b1c1d1e1f1g1h1";

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StringComparission_Null_Input_Test()
        {
            string actual = this._obj.Compress(null);

            Assert.Fail("Input string can not be null");
        }
    }
}
