using System;
using System.Linq;

namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateLotsOfNumbers(12054678); //12054678

            var backNumbers =
                from num in numbers
                where num < 1000
                orderby num
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
