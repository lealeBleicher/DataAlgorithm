using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] arr = new[]{ 3, 4, 2, 3, 16, 3, 15, 16, 15, 15, 16, 2, 3 } ;
            ex1.ThreeBig(arr);
           

            int[] arr1 = new[] { 1, 2, 5, 4, 0, 2, 1 };
            int[] arr2 = new[] { 2, 4, 5, 0, 1, 1, 2 };
            if (Ex2.AreEquals(arr1, arr2))
                Console.WriteLine("equals");
            else
                Console.WriteLine("not equals");

            Ex2Graph graph = new Ex2Graph(8);
            graph.AddAdjacent(0, 1);
            graph.AddAdjacent(0, 2);
            graph.AddAdjacent(3, 4);
            graph.AddAdjacent(5,7);
            graph.AddAdjacent(6,7);
            Console.WriteLine(graph.CountTree());


            Console.ReadLine();


        }
    }
}
