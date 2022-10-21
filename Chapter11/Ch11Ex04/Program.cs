using System;

namespace Ch11Ex04
{
    public class Checker
    {
        public void Check(object param1)
        {
            if (param1 is ClassA)
                Console.WriteLine("Variable can be converted to ClassA");
            else
                Console.WriteLine("Variable can't be converted to ClassA");
            if (param1 is IMyInterface)
                Console.WriteLine("Variable can be converted to IMyInterface");
            else
                Console.WriteLine("Variable can't be converted to IMyInterface");
            if (param1 is myStruct)
                Console.WriteLine("Variable can be converted to MyStruct");
            else
                Console.WriteLine("Variable can't be converted to MyStruct");
        }
    }

    interface IMyInterface {}
    class ClassA : IMyInterface {}
    class ClassB : IMyInterface {}
    class ClassC { }
    class ClassD : ClassA { }
    struct myStruct : IMyInterface { }
    public class Program
    {
        static void Main(string[] args)
        {
            Checker check = new Checker();
            ClassA try1 = new ClassA();
            ClassB try2 = new ClassB();
            ClassC try3 = new ClassC();
            ClassD try4 = new ClassD();
            myStruct try5 = new myStruct();
            object try6 = try5;

            Console.WriteLine("\nAnalyzing " + try1 + " type variable:");
            check.Check(try1);
            Console.WriteLine("\nAnalyzing " + try2 + " type variable:");
            check.Check(try2);
            Console.WriteLine("\nAnalyzing " + try3 + " type variable:");
            check.Check(try3);
            Console.WriteLine("\nAnalyzing " + try4 + " type variable:");
            check.Check(try4);
            Console.WriteLine("\nAnalyzing " + try5 + " type variable:");
            check.Check(try5);
            Console.WriteLine("\nAnalyzing " + try6 + " type variable:");
            check.Check(try6);
        }
    }
}
