

using ComputerFunda.DataStructure.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ComputerFunda.DataStructure.Test.Graph
{
    [TestCategory("Graph")]
    [TestClass]
    public class DSGraphTest
    {
        [TestMethod]
        public void Test_Graph_DFS_Positive_1()
        {
            DSGraph dSGraph = new DSGraph();

            dSGraph.AddVertex("San Fransisco");
            dSGraph.AddVertex("Las Vegas");
            dSGraph.AddVertex("Seattle");
            dSGraph.AddVertex("Atlanta");
            dSGraph.AddVertex("Dallas");
            dSGraph.AddVertex("Denver");

            dSGraph.AddVertex("Delhi");

            dSGraph.AddEdge("San Fransisco", "Seattle");
            dSGraph.AddEdge("San Fransisco", "Dallas");
            dSGraph.AddEdge("San Fransisco", "Denver");

            dSGraph.AddEdge("Dallas", "Atlanta");
            dSGraph.AddEdge("Dallas", "Denver");
            dSGraph.AddEdge("Dallas", "Las Vegas");

            var actual = dSGraph.DFS("San Fransisco");

            var expected = new List<string>()
            {
                "San Fransisco",
                "Seattle",
                "Dallas",
                "Atlanta",
                "Denver",
                "Las Vegas"
            };

            for(int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void Test_Graph_DFS_Positive_2()
        {
            DSGraph dSGraph = new DSGraph();

            dSGraph.AddVertex("San Fransisco");
            dSGraph.AddVertex("Las Vegas");
            dSGraph.AddVertex("Seattle");
            dSGraph.AddVertex("Atlanta");
            dSGraph.AddVertex("Dallas");
            dSGraph.AddVertex("Denver");

            dSGraph.AddEdge("San Fransisco", "Seattle");
            dSGraph.AddEdge("San Fransisco", "Dallas");
            dSGraph.AddEdge("San Fransisco", "Denver");

            dSGraph.AddEdge("Dallas", "Atlanta");
            dSGraph.AddEdge("Dallas", "Denver");
            dSGraph.AddEdge("Dallas", "Las Vegas");

            var actual = dSGraph.DFS("Las Vegas");

            var expected = new List<string>()
            {
                "Las Vegas",
                "Dallas",
                "San Fransisco",
                "Seattle",
                "Denver",
                "Atlanta"
            };

            Assert.AreEqual(actual.Count, expected.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void Test_Graph_DFS_SeperatedEdge()
        {
            DSGraph dSGraph = new DSGraph();

            dSGraph.AddVertex("San Fransisco");
            dSGraph.AddVertex("Las Vegas");
            dSGraph.AddVertex("Seattle");
            dSGraph.AddVertex("Atlanta");
            dSGraph.AddVertex("Dallas");
            dSGraph.AddVertex("Denver");

            dSGraph.AddVertex("Delhi");

            dSGraph.AddEdge("San Fransisco", "Seattle");
            dSGraph.AddEdge("San Fransisco", "Dallas");
            dSGraph.AddEdge("San Fransisco", "Denver");

            dSGraph.AddEdge("Dallas", "Atlanta");
            dSGraph.AddEdge("Dallas", "Denver");
            dSGraph.AddEdge("Dallas", "Las Vegas");

            var actual = dSGraph.DFS("Delhi");

            var expected = new List<string>()
            {
                "Delhi"
            };

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void Test_Graph_BFS_Positive()
        {
            DSGraph dSGraph = new DSGraph();

            dSGraph.AddVertex("San Fransisco");
            dSGraph.AddVertex("Las Vegas");
            dSGraph.AddVertex("Seattle");
            dSGraph.AddVertex("Atlanta");
            dSGraph.AddVertex("Dallas");
            dSGraph.AddVertex("Denver");

            dSGraph.AddVertex("Delhi");

            dSGraph.AddEdge("San Fransisco", "Seattle");
            dSGraph.AddEdge("San Fransisco", "Dallas");
            dSGraph.AddEdge("San Fransisco", "Denver");

            dSGraph.AddEdge("Dallas", "Atlanta");
            dSGraph.AddEdge("Dallas", "Denver");
            dSGraph.AddEdge("Dallas", "Las Vegas");

            var actual = dSGraph.BFS("San Fransisco");

            var expected = new List<string>()
            {
                "San Fransisco",
                "Seattle",
                "Dallas",
                "Denver",
                "Atlanta",
                "Las Vegas"
            };

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }
    }
}
