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
            Console.WriteLine("Dates/Times from file:");
            var lines = File.ReadAllLines(@"C:\Users\amid2\source\repos\dotnet\dotnet\DatesAndTimes\StockData.csv");
            foreach (var line in lines.Skip(1))
            {
                var segments = line.Split(',');
                var tradeDate = DateTime.Parse(segments[1], CultureInfo.GetCultureInfo("en-GB"));

                Console.WriteLine(tradeDate.ToLongDateString());
            }

            // Converting Between Time Zones
            Console.WriteLine();
            Console.WriteLine("Converting Between Time Zones:");
            var now = DateTime.Now;
            TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
            var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZone);
            Console.WriteLine($"Local: {now}");
            Console.WriteLine($"Sydney: {sydneyTime}");

            // DateTimeOffset includes TimeZone
            Console.WriteLine();
            Console.WriteLine("DateTimeOffset includes TimeZone:");
            Console.WriteLine($"DateTime.Now:  {DateTime.Now}");
            Console.WriteLine($"DateTimeOffset.Now: {DateTimeOffset.Now}");

            // Finding all System Time Zones
            Console.WriteLine();
            Console.WriteLine("Finding all System Time Zones:");
            var time = DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(-4)); // insert time zone calculation here
            foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
            {
                if (timeZone.GetUtcOffset(time) == time.Offset)
                {
                    Console.WriteLine(timeZone);
                }
            }

            // DateTime.ParseExact if we know the how the format is provided
            Console.WriteLine();
            Console.WriteLine("DateTime.ParseExact if we know the how the format is provided:");
            var date = "9/10/2019 10:00:00 PM";

            var parsedDate = DateTime.ParseExact(date,
                "M/d/yyyy h:mm:ss tt", 
                CultureInfo.InvariantCulture);

            Console.WriteLine(parsedDate);

        }
    }
}
