namespace part1
{
    using System.Collections.Generic;
    using System;

    public class LuckyNumbers
    {
        public int Calculate(int a, int b) // Now the code breaks again. Worked 5 minutes ago. Good night.
        {
            List<int> luckyNumbers = new List<int>();

            if (b < 3)
            {
                return 0;
            }
            else if (b < 7)
            {
                return 1;
            }

            luckyNumbers.Add(3);
            luckyNumbers.Add(7);

            int multiply = 10;
            int i = 1;
            int index = 0;
            int amountAdded = 2;
            int n = 1;



            while (luckyNumbers[luckyNumbers.Count - 1] <= b) // For lack of a better condition. This is not accurate.  
            {

                int nextThree = 3 * multiply;
                int nextSeven = 7 * multiply;
                while (i <= amountAdded)
                {

                    int nextLuckyThree = nextThree + luckyNumbers[index];
                    int nextLuckySeven = nextSeven + luckyNumbers[index];
                    // if (nextLuckythree <= b) -> can't get this to work
                    luckyNumbers.Add(nextLuckyThree);
                    // if (nextLuckySeven <= b) -> can't get this to work
                    luckyNumbers.Add(nextLuckySeven);

                    i++;
                    index++;
                    // foreach (int number in lowNumbers) -> since the if's don't work I tried this instead. Breaks the code.
                    // {
                    //    if (number >= a)
                    //    {
                    //        lowNumbers.Remove(number); 
                    //    }  
                    // }
                    amountAdded = amountAdded * 2;
                    index = amountAdded - 2;
                    multiply = multiply * 10;
                    i = 1;

                    n++;

                }

            }

            List<int> lowNumbers = new List<int>();  // was going to make a list to "a"


            lowNumbers.Add(3);
            lowNumbers.Add(7);

            int multiply2 = 10;
            int i2 = 1;
            int index2 = 0;
            int amountAdded2 = 2;
            int n2 = 1;



            while (lowNumbers[lowNumbers.Count - 1] < a) 
            {

                int nextThree2 = 3 * multiply2;
                int nextSeven2 = 7 * multiply2;
                while (i2 <= amountAdded2)
                {

                    int nextLuckyThree = nextThree2 + lowNumbers[index];
                    int nextLuckySeven = nextSeven2 + lowNumbers[index];
                    // if (nextLuckythree <= b) -> can't get this to work
                    lowNumbers.Add(nextLuckyThree);
                    // if (nextLuckySeven <= b) -> can't get this to work
                    lowNumbers.Add(nextLuckySeven);

                    i2++;
                    index2++;
                    // foreach (int number in lowNumbers) -> since the if's don't work I tried this instead. Breaks the code.
                    // {
                    //    if (number >= a)
                    //    {
                    //        lowNumbers.Remove(number); 
                    //    }  
                    // }

                }
                amountAdded2 = amountAdded2 * 2;
                index2 = amountAdded2 - 2;
                multiply2 = multiply2 * 10;
                i2 = 1;

                n2++;


            }

            return luckyNumbers.Count - lowNumbers.Count;

        }
    }
}


