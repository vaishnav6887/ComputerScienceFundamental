using ComputerFunda.ProgrammingProblem.HashMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProblem.Test.HashMap
{
    [TestCategory("HashMap")]
    [TestClass]
    public class WordFrequencyTest
    {
        [TestMethod]
        public void FindFrequency_EmptyBook_Test()
        {
            WordFrequency obj = new WordFrequency("".Split());
            int actual = obj.FindWordFrequency("book");

            int expected = 0;

            Assert.IsNotNull(obj);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindFrequency_EmptyWord_Test()
        {
            WordFrequency obj = new WordFrequency("This is test".Split());
            int actual = obj.FindWordFrequency("");
        }

        [TestMethod]
        public void FindFrequency_Test()
        {
            WordFrequency obj = new WordFrequency("I am book, I am book on Programing. You can book my early edition in book stores. I am sure I will be soon your favorite book".Split());
            Stopwatch watch = new Stopwatch();
            int expected = 5;
            watch.Start();
            for (int i = 0; i < 10000; i++)
            {
                int actual = obj.FindWordFrequency("book");

                Assert.IsNotNull(obj);
                Assert.AreEqual(expected, actual);
            }
            
            watch.Stop();
        }
    }
}
