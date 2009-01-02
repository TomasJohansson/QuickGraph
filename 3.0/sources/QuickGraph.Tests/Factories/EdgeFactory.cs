// <copyright file="EdgeFactory.cs" company="MSIT">Copyright © MSIT 2007</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Factories;
using QuickGraph;

namespace QuickGraph
{
    [PexFactoryClass]
    public partial class EdgeFactory
    {
        [PexFactoryMethod(typeof(Edge<int>))]
        public static Edge<int> Create(int source, int target)
        {
            Edge<int> edge = new Edge<int>(source, target);
            return edge;
        }
    }
}
