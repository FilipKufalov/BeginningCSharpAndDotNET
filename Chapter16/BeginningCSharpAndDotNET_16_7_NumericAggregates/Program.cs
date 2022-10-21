using System;
using System.Linq;

namespace BeginningCSharpAndDotNET_16_7_NumericAggregates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateLotsOfNumbers(5000);
            Console.WriteLine("Numeric Aggregates");
            var queryResults =
                from n in numbers
                where n > 1000
                select n;
            Console.WriteLine("Count of Numbers > 1000");
            Console.WriteLine(queryResults.Count());
            Console.WriteLine("Max of Numbers > 1000");
            Console.WriteLine(queryResults.Max());
            Console.WriteLine("Min of Numbers < 1000");
            Console.WriteLine(queryResults.Min());
            Console.WriteLine("Average of Numbers > 1000");
            Console.WriteLine(queryResults.Average());
            Console.WriteLine("Sum of Numbers > 1000");
            Console.WriteLine(queryResults.Sum(n => (long) n));
            Console.WriteLine(numbers);
        }

        private static int[] GenerateLotsOfNumbers(int count)
        {
            Random generator = new Random(0);
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = generator.Next();
            }
            return result;
        }
    }
}
