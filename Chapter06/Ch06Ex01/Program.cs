static void Write(string param)
{
    Console.WriteLine($"myString = {param}");
}

string myString = "String defined in Main()";
Write(myString);
Console.ReadLine();