using System;
using static System.Console;

namespace _16._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small",
 "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };

            var queryResults = names;

            WriteLine("Names in query:");
            int orderNum = 1;
            foreach (var item in queryResults)
            {           
                WriteLine($"{orderNum}. {item}");
                orderNum++;
            }
            Write("Program finished, press Enter/Return to continue:");
        }
    }
}
