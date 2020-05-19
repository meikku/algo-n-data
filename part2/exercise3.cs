namespace part2
{
    using System;

    public class Changes
    {
        public int Calculate(int[] t)
        {
            int changes = 0;
           
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i - 1] == t[i])
                {
                    if (t[i] + 1 == t[i + 1])
                    {
                        t[i] = t[1] + 2;
                    }
                    else t[i]++;
                    
                    changes++;
                }
            }
            return changes;
        }
    }
}

