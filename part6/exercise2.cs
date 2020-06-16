namespace part6
{
    using System.Collections.Generic;

    public class Dijkstra
    {
        private List<int> visited;
        private int [,] graph;

        private int n;

        public Dijkstra(int n)
        {
            this.visited = new List<int>();
            this.graph = new int[n + 1, n + 1];

            this.n = n;
        }

        public void AddRoad(int a, int b, int d)
        {
            this.graph[a, b] = d;
            this.graph[b, a] = d;

        }

        public int Calculate(int x, int y)
        {
            foreach (int i in graph)
            {
              
               
            }

            return 0;
        }
    }
}