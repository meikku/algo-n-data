namespace part4
{
    using System;
    using System.Collections.Generic;

    public class SmallestDistance
    {
        List<int> values = new List<int>(); // private...
        public int difference;

        public void Add(int x)
        {
            values.Add(x);
        }

        public int Calculate()
        {
            values.Sort();

            // if (values.Count > 1) // WHY doesn't this work?
            // {
                int difference = values[1] - values[0];

            // }

            int thisDifference = 0;
            for (int i = 1; i < values.Count; i++)
            {
                thisDifference = values[i] - values[i - 1];

                if (thisDifference < difference)
                {
                    difference = thisDifference;
                }
            }
            return difference;
        }
    }
}
