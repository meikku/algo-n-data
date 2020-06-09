namespace part5
{
    using System;
    using System.Collections.Generic;
    public class Communication
    {
        private List<int>[] graph;
        private List<int> visited;
       

        public Communication(int n)
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
            graph[a].Add(b);
            graph[b].Add(a);
        }
        public bool Examine(int x, int y)
        {
            if (this.visited.Contains(x))
            {
                return false;
            }
            this.visited.Add(x);
            foreach (int n in graph[x])
            {   
                Examine(n, y);
            }
            

            return this.visited.Contains(y);
        }
    }
}
