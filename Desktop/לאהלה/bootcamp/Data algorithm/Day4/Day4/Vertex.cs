using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class  Vertex <T>
    {
        private T value;
        private int dist;
        private List<Vertex<T>> adjList;
        public Vertex(T value,int dist)
        {
            this.value = value;
            this.dist = dist;
            this.adjList = new List<Vertex<T>>();
            
        }
        public void AddNeighbore(T value,int dist)
        {
            this.adjList.Add(new Vertex<T>(value,dist));
        }
    }
}
