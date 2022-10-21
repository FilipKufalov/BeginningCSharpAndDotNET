using System;

namespace Ch06Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}
