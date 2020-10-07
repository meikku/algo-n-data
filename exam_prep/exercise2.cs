namespace exam_prep
{
    using System;
    using System.Collections.Generic;

    public class ShortenArray
    {

        public int Calculate(int[] input)
        {
            List<int> storage = new List<int>();

            foreach (int i in input)
            {
                if ((storage.Count == 0) || (storage[storage.Count-1] != i))
                {
                    storage.Add(i);
                }
                else 
                {
                    storage.RemoveAt(storage.Count -1);
                }
            }
            return storage.Count;
           

            // for (int i = 0; i < input.Length - 1; i++)
            // {
            //     if ((i == input.Length - 1) && ((input[i + 1]) != (input[i])))
            //     {
            //         copy.Add(input[i]);
            //         copy.Add(input[i + 1]);
            //     }
            //     else if (input[i + 1] != input[i])
            //     {
            //         copy.Add(input[i]);
                   
            //     else
            //     {
            //         i = i + 1;
            //     }
            // }
            // Console.WriteLine("copy:");
            // foreach (int i in copy)
            // {
            //     System.Console.WriteLine(i);
            // }
            // int[] shorter = new int[copy.Count];
            // int index = 0;
        
            // foreach (int i in copy)
            // {
            //     shorter[index++] = i;
            // }
        

      
            // foreach (int i in shorter)
            // {
            //     Console.WriteLine(i);
            // }

            // for (int j = 0; j < copy.Count; j++)
            // {
            //     shorter[j] = copy[j];
            // }
            // if (shorter.Length == input.Length)
            // {
            //     return shorter.Length;
            // }
            // return Calculate(shorter);
        }
    }
}


// 
// for (int j = 0; j < input.Length ; j++)
// {
//     if (input[j] != input[i] && input[j] != input[i +1]) {

//     }
//     else {
//         copy.Add(input[j]);
//     }

// }
