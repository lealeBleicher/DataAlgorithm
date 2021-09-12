using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class TopologicalSorting
    {
       public void TopologicalSortingUtil(AdjacencyList adj,int i,bool [] visited,Stack<int> s)
        {
            visited[i] = true;
            foreach (var item in adj.adjList[i])
                if (!visited[item])
                    TopologicalSortingUtil(adj, item, visited, s);
            s.Push(i);
        }
        public void TSorting(AdjacencyList adj)
        {
            Stack<int> s = new Stack<int>();
            bool[] visited = new bool[adj.vertex];
            
            for(int i=0;i<adj.vertex;i++)
            
                if (!visited[i])
                    TopologicalSortingUtil(adj,i,visited,s);
            foreach (var item in s)
                Console.Write(item + " ");
           
        }

    }
}
