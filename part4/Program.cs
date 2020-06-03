using System;

namespace part4
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bs = new BinarySearchTree();
            bs.Add(5); // Becomes your root
            // bs.Add(4); // Goes to the left
            // bs.Add(6); // Goes to the right
            Console.WriteLine(bs.Height()); // 1
            // bs.Add(3);
            // bs.Add(1);
            // bs.Add(7);
            // Console.WriteLine(bs.Height()); // 3
            // bs.Add(8);
            // bs.Add(9);
            // bs.Add(7);
            // Console.WriteLine(bs.Height()); // 3
            // bs.Add(2);
            // bs.Add(1);
            // bs.Add(3);
            // Console.WriteLine(bs.Height()); // 3


            // SmallestDistance s = new SmallestDistance();
            // s.Add(3);
            // Console.WriteLine(s.Calculate()); // 
            // s.Add(8);
            // Console.WriteLine(s.Calculate()); // 5
            // s.Add(20);
            // Console.WriteLine(s.Calculate()); // 5
            // s.Add(9);
            // Console.WriteLine(s.Calculate()); // 1
            // // BinarySearchTree bs = new BinarySearchTree();
            // bs.Add(5); // Becomes your root
            // bs.Add(4); // Goes to the left
            // bs.Add(6); // Goes to the right
            // Console.WriteLine(bs.Height()); // 1
            // bs.Add(3);
            // bs.Add(1);
            // bs.Add(7);
            // Console.WriteLine(bs.Height()); // 3

            // CircleGame g = new CircleGame();
            // Console.WriteLine(g.Last(7)); // 7
            // Console.WriteLine(g.Last(7)); // 7
            // Console.WriteLine(g.Last(32)); // 
            // Console.WriteLine(g.Last(9)); // 
            // Console.WriteLine(g.Last(4)); // 1
            // Console.WriteLine(g.Last(123)); // 119


        }
    }
}
// Node node = new Node(int value, Node next, Node previous);

// last(n)
//   if n = 1
//     return 1
//   if n is even
//     last(n) = 2 * last(n/2) -1
//   else
//     last(n) = 2 * last((n-1) / 2) + 1