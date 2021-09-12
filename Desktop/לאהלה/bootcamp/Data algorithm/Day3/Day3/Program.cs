using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyList a = new AdjacencyList(4);
            a.AddEdge(0, 1);
            a.AddEdge(0, 2);
            a.AddEdge(1, 2);
            a.AddEdge(2,0);
            a.AddEdge(2,3);
            a.AddEdge(3, 3);
            DFS d = new DFS();
            d.Dfs(a);
            Console.WriteLine();
            BFS b = new BFS();
            b.Bfs(a, 2);
            Console.WriteLine();
            AdjacencyList ad = new AdjacencyList(6);
            ad.AddEdge(5,2);
            ad.AddEdge(5, 0);
            ad.AddEdge(4,0);
            ad.AddEdge(4,1);
            ad.AddEdge(2,3);
            ad.AddEdge(3,1);
            TopologicalSorting t = new TopologicalSorting();
            t.TSorting(ad);
            Console.ReadLine();


        }
    }
}
