using System;
using System.Collections.Generic;
using System.Linq;

namespace BeginningCSharpAndDotNET_16_6_LargeNumber_Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateLotsOfNumbers(354); //12054678

            var backNumbers =
                from num in numbers
                where num < 1000
                select num;

            Console.WriteLine("Query Results:");
            foreach (var numbs in backNumbers)
            {
                Console.WriteLine(numbs);
            }
        }

        private static int[] GenerateLotsOfNumbers(int length)
        {
            Random random = new Random();
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(0, length);
            }

            return numbers;
        }
    }
}
