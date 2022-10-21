using System;
using System.Collections.Generic;
using System.Linq;

namespace _16._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe",
 "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh",
"Samba", "Fatimah" };

            IEnumerable<string> MethodQuery = names.Where(x => x.StartsWith("S"));


            var queryResults =
            from n in names
            //where n.StartsWith("S")
            select n;
            Console.WriteLine("Names beginning with S:");
            foreach (var item in queryResults)
            {
                //Console.WriteLine(item);
                Console.WriteLine(item.Max());
                //Console.WriteLine(item.Average());
                //Console.WriteLine(item.Sum());
                Console.WriteLine($"{item} with Long Count {item.LongCount()}");
            }
            Console.Write("Program finished, press Enter/Return to continue:");
        }
    }
}
