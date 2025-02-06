using System;
using System.IO;

namespace Fileopen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fp = @"C:\Users\preethu\Word.txt";


            using (FileStream ab = new FileStream(fp, FileMode.Append))
            {

                using (StreamWriter writer = new StreamWriter(ab))
                {
                    writer.WriteLine("Hello world!!");
                }
            }

            Console.WriteLine("Text has been written to the file.");
        }
    }
}
