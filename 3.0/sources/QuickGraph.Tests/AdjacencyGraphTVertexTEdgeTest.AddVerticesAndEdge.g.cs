// <copyright file="AdjacencyGraphTVertexTEdgeTest.AddVerticesAndEdge.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.Pex.Framework.Generated;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Exceptions;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge02()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge03()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 1023);
                keyValuePairs[0] = s0;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge04()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
                KeyValuePair<int, int> s0
                   = new KeyValuePair<int, int>(default(int), int.MinValue);
                keyValuePairs[0] = s0;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge05()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
                adjacencyGraph = AdjacencyGraphFactory.Create
                    (PexSafeHelpers.ByteToBoolean((byte)32), keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge07()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(768, 3145963);
                keyValuePairs[0] = s0;
                KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(768, 3145963);
                keyValuePairs[1] = s1;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge08()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 1023);
                keyValuePairs[0] = s0;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge09()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
                adjacencyGraph = AdjacencyGraphFactory.Create
                    (PexSafeHelpers.ByteToBoolean((byte)32), keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge10()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(768, 3145963);
                keyValuePairs[0] = s0;
                KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(768, 3145963);
                keyValuePairs[1] = s1;
                KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(768, 3145963);
                keyValuePairs[2] = s2;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge11()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 1023);
                keyValuePairs[0] = s0;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge12()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
                adjacencyGraph = AdjacencyGraphFactory.Create
                    (PexSafeHelpers.ByteToBoolean((byte)32), keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge13()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(3932161, 53477376);
                keyValuePairs[0] = s0;
                KeyValuePair<int, int> s1
                   = new KeyValuePair<int, int>(100690946, default(int));
                keyValuePairs[1] = s1;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge14()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[6];
                adjacencyGraph = AdjacencyGraphFactory.Create
                    (PexSafeHelpers.ByteToBoolean((byte)128), keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge15()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[4];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(768, 768);
                keyValuePairs[0] = s0;
                KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(768, 768);
                keyValuePairs[1] = s1;
                KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(12289, 251904);
                keyValuePairs[2] = s2;
                KeyValuePair<int, int> s3 = new KeyValuePair<int, int>(12289, 98304);
                keyValuePairs[3] = s3;
                adjacencyGraph = AdjacencyGraphFactory.Create
                    (PexSafeHelpers.ByteToBoolean((byte)32), keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge16()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
                KeyValuePair<int, int> s0
                   = new KeyValuePair<int, int>(-2147483647, int.MinValue);
                keyValuePairs[1] = s0;
                KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(1, default(int));
                keyValuePairs[2] = s1;
                adjacencyGraph = AdjacencyGraphFactory.Create(true, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddVerticesAndEdge17()
        {
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [PexRaisedException(typeof(NullReferenceException))]
        public void AddVerticesAndEdge18()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            edge = EdgeFactory.Create(3, 4);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, edge);
        }
    }
}
