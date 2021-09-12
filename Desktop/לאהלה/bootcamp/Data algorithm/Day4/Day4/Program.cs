using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph israelMap = new Graph();
            israelMap.AddCity("Neariya");
            israelMap.AddCity("Kiryat Shemona");
            israelMap.AddCity("Tiberias");
            israelMap.AddCity("Haifa");
            israelMap.AddCity("Nazareth");
            israelMap.AddCity("Netanya");
            israelMap.AddCity("Tel Aviv");
            israelMap.AddCity("Rishon");
            israelMap.AddCity("Jerusalem");
            israelMap.AddCity("Bet Shemesh");
            israelMap.AddCity("Ashkelon"); 
            israelMap.AddCity("Beher Sheva"); 
            israelMap.AddCity("Dimona");
            israelMap.AddCity("Mitzpe Ramon");
            israelMap.AddCity("Eilat");

            israelMap.AddAdj("Neariya", "Kiryat Shemona", 55);
            israelMap.AddAdj("Neariya", "Haifa", 25);
            israelMap.AddAdj("Neariya", "Jerusalem", 135);
            israelMap.AddAdj("Tiberias", "Kiryat Shemona", 45);
            israelMap.AddAdj("Tiberias", "Haifa", 50);
            israelMap.AddAdj("Tiberias", "Nazareth", 26);
            israelMap.AddAdj("Haifa", "Nazareth", 35);
            israelMap.AddAdj("Haifa", "Netanya", 52);
            israelMap.AddAdj("Netanya", "Nazareth", 57);
            israelMap.AddAdj("Netanya", "Tel Aviv", 31);
            israelMap.AddAdj("Tel Aviv", "Rishon", 15);
            israelMap.AddAdj("Tel Aviv", "Beher Sheva", 90);
            israelMap.AddAdj("Rishon", "Jerusalem", 34);
            israelMap.AddAdj("Rishon", "Ashkelon", 40);
            israelMap.AddAdj("Eilat", "Mitzpe Ramon", 120);
            israelMap.AddAdj("Eilat", "Tel Aviv", 280);
            israelMap.AddAdj("Mitzpe Ramon", "Beher Sheva", 68);
            israelMap.AddAdj("Dimona", "Beher Sheva", 30);
            israelMap.AddAdj("Dimona", "Jerusalem", 75);
            israelMap.AddAdj("Beher Sheva", "Jerusalem", 65);
            israelMap.AddAdj("Beher Sheva", "Bet Shemesh", 55);
            israelMap.AddAdj("Beher Sheva", "Ashkelon", 48);
            israelMap.AddAdj("Bet Shemesh", "Rishon", 30);








        }
    }
}
