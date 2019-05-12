using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.ProgrammingProblem.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProblem.Test.LinkedList
{
    [TestCategory("LinkedList")]
    [TestClass]
    public class PalindromeTest
    {
        private Palindrome _data;

        private Palindrome _dataEvens;

        public PalindromeTest()
        {
            _data = new Palindrome(new DSNode<char>()
            {
                Data = 'd',
                Next = new DSNode<char>()
                {
                    Data = 'e',
                    Next = new DSNode<char>()
                    {
                        Data = 'e',
                        Next = new DSNode<char>()
                        {
                            Data = 'd',
                            Next = new DSNode<char>()
                            {
                                Data = 'e',
                                Next = new DSNode<char>()
                                {
                                    Data = 'e',
                                    Next = new DSNode<char>()
                                    {
                                        Data = 'd'
                                    }
                                }
                            }
                        }
                    }
                }
            });

            _dataEvens = new Palindrome(new DSNode<char>()
            {
                Data = 'd',
                Next = new DSNode<char>()
                {
                    Data = 'e',
                    Next = new DSNode<char>()
                    {
                        Data = 'e',
                        Next = new DSNode<char>()
                        {
                            Data = 'd'
                        }
                    }
                }
            });
        }

        [TestMethod]
        public void IsPalidrome_Positive_Test()
        {
            Assert.IsTrue(_data.IsPalindrome());
        }

        [TestMethod]
        public void IsPalidrome_Even_Positive_Test()
        {
            Assert.IsTrue(_dataEvens.IsPalindrome());
        }
    }
}
