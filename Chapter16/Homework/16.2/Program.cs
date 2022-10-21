using System;
using System.Linq;

namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateLotsOfNumbers(500);
            var test = 
                from n in numbers
                where n > 0
                select n;

            foreach (int n in numbers)
                Console.WriteLine(n);
        }
        private static int[] GenerateLotsOfNumbers(int count)
        {
            Random random = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(0, count);
            }

            return numbers;
        }
    }
}
