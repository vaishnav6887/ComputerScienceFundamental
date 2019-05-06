using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.ProgrammingProblem.String;

namespace ProgrammingProblem.Test.String
{
    /// <summary>
    /// Summary description for HasUniqueCharInStringTest
    /// </summary>
    [TestClass]
    public class HasUniqueCharInStringTest
    {
        [TestCategory("String")]
        [TestMethod]
        public void HasUniqueCharInString_NonUniqueCharTest()
        {
            bool actual = HasUniqueCharInString.HasUnique("vaishnav");

            Assert.IsFalse(actual);
        }

        [TestCategory("String")]
        [TestMethod]
        public void HasUniqueCharInString_NonUniqueCharTest_EmptyStringInput()
        {
            bool actual = HasUniqueCharInString.HasUnique("");

            Assert.IsTrue(actual);
        }

        [TestCategory("String")]
        [TestMethod]
        public void HasUniqueCharInString_UniqueCharTest()
        {
            bool actual = HasUniqueCharInString.HasUnique("Thakur");
            Assert.IsTrue(actual);
        }

        [TestCategory("String")]
        [TestMethod]
        public void HasUniqueCharInString_UniqueSpecialCharTest()
        {
            bool actual = HasUniqueCharInString.HasUnique("!@#$%^&*()");
            Assert.IsTrue(actual);
        }

        [TestCategory("String")]
        [TestMethod]
        public void HasUniqueCharInString_NonUniqueSpecialCharTest()
        {
            bool actual = HasUniqueCharInString.HasUnique("!@#$%^&*(()");
            Assert.IsFalse(actual);
        }


        [TestCategory("String")]
        [TestMethod]
        public void HasUniqueCharInStringWithOutExtraSpace_NonUniqueCharTest()
        {
            bool actual = HasUniqueCharInString.HasUniqueWithOutExtraSpace("vaishnav");

            Assert.IsFalse(actual);
        }

        [TestCategory("String")]
        [TestMethod]
        public void HasUniqueCharInStringWithOutExtraSpace_UniqueCharTest()
        {
            bool actual = HasUniqueCharInString.HasUniqueWithOutExtraSpace("Thakur");
            Assert.IsTrue(actual);
        }

        [TestCategory("String")]
        [TestMethod]
        public void HasUniqueCharInStringWithOutExtraSpace_UniqueSpecialCharTest()
        {
            bool actual = HasUniqueCharInString.HasUniqueWithOutExtraSpace("!@#$%^&*()");
            Assert.IsTrue(actual);
        }

        [TestCategory("String")]
        [TestMethod]
        public void HasUniqueCharInStringWithOutExtraSpace_NonUniqueSpecialCharTest()
        {
            bool actual = HasUniqueCharInString.HasUniqueWithOutExtraSpace("!@#$%^&*(()");
            Assert.IsFalse(actual);
        }
    }
}
