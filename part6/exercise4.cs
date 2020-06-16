namespace part6
{
    using System;
    using System.Collections.Generic;

    public class Edge2
    {
        public int source, target, weight;
        public Edge2(int source, int target, int weight)
        {
            this.source = source;
            this.target = target;
            this.weight = weight;
        }
    }

    public class ShortestPath
    {
        private int n;
        private List<Edge2> cities;


        public ShortestPath(int n)
        {
            this.n = n;
            this.cities = new List<Edge2>();
        }

        public void AddRoad(int a, int b, int d)
        {
            this.cities.Add(new Edge2(a, b, d));
            this.cities.Add(new Edge2(b, a, d));
        }

        public List<int> Create(int x, int y)
        {
            int inf = 99999999;
            int[] distance = new int[n + 1];
            List<int> help = new List<int>();
            for (int i = 1; i < n + 1; i++)
            {
                distance[i] = inf;
            }
            distance[x] = 0;

            while (true)
            {
                bool change = false;
                foreach (Edge2 edge in cities)
                {
                    int current = distance[edge.target];
                    int newCurrent = distance[edge.source] + edge.weight;
                    if (newCurrent < current)
                    {
                        distance[edge.target] = newCurrent;
                        Console.WriteLine("Adding edge.source " + edge.source);
                        help.Add(edge.source);
                        change = true;
                    }

                    if (change == false)
                    {
                        break;
                    }
                }
                if (distance[y] == 0)
                {
                    return null;
                }
                return help;
            }

        }
    }
}