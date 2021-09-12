using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class AdjacencyList
    {
        public int vertex;
        public List<int> [] adjList;
        public AdjacencyList(int v)
        {
            vertex = v;
            adjList = new List<int>[v];
            for (int i = 0; i < v; i++)
                adjList[i] = new List<int>();
        }
        public void AddEdge(int v1,int v2)
        {       
            adjList[v1].Add(v2);
        }
        public void RemoveEdge(int v1,int v2)
        {
            foreach(var item in adjList[v1])
            {
                if (item == v2)
                    adjList[v1].Remove(item);
            }
        }
    }
}
