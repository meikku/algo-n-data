using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch b = new BinarySearch();
            Console.WriteLine(b.Find(new int[] { 4, 1, 8, 5 }, 2)); // false
            Console.WriteLine(b.Find(new int[] { 0, 0 }, 0)); // true
            Console.WriteLine(b.Find(new int[] { 4, 1, 8, 5, 8, 7, 4, 2, 3 }, 2)); // true
            Console.WriteLine(b.Find(new int[] { 0 }, 0)); // true
            Console.WriteLine(b.Find(Randomizer(100000), 3)); // depends on Random
                                                              //   Sorting s = new Sorting();
                                                              //   int[] sortMeTen = Randomizer(10);
                                                              //   int[] sortMe = Randomizer(100);
                                                              //   int[] sortMeThousand = Randomizer(1000);
                                                              //   int[] sortMeLarger = Randomizer(10000);
                                                              //   int[] sortMeLargerer = Randomizer(100000);
                                                              //   int[] sortMeLargest = Randomizer(1000000);
                                                              //   int[] sortMeMassive = Randomizer(10000000);

            //   s.MergeSort(sortMeTen);
            //   s.MergeSort(sortMe);
            //   s.MergeSort(sortMeThousand);
            //   s.MergeSort(sortMeLarger);
            //   s.MergeSort(sortMeLargerer);
            //   s.MergeSort(sortMeLargest);
            //   s.MergeSort(sortMeMassive); // 

            //   Console.WriteLine();

            //   s.QuickSort(sortMeTen);
            //   s.QuickSort(sortMe);
            //   s.QuickSort(sortMeThousand);
            //   s.QuickSort(sortMeLarger);
            //   s.QuickSort(sortMeLargerer);
            //   s.QuickSort(sortMeLargest);
            //   s.QuickSort(sortMeMassive); 
        }

        public static int[] Randomizer(int n)
        {
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                // integers between 1 and 1000 are enough for us
                arr[i] = random.Next(1, 1001);
            }
            return arr;
        }
    }
}


