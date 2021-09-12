using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Graph
    {
        Dictionary<string, Vertex<string>> cities;
        public Graph()
        {
            cities = new Dictionary<string, Vertex<string>>();
        }
        public void AddCity(string name)
        {
            Vertex<string> v = new Vertex<string>(name,0);
            cities.Add(name,v);

        }
        public void AddAdj(string city,string adj,int dist)
        {
            cities[city].AddNeighbore(adj, dist);
            cities[adj].AddNeighbore(city, dist);
        }
    }
}
