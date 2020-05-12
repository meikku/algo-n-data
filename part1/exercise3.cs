namespace part1
{
    using System;
    public class Tables
    {
        public Tables()
        {

        }
        public int Calculate(int[] t) // t.Length = 4 {1, 2, 3, 2 }
        {
            int i = 0;
            int indecesInUse = t.Length - 2;

            if (t.Length == 0)
            {
                return t[0];
            }

            while (indecesInUse >= 0)
            { 
                    while (i <= indecesInUse) 
                    {
                       
                        t[i] = (t[i] + t[i + 1]); 
                        i++;

                    }

                indecesInUse = indecesInUse - 1;
                i = 0;
               

            } return t[0];
        }
    }
}

