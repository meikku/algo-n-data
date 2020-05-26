namespace part3
{
    using System;
    public class Sorting
    {
        public void MergeSort(int[] t)
        {
            int length = t.Length;

            Console.WriteLine("printing t");
            foreach (int number in t)
            {
                Console.WriteLine(number);
            }
            if (length < 2 )
            {
                return;
            }


            int half = length / 2;
            int[] help = new int[half];
            int[] help2 = new int[length - half];

            for (int j = 0; j < half; j++)
            {
                help[j] = t[j];
            }
            int k = half;
            for (int l = 0; (k + l) < length; l++)
            {
                help2[l] = t[k + l];
            }
            Console.WriteLine("printing help: ");
            foreach (int number in help)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("printing help2");
            foreach (int number in help2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("MergeSort(help)");
            MergeSort(help);
            Console.WriteLine("MergeSort(help2)");
            MergeSort(help2);

            Merge(help, help2);

        }

        static int[] Merge(int[] n, int[] m)
        {
            Console.WriteLine("Entering merge");
            int[] merge = new int[n.Length + m.Length];

            int j = 0;
            int k = 0;
            for (int i = 0; i < merge.Length; i++)
            {
                if (k > m.Length || j < n.Length && n[j] < m[k])
                {
                    merge[i] = n[j];
                    j++;
                }
                else
                {
                    merge[i] = m[k];
                    k++;
                }
            }
            Console.WriteLine("------*****-------");
            foreach (int number in merge)
            {
                Console.WriteLine(number);
            }
            return merge;
        }
        public void QuickSort(int[] t)
        {
            if (t.Length <= 1)
            {
                return;
            }
            int k = 0;
            int pivot = t[k];
            {
                for (int i = 1; i < t.Length; i++)
                {
                    if (t[i] < t[k])
                    {
                        k++;
                        int swap = t[i];
                        t[i] = t[k];
                        t[k] = swap;
                    }
                    if (t[i] > t[k])
                    {
                        int swap = t[i];
                        t[i] = t[k];
                        t[k] = swap;
                    }

                }
            }
            

        }
    }
}
