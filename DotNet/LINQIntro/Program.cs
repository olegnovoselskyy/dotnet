using System;
using System.IO;

namespace LINQIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\windows";
            ShowLargeFilesWithoutLinq(path);
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            var files = dir.GetFiles();

            foreach (var file in files)
            {
                Console.WriteLine($"{file.Length}");
            }
        }
    }
}
