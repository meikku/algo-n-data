namespace part6
{
    using System;
    using System.Collections.Generic;

    public class FloydWarshall
    {
        private int n;
        private int[,] graph;
        private int inf = 99999999;

        public FloydWarshall(int n)
        {
            this.graph = new int[n + 1, n + 1];
            this.n = n;
            // for (int i = 1; i <=n; i++)
            //      for (int j = 1; j <= this.n; i++)
            //
            //         { this.distance[i, j ] = inf;}
        }

        public void AddRoad(int a, int b, int d)
        {
            this.graph[a, b] = d;
            this.graph[b, a] = d;
        }

        public int Calculate(int x, int y)
        {
            int[,] distance = new int[n + 1, n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    // Console.WriteLine("i is " + i + ", j is " + j + ", this.graph[i, j] is " + this.graph[i, j]);
                    distance[i, j] = this.graph[i, j];

                    if (distance[i, j] == 0)
                    {
                        distance[i, j] = inf;
                    }
                    if (i == j)
                    {
                        distance[i, j] = 0;
                    }
                    // Console.WriteLine("distance [i, j] is " + distance[i, j]);
                }
            }
            for (int k = 1; k < n + 1; k++) // k <= n
            {
                for (int i = 1; i < n + 1; i++)
                {
                    for (int j = 1; j < n + 1; j++)
                    {
                       //  Console.WriteLine("i, k: " + distance[i, k] + ", k, j: " + distance[k, j]);
                       
                        int newDistance = distance[i, k] + distance[k, j];
                        if (distance[i, j] > newDistance)
                        {
                            distance[i, j] = newDistance;
                        }
                       // Console.WriteLine("distance [i, j] is " + distance[i, j]);
                    }
                }
            }
            if (distance[x, y] == inf)
            {
                return -1;
            }
            return distance[x, y];
        }
    }
}