using System;

namespace Ch11Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Primes primes = new Primes(2, 1000);
            foreach (long item in primes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
