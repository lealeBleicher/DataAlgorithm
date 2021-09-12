using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class AdjacencyMatrix
    {
        private int vertex;
        private int[,] adjMat;
        public AdjacencyMatrix(int v)
        {
            vertex = v;
            adjMat = new int[v,v];
        }
        public void AddEdge(int v1,int v2,int w)
        {
            adjMat[v1, v2] = w;
        }
        public void removeEdge(int v1,int v2)
        {
            adjMat[v1, v2] = 0;
        }
    }
}
