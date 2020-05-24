namespace part3
{
    using System;
    public class Inversions
    {

        public int[] Create(int n, int k)
        {

            int[] invers = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                invers[i] = i + 1;
            }
            int kMax = Sum(invers.Length - 1);
            if (k > kMax)
            {
                Console.WriteLine("Unable to do this many inversions. Doing " + kMax + " inversions instead. ");
                k = kMax;
            }

            int length = invers.Length;
            while (k > 0)
            {
                for (int i = 1; i < length; i++)
                {
                    int swap = invers[i - 1];
                    invers[i - 1] = invers[i];
                    invers[i] = swap;
                    k--;
                    if (k == 0)
                    {
                        return invers;
                    }
                }
                length--;
            }
            return invers;

            // public int[] Swap(int[] n, int k) // tried to do this with a recursive call, in vain
            // {
            //     for (int i = 1; i < n.Length; i++)
            //     {
            //         int swap = n[i - 1];
            //         n[i - 1] = n[i];
            //         n[i] = swap;
            //         k--;
            //         if (k == 0)
            //         {
            //             return n;
            //         }
            //     }
            //     return n;
        }
        static int Sum(int n)
        {
            if (n == 0) return 0;
            else return Sum(n - 1) + n;
        }

    }
}