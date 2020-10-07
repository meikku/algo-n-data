namespace exam_prep
{
    using System;
    public class Numbers
    {
        public int Steps(int x)
        {
            int n = 0;
            int sum = 0;

            while (true)
            {
                n++;
                sum = sum + n;
                if (sum >= x)
                {
                    return n;
                }
            }
        }
    }
}