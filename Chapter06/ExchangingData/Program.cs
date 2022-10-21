using System;

namespace ExchangingData
{
    internal class Program
    {
        /// <summary>
        /// Shows the double
        /// </summary>
        /// <param name="val"></param>
        static void ShowDouble(ref int val)
        {
            val *= 2;

            Console.WriteLine($"val doubled = {val}");
        }
        static void Main(string[] args)
        {
            int val = 5;
            Console.WriteLine($"val = {val}");
            ShowDouble(ref val);
            Console.WriteLine($"val = {val}");
            CustomerName myCustomer;
            myCustomer.firstName = "Filip";
            myCustomer.lastName = "Kufalov";
            Console.WriteLine($"{myCustomer.firstName}");
        }

        struct CustomerName
        {
            public string firstName, lastName;
            public string fullName => $"{firstName} {lastName}";
        }
    }
}
