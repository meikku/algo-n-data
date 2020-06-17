namespace part6
{
    using System.Collections.Generic;

    public class Edge
    {
        public int source, target, weight;
        public Edge(int source, int target, int weight)
        {
            this.source = source;
            this.target = target;
            this.weight = weight;
        }
    }
    public class BellmanFord
    {
        private int n;
        public List<Edge> edges;

        public BellmanFord(int n)
        {
            this.edges = new List<Edge>();
            this.n = n;
        }

        public void AddRoad(int a, int b, int d)
        {
            this.edges.Add(new Edge(a, b, d));
            this.edges.Add(new Edge(b, a, d));
        }
        public int Calculate(int x, int y)
        {
            int inf = 99999999;
            int[] distance = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                distance[i] = inf;
            }
            distance[x] = 0;

            while (true)
            {
                bool change = false;
                foreach (Edge edge in edges)
                {
                    int current = distance[edge.target];
                    int newCurrent = distance[edge.source] + edge.weight;
                    if (newCurrent < current)
                    {
                        distance[edge.target] = newCurrent;
                        change = true;
                    }


                    // should be after foreach
                    if (change == false)
                    {
                        break;
                    }
                }
                if (distance[y] == inf)
                {
                    return -1;
                }
                else
                {
                    return distance[y];
                }
            }
        }
    }
}