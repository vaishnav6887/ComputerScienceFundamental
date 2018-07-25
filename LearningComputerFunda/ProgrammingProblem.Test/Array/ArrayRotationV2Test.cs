using ComputerFunda.Algorithm.Search;
using Prime = ComputerFunda.ProgrammingProblem.Math.MathProblems;
using ComputerFunda.ProgrammingProblem.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblem.Test.Array
{
    [TestClass]
    public class ArrayRotationV2Test
    {
        [TestMethod]
        public void RotateArrayTest()
        {
            var primeNumbers = Prime.PrimeNumber(5000);

            int[] input = primeNumbers.ToArray();

            int[] actual = input.RotateLeft(10);

            int[] expected = primeNumbers.Skip(10).Union(primeNumbers.Take(10)).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RotateArrayTest_Load()
        {
            var primeNumbers = Prime.PrimeNumber(200000);

            int[] input = primeNumbers.ToArray();

            int[] actual = input.RotateLeft(primeNumbers.Count - 10);

            int[] expected = primeNumbers.Skip(primeNumbers.Count - 10).Union(primeNumbers.Take(primeNumbers.Count - 10)).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
