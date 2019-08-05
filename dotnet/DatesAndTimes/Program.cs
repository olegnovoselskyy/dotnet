using System;
using System.IO;
using System.Linq;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"C:\Users\amid2\source\repos\dotnet\dotnet\DatesAndTimes\StockData.csv");

            foreach (var line in lines.Skip(1))
            {
                var segments = line.Split(',');
                var tradeDate = DateTime.Parse(segments[1]);

                Console.WriteLine(tradeDate.ToLongDateString());

            }
        }
    }
}
