namespace part2
{
    using System;
    using System.Text;
    public class Whatthe
    {
        public int Time(string n)
        {

            int counter = 0;
            int zeros = 0;
            int[] chars = new int[n.Length];
            DateTime start = DateTime.Now;
            for (int i = 0; i < n.Length; i++)
            {

                if (chars[i] == 0)
                {
                    zeros += 1;
                }
                else 
                {
                    counter += zeros;
                }

            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));
            return counter;
        }

        public string CreateInput(int n)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();


            for (int i = 0; i < n; i++)
            {
                sb.Append(random.Next(0, 2).ToString());
            }

            return sb.ToString();
        }
    }
}

