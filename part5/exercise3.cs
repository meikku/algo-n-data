namespace part5
{
    using System.Collections.Generic;
    public class Components
    {
        private List<int>[] graph;
        private List<int> visited;
        private int components;





        public Components(int n)
        {
            this.graph = new List<int>[n + 1];

            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
            this.visited = new List<int>();
            this.components = 0;


        }
        public void AddConnection(int a, int b)
        {
            graph[a].Add(b);
            graph[b].Add(a);
        }
        public int Calculate()
        {
            for (int i = 1; i < graph.Length; i++)
            {

                if (this.visited.Contains(i))
                {
                    return 0;
                }
                else
                {

                this.visited.Add(i);
               

                foreach (int n in graph[i])
                {
                    Calculate();
                }
                this.components++;
                }
            }


            return this.components;
        }
    }
}

