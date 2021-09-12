using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Ex2Graph
    {
        int vertex;
        private List<int>[] adjacent;
        public Ex2Graph(int v)
        {
            vertex = v;
            adjacent = new List<int>[v];
            for (int i = 0; i < vertex; i++)
                adjacent[i] = new List<int>();
        }
        public void AddAdjacent(int v, int x)
        {
            adjacent[v].Add(x);
        }
        public void Dfs(int v,bool[] visited)
        {
            visited[v] = true;
            foreach(int i in adjacent[v])
            {
                if (!visited[i])
                {
                    int j = i;
                    Dfs(j, visited);
                }
                    
            }
        }
        public int CountTree()
        {
            int res = 0;
            bool[] visited = new bool[vertex]; 
            for(int i=0;i<vertex;i++)
            {
                if (visited[i] == false)
                {
                    Dfs(i, visited);
                    res++;
                }
            }
            return res;
        }

    }
}
