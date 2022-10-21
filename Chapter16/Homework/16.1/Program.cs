using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_3_QuerySyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe",
 "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh",
"Samba", "Fatimah" };

            IEnumerable<string> MethodQuery = names.OrderByDescending(x => x);
            Console.WriteLine("Query Order by Descending using Method");
            foreach (string name in MethodQuery)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nDescending List:");
            var Descending =
                from name in names
                orderby name descending
                select name;

            foreach (string name in Descending)
            {
                Console.WriteLine(name);
            }
        }
    }
}
