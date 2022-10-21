using System;
using System.IO;
using System.Text;

namespace ReadWriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] byteData;
            char[] charData;

            try
            {
                using (FileStream aFile = new FileStream("Temp.txt", FileMode.Create)) 
                {
                    charData = "My pink half of the drainpipe.".ToCharArray();
                    Encoder e = Encoding.UTF8.GetEncoder();
                    byteData = new byte[e.GetByteCount(charData, true)];
                    e.GetBytes(charData, 0, charData.Length, byteData, 0, true);
                    // Move file pointer to beginning of file.
                    aFile.Seek(0, SeekOrigin.Begin);
                    aFile.Write(byteData, 0, byteData.Length);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
