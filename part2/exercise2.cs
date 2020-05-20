namespace part2
{
    using System;
  
    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int longestRep = 0;
            int comparedRep = 0;
            int j = 0;
            for (int i = 0; i < t.Length; i++)
            {
                
                if (t[i] == t[j])
                {
                    longestRep++;
                    j++;
                } 
                // else
                // {
                // longestRep = 1;
                // }
                
                if (longestRep > comparedRep)
                {
                    comparedRep = longestRep;
                } 
                j = i;
                
            }
           return longestRep;
        }
        
    }
}

