using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class DFS
    {
        
        public void DfsUtil(AdjacencyList graph,int x, bool[] visited)
        {
            visited[x] = true;
            Console.Write(x + " ");
            foreach (var i in graph.adjList[x])
            {
                int n = i;
                if (!visited[n])
                    DfsUtil(graph,n, visited);

            }

        }
        public void Dfs(AdjacencyList graph)
        {
            bool[] visited = new bool[graph.vertex];
            
            for(int i=0;i<graph.vertex;i++)
            {
                if (!visited[i])
                    DfsUtil(graph,i, visited);
            }
        }
    }
}
