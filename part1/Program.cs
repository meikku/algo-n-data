using System;


namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            LuckyNumbers luck = new LuckyNumbers();
           // Console.WriteLine(luck.Calculate(1, 10)); // 2
            // Console.WriteLine(luck.Calculate(123, 321)); // 0
            Console.WriteLine(luck.Calculate(1, 1000000)); // 126
             
        }
    }
}

