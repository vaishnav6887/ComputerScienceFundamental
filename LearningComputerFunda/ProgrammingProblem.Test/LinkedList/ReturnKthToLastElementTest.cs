using System;
using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.ProgrammingProblem.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.LinkedList
{
    [TestClass]
    [TestCategory("LinkedList")]
    public class ReturnKthToLastElementTest
    {
        private ReturnKthToLastElement _data;

        [TestInitialize]
        public void Init()
        {
            _data = new ReturnKthToLastElement(new DSNode<int>()
            {
                Data = 3,
                Next = new DSNode<int>()
                {
                    Data = 2,
                    Next = new DSNode<int>()
                    {
                        Data = 3,
                        Next = new DSNode<int>()
                        {
                            Data = 1,
                            Next = new DSNode<int>()
                            {
                                Data = 2,
                                Next = new DSNode<int>()
                                {
                                    Data = 5,
                                    Next = new DSNode<int>()
                                    {
                                        Data = 6,
                                        Next = new DSNode<int>()
                                        {
                                            Data = 6
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            });
        }

        [TestMethod]
        public void ReturnKthToLastElement_Positive()
        {
            int expected = 5;
            int input = 3;

            int actual = _data.Execute(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
