using System;
using System.IO;

namespace StreamRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                using (FileStream aFile = new FileStream("Log.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(aFile))
                    {
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sr.ReadLine();
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
