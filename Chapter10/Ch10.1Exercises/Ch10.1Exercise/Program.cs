
using Ch10._1Exercise;

myClass MyClass = new myClass();
MyClass.ContainedString = "test";
myDerivedClass MyDerivedClass = new myDerivedClass();
MyDerivedClass.ContainedString = "test";

Console.WriteLine(MyClass.GetString());
Console.WriteLine(MyDerivedClass.GetString());









/*partial class MyFirstPartialClass
{
    public partial void MyTestMethod()
    {

    }
}

partial class A
{
    partial void OnSomethingHappened(string s)
    {
        Console.WriteLine("Something happened: {0}");
    }
}*/