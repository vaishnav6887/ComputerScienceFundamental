using ComputerFunda.ProgrammingProblem.Graph;
using ComputerFunda.DataStructure.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Graph
{
    [TestCategory("Graph")]
    [TestClass]
    public class RouteBetweenNodesTest
    {
        [TestMethod]
        public void FindRoute_Test()
        {
            DSGraph obj = new DSGraph();
            obj.AddVertex("San Fransisco");
            obj.AddVertex("Las Vegas");
            obj.AddVertex("Seattle");
            obj.AddVertex("Atlanta");
            obj.AddVertex("Dallas");
            obj.AddVertex("Denver");
            obj.AddVertex("Delhi");
            obj.AddDirectedEdge("San Fransisco", "Seattle");
            obj.AddDirectedEdge("San Fransisco", "Dallas");
            obj.AddDirectedEdge("San Fransisco", "Denver");
            obj.AddDirectedEdge("Dallas", "Atlanta");
            obj.AddDirectedEdge("Dallas", "Denver");
            obj.AddDirectedEdge("Dallas", "Las Vegas");

            var actual = obj.FindRoute("San Fransisco", "Las Vegas");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void FindRoute_Test_No_Route()
        {
            DSGraph obj = new DSGraph();
            obj.AddVertex("San Fransisco");
            obj.AddVertex("Las Vegas");
            obj.AddVertex("Seattle");
            obj.AddVertex("Atlanta");
            obj.AddVertex("Dallas");
            obj.AddVertex("Denver");
            obj.AddVertex("Delhi");
            obj.AddDirectedEdge("San Fransisco", "Seattle");
            obj.AddDirectedEdge("San Fransisco", "Dallas");
            obj.AddDirectedEdge("San Fransisco", "Denver");
            obj.AddDirectedEdge("Dallas", "Atlanta");
            obj.AddDirectedEdge("Dallas", "Denver");
            obj.AddDirectedEdge("Dallas", "Las Vegas");

            var actual = obj.FindRoute("Seattle", "Las Vegas");

            Assert.IsFalse(actual);
        }
    }
}
