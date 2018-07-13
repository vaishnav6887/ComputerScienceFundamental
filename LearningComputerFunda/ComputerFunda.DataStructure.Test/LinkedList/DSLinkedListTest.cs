using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFunda.DataStructure.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.Common;

namespace ComputerFunda.DataStructure.Test.LinkedList
{
    [TestClass]
    public class DSLinkedListTest
    {
        [TestMethod]
        public void Add_Test_Positive_CountCheck()
        {
            DSLinkedList<int> actual = new DSLinkedList<int>();

            actual.Add(5);
            actual.Add(10);
            actual.Add(15);
            actual.Add(20);

            Assert.AreEqual(4, actual.Count);
        }

        [TestMethod]
        public void Add_Test_Positive_Data_Validation()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();

            lnkLst.Add(5);
            lnkLst.Add(10);
            lnkLst.Add(15);
            lnkLst.Add(20);

            int actual2ndIndex = lnkLst.ValueAtIndex(2);

            lnkLst.Add(25);

            int actualAt4thIndex = lnkLst.ValueAtIndex(4);

            Assert.AreEqual(15, actual2ndIndex);

            Assert.AreEqual(25, actualAt4thIndex);
        }

        [TestMethod]
        public void Add_Test_Delete_Positive_Data_Validation()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();

            IntDSNodeEqualityComparer intDSNodeEqualityComparer = new IntDSNodeEqualityComparer();

            lnkLst.Add(5);
            lnkLst.Add(10);
            lnkLst.Add(15);
            lnkLst.Add(20);
            lnkLst.Delete(10, intDSNodeEqualityComparer);

            int actual2ndIndex = lnkLst.ValueAtIndex(2);

            lnkLst.Add(25);

            int actualAt3rdIndex = lnkLst.ValueAtIndex(3);

            Assert.AreEqual(20, actual2ndIndex);

            Assert.AreEqual(25, actualAt3rdIndex);
        }

        [TestMethod]
        public void Add_Test_Delete_BY_INDEX_Positive_Data_Validation()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();

            lnkLst.Add(5);
            lnkLst.Add(10);
            lnkLst.Add(15);
            lnkLst.Add(20);
            lnkLst.Delete(1);

            int actual2ndIndex = lnkLst.ValueAtIndex(2);

            lnkLst.Add(25);

            int actualAt3rdIndex = lnkLst.ValueAtIndex(3);

            Assert.AreEqual(20, actual2ndIndex);

            Assert.AreEqual(25, actualAt3rdIndex);
        }

        [TestMethod]
        public void Add_Reverse_LinkedList()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();
            lnkLst.Add(5);
            lnkLst.Add(10);
            lnkLst.Add(15);
            lnkLst.Add(20);
            
            lnkLst.Add(25);
            lnkLst.Delete(4);
            int expected = lnkLst.ValueAtIndex(0);
            lnkLst.Reverse();
            int actual = lnkLst.ValueAtIndex(3);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Add_Detect_Loop_IN_LinkedList()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();
            for (int i = 1; i <= 10; i++)
            {
                lnkLst.Add(i * 5);
            }

            lnkLst._head.Next.Next.Next.Next.Next = lnkLst._head;

            bool expected = true;

            bool actual = lnkLst.DetectLoop();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Detect_Loop_IN_Flyod_Algo_LinkedList()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();
            for (int i = 1; i <= 4; i++)
            {
                lnkLst.Add(i * 5);
            }

            lnkLst._head.Next.Next.Next = lnkLst._head;

            bool expected = true;

            IntDSNodeEqualityComparer intDSNodeEqualityComparer = new IntDSNodeEqualityComparer();

            bool actual = lnkLst.FloydLoopDetect(intDSNodeEqualityComparer);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Find_Middle_By_FlyodAlgo()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();
            for (int i = 1; i <= 10; i++)
            {
                lnkLst.Add(i * 5);
            }

            int expected = 30;
            
            int actual = lnkLst.FindMiddle();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_Number_Of_Times_Element_Repeated()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();
            for (int i = 1; i <= 10; i++)
            {
                lnkLst.Add(i * 5);
            }

            lnkLst.Add(5);

            int expected = 2;
            IntDSNodeEqualityComparer comparer = new IntDSNodeEqualityComparer();
            int actual = lnkLst.CountOfRepetationOfElement(5, comparer);

            Assert.AreEqual(expected, actual);
        }
    }
}
