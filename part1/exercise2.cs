namespace part1
{
    using System;
    public class Substrings
    {
        public Substrings()
        {
        }
        public int Calculate(string a, string b)
        {
            char[] charArrayA = a.ToCharArray(); // make an array with characters from a
            char[] charArrayB = b.ToCharArray(); // make an array with characters from b

            int possibilities = a.Length - (b.Length - 1); // check how many times b could fit in a
            int count = 0;
            bool match = false;

            for (int i = 0; i < possibilities; i++) // check all the possible "fits"
            {
                if (charArrayA[i] == charArrayB[0]) // check if the index in array a matches the first index in array b
                {
                    int newIndex = i; // create a new index to match the index where the matching first character was found in array a
                    for (int index = 0; index < b.Length; index++) // check the characters for the length of word b
                    {
                        if ((charArrayA[newIndex]) == (charArrayB[index])) // increase the indeces in both arrays, checking if characters match
                        {
                            match = true;
                        }
                        else
                        {
                            match = false;
                            break;
                        }
                         newIndex++;
                    }
                }
                else
                {
                    match = false;
                }
                if (match == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

            // Unnecessary stuff that you could have in the beginning of the code:
            //
            // while (true)
            // {
            //     // if (a.Length < b.Length) // check if b is shorter than a: return 0
            // {
            //     return 0;
            // }
            // else if ((a.Length == b.Length) && !(a == b)) // check if a and b are equal length but different: return 0
            // {
            //     return 0;
            // }
            // else if (a == b) // check if a = b: return 1
            // {
            //     return 1;
            // }
            // else
            // { (put the complicated stuff in here)
            //  return count;
            // }

