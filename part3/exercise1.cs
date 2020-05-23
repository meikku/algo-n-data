namespace part3
{
    using System;
    public class HelloThere
    {

        public void Hello(int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Hello!");
                Hello(n - 1);
            }
        }
    }
}