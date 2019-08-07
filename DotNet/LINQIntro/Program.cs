using System;
using System.Collections.Generic;
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
            Array.Sort(files, new FileInfoCompare());
            for (int i = 0; i < 5; i++)
            {
                var file = files[i];
                Console.WriteLine($"{file.Name, -20} : {file.Length, 10:N0}");
            } 
        }
    }
    public class FileInfoCompare : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
