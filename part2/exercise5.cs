namespace part2
{
    using System;

    public class Split
    {
        public int Calculate(int[] t)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < t.Length; i++)
            {
                sum = sum + t[i];
            }
          
            if (sum % 2 != 0)
            {
                return 0;
            }
            int newSum = sum;
            int half = sum / 2;
           
            for (int i = 0; i < t.Length - 1; i++)
            {
                newSum = newSum - t[i];

                if (newSum == half)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
