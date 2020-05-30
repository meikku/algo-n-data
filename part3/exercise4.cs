namespace part3
{
    using System;
    public class BinarySearch
    {

        public bool Find(int[] t, int x)
        {
            Array.Sort(t); // this was missing
            if (t.Length == 1)
            {
                if (t[0] == x)
                {
                    return true;
                }
                return false;
            }

            Array.Sort(t);
           

           
            int half = t.Length / 2;

            if (t[half] == x)
            {
                return true;
            }

            if (x < t[half])
            {
                int[] array = new int[half - 1];
                for (int i = 0; i < half - 1; i++)
                {
                    array[i] = t[i];
                }
               
                Find(array, x);
            }

            if (x > t[half])
            {
                int[] array = new int[t.Length - half];
                int j = half;
                for (int i = 0; i + j < t.Length; i++)
                {
                    array[i] = t[j];
                    j++;
                }
                
                Find(array, x);
            }
            return false;
        }
    }
}