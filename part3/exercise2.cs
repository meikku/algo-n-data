namespace part3
{
    using System;
   
    public class SmallestDifference
    {

        public int Calculate(int[] t)
        {
            Array.Sort(t);
            int difference = 1000;
           for (int i = 1; i < t.Length; i++)
           {
               int thisDifference = t[i] - t[i - 1];
               if ( thisDifference < difference)
               {
                   difference = thisDifference;
               }
           }
            return difference;
        }
    }

}
