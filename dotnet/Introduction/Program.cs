using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Program Files (x86)\Image-Line\FL Studio 20\Data\Patches\Packs\PACKS\various samples\random stuff and loops";
            ShowLargeFilesWithoutLinq(path);
            Console.WriteLine("***");
            ShowLargeFilesWithLinq(path);

            Console.Read();

        }

        private static void ShowLargeFilesWithLinq(string path)
        {
            var query = new DirectoryInfo(path).GetFiles().OrderByDescending(f => f.Length).Take(5);
            foreach(var file in query)
            {
                Console.WriteLine($"{file.Name,-20} - {file.Length,10:N0}");
            }
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name, -20} - {file.Length, 10:N0}");
            }
        }

        public class FileInfoComparer : Comparer<FileInfo>
        {
            public override int Compare(FileInfo x, FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }
    }
}
