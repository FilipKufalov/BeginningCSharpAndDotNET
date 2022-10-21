using System;

namespace Ch09Exercises
{
    internal class Program
    {
        internal class MyBase
        {
            public string hello = "Hello";
        }
        internal class MyClass : MyBase
        {
            public void SayHello()
            {
                Console.WriteLine(hello);
            }
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.SayHello());
        }
    }
}
