using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("WrittenFile.txt", "Hello everyone");
            Console.WriteLine("Hello World!");
        }
    }
}
