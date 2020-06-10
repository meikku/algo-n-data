namespace part5
{
    using System;
    using System.Collections.Generic;
    public class Connectivity
    {
        private List<int>[] graph;
        private List<int> visited;

        public Connectivity(int n)
        {
            this.graph = new List<int>[n + 1];

            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
            this.visited = new List<int>();
        }
        public void AddConnection(int a, int b)
        {
            graph[a].Add(b); // this.graph
            graph[b].Add(a);
        }
        public int Calculate(int x)
        {
            if (this.visited.Contains(x))
            {
                return 0;
            }
            this.visited.Add(x);

            // Console.WriteLine("x is " + x);

            // foreach (int number in this.visited)
            // {
            //     Console.WriteLine(number);
            // }



            foreach (int n in graph[x])
            {
                Calculate(n);
            }
            return this.visited.Count - 1;  
        }
    }
}
// or add: 
// private int VisitNodes(int x)
// so you always have the "visited" empty when you call Calculate()