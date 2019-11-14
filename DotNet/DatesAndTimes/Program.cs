using System;
using System.IO;
using System.Linq;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"\Repos\dotnet\DotNet\Data\StockData.csv");

            foreach (var line in lines.Skip(1))
            {
                var segments = line.Split(',');

                var tradeDate = DateTime.Parse(segments[1]);

                Console.WriteLine(tradeDate.ToLongDateString());
            }

            var flTime = DateTime.Now;
            var saratovTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Saratov Standard Time");

            var saratovTime = TimeZoneInfo.ConvertTime(flTime, saratovTimeZone);

            Console.WriteLine(flTime);
            Console.WriteLine(saratovTime);
            //foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            //    Console.WriteLine(z.Id);

           
        }
    }
}
