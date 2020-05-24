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

            int j = 0;
            while (j < k)
            {
                int swap = invers[j];
                invers[j] = invers[j + 1];
                invers[j + 1] = swap;
                j = j + 2;
                k++;
            }


            return invers;
        }
    }
}