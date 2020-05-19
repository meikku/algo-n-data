namespace part2
{
    using System;

    public class Revolutions
    {
        public int Calculate(int[] t)
        {
            int revolutions = 0;
            int target = 1;

            while (target <= t.Length) 
            {
                for (int j = 0; j < t.Length; j++) 
                {
                    if (t[j] == target) 
                    {
                        target++; 
                                
                    }
                }

                revolutions++;
            }
            return revolutions;

        }
    }
}

