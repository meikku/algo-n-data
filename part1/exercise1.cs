namespace part1
{
    using System;
    public class Numbers
    {
     
        public int Sum(int x)
        {
            int sum = 0;
            char[] charArray = x.ToString().ToCharArray();


            foreach (char item in charArray)
            {
                sum += item - 48;
            }

            return sum;
        }
    }
}