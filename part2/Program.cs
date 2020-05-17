using System;
using System.Text;


namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Whatthe wt = new Whatthe();
            string input10 = wt.CreateInput(10);
            string input100 = wt.CreateInput(100);
            string input1000 = wt.CreateInput(1000);
            string input10000 = wt.CreateInput(10000);


            wt.Time(input10);
            wt.Time(input100);
            wt.Time(input1000);
            wt.Time(input10000);


        }
    }
}
