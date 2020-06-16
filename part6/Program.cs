using System;

namespace part6
{
    class Program
    {
        static void Main(string[] args)
        {
            // BellmanFord bf1 = new BellmanFord(5);
            // bf1.AddRoad(1, 2, 7);
            // bf1.AddRoad(2, 4, 2);
            // bf1.AddRoad(1, 3, 6);
            // bf1.AddRoad(3, 4, 5);
            // bf1.AddRoad(4, 5, 3);
            // Console.WriteLine(bf1.Calculate(1, 5));


            FloydWarshall fw = new FloydWarshall(5);
            fw.AddRoad(1, 2, 7);
            fw.AddRoad(2, 4, 2);
            fw.AddRoad(1, 3, 6);
            fw.AddRoad(3, 4, 5);
            fw.AddRoad(4, 5, 3);
            Console.WriteLine(fw.Calculate(1, 5)); 

            // Dijkstra d = new Dijkstra(6);
            // d.AddRoad(1, 2, 7);
            // d.AddRoad(2, 4, 2);
            // d.AddRoad(1, 3, 6);
            // d.AddRoad(3, 4, 5);
            // d.AddRoad(4, 5, 3);
            // Console.WriteLine(d.Calculate(1, 5)); // 12
        }
    }
}
