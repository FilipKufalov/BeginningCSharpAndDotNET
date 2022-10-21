using System;
using System.IO;
using System.Text;

namespace StreamWriter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FileStream aFile = new FileStream("Log.txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(aFile))
                    {
                        bool truth = true;
                        sw.WriteLine("Hello to you");
                        sw.WriteLine($"It is now {DateTime.Now.ToLongDateString()}");
                        sw.WriteLine("and things are looking good");
                        sw.WriteLine("More than that");
                        sw.WriteLine($" it's {truth} that C# is fun");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Fail");
                //throw;
            }
        }
    }
}
