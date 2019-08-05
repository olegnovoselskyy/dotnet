using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parsing Date Time from file
            var lines = File.ReadAllLines(@"C:\Users\amid2\source\repos\dotnet\dotnet\DatesAndTimes\StockData.csv");

            Console.WriteLine("Dates/Times from file:");
            foreach (var line in lines.Skip(1))
            {
                var segments = line.Split(',');
                var tradeDate = DateTime.Parse(segments[1], CultureInfo.GetCultureInfo("en-GB"));

                Console.WriteLine(tradeDate.ToLongDateString());
            }
            Console.WriteLine();

            // Converting Between Time Zones
            var now = DateTime.Now;
            TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
            var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZone);

            Console.WriteLine("Converting Between Time Zones:");
            Console.WriteLine($"Local: {now}");
            Console.WriteLine($"Sydney: {sydneyTime}");

            // DateTimeOffset includes TimeZone
            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTimeOffset.Now);

        }
    }
}
