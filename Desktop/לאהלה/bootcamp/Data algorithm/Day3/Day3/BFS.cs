using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class BFS
    {
        public void Bfs(AdjacencyList adj,int v)
        {
            bool[] visited = new bool[adj.vertex];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(v);
            
            visited[v] = true;
            while(queue.Any())
            {
                int x = queue.Peek();
                Console.Write(x + " ");
                queue.Dequeue();
                foreach(var item in adj.adjList[x])
                {
                    if(!visited[item])
                    {
                        queue.Enqueue(item);
                        visited[item] = true;
                    }
                }

            }
        }
    }
}
