using System;
using System.IO;
namespace WorkingWithFiles5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lucas Ortis\Downloads";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"/newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
