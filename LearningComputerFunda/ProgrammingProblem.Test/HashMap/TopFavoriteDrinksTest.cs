using ComputerFunda.ProgrammingProblem.HashMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ProgrammingProblem.Test.HashMap
{
    [TestCategory("HashMap")]
    [TestClass]
    public class TopFavoriteDrinksTest
    {
        [TestMethod]
        public void TestFindFavDrink()
        {
            Dictionary<int, int[]> data = new Dictionary<int, int[]>();
            data.Add(0, new int[] { 0, 1, 3, 6 });
            data.Add(1, new int[] { 1, 4, 7 });
            data.Add(2, new int[] { 2, 4, 7, 5 });
            data.Add(3, new int[] { 3, 2, 5 });
            data.Add(4, new int[] { 5, 8 });

            TopFavoriteDrinks obj = new TopFavoriteDrinks();
            int actual = obj.CountOfFavoriteDrinks(data);
            int expected = 2;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestFindFavDrink_All_UniqueChoices()
        {
            Dictionary<int, int[]> data = new Dictionary<int, int[]>();
            data.Add(0, new int[] { 0, 1});
            data.Add(1, new int[] { 2, 3, 4 });
            data.Add(2, new int[] { 5, 6 });
            data.Add(3, new int[] { 10, 9, 8 });
            data.Add(4, new int[] { 7, 11 });

            TopFavoriteDrinks obj = new TopFavoriteDrinks();
            int actual = obj.CountOfFavoriteDrinks(data);
            int expected = 5;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestFindFavDrink_All_SameChoices()
        {
            Dictionary<int, int[]> data = new Dictionary<int, int[]>();
            data.Add(0, new int[] { 0, 1 });
            data.Add(1, new int[] { 1, 3, 4 });
            data.Add(2, new int[] { 5, 1 });
            data.Add(3, new int[] { 10, 1, 8 });
            data.Add(4, new int[] { 7, 1 });

            TopFavoriteDrinks obj = new TopFavoriteDrinks();
            int actual = obj.CountOfFavoriteDrinks(data);
            int expected = 1;

            Assert.AreEqual(actual, expected);
        }
    }
}
