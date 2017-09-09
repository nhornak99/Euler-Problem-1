using System;
using System.Collections.Generic;

namespace Euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfMultiples = 0;
            List<int> multiplesOf3 = new List<int>();
            List<int> multiplesOf5 = new List<int>();

            for (int i = 3; i < 1000; i+=3)
            {
                multiplesOf3.Add(i);
            }

            for (int i = 5; i < 1000; i+=5)
            {
                multiplesOf5.Add(i);
            }

            // Adds each multiple of 5 to the sum.
            foreach (var multiple in multiplesOf5)
            {
                // Removes duplicates from the two lists of multiples.
                if (multiplesOf3.Contains(multiple))
                {
                    multiplesOf3.Remove(multiple);
                }

                sumOfMultiples += multiple;
            }

            // Adds each multiple of 3 to the sum.
            foreach(var multiple in multiplesOf3)
            {
                sumOfMultiples += multiple;
            }

            Console.WriteLine("The sum of all multiples of 3 and 5 less than 1000 is: {0}", sumOfMultiples);
            Console.Read();
        }
    }
}
