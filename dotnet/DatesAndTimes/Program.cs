﻿using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace DatesAndTimes
{
    class Program
    {
        static Calendar calendar = CultureInfo.InvariantCulture.Calendar;

        // IF WE CANNOT USE DOTNET CORE 3.0 - do this to get ISO week of the year (otherwise: use ISOWeek.GetWeekOfYear)
        // This presumes that week starts with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        public static int GetIso8601WeekOfYear(DateTime _time)
        {
            // Seriously cheat. If its Monday, Tuesday or Wednesday, then it'll
            // be the same week# as whatever Thursday, Friday, or Saturday are,
            // and we'll always get those right
            DayOfWeek day = calendar.GetDayOfWeek(_time);

            if(day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                _time = _time.AddDays(3);
            }

            // return the week of our adjusted day
            return calendar.GetWeekOfYear(_time, CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday);
        }

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

            // Simple DateTime.Parse
            Console.WriteLine();
            Console.WriteLine("Simple DateTime.Parse:");
            var _date = "2019-07-01 10:00:00 PM +02:00";

            var simpleParse = DateTime.Parse(_date,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AdjustToUniversal);


            Console.WriteLine(simpleParse);
            Console.WriteLine(simpleParse.Kind);

            // Formatting to iso 8601
            Console.WriteLine();
            Console.WriteLine("Formatting to iso 8601:");
            var date_ = "9/10/2019 10:00:00 PM";

            var parsedDate_ = DateTimeOffset.ParseExact(date_,
                "M/d/yyyy h:mm:ss tt",
                CultureInfo.InvariantCulture);

            parsedDate_.ToOffset(TimeSpan.FromHours(11));
            var SformattedDate = simpleParse.ToString("s"); // simply use s
            var OformattedDate = simpleParse.ToString("o"); // simply use o

            Console.WriteLine(SformattedDate);
            Console.WriteLine(OformattedDate);

            // Converting to UTC
            Console.WriteLine();
            Console.WriteLine("Converting to UTC:");
            var _now = DateTimeOffset.Now;

            Console.WriteLine(_now.ToUniversalTime());

            // Timespan calculation
            Console.WriteLine();
            Console.WriteLine("Timespan calculation:");
            var timeSpan = new TimeSpan(60, 100, 200);

            Console.WriteLine(timeSpan);
            Console.WriteLine($"Days: { timeSpan.Days}");
            Console.WriteLine($"Hours: { timeSpan.Hours}");
            Console.WriteLine($"Minutes: { timeSpan.Minutes}");
            Console.WriteLine($"Seconds: {timeSpan.Seconds}");
            Console.WriteLine($"Total Days: { timeSpan.TotalDays}");
            Console.WriteLine($"Total Hours: { timeSpan.TotalHours}");
            Console.WriteLine($"Total Minutes: { timeSpan.TotalMinutes}");
            Console.WriteLine($"Total Seconds: {timeSpan.TotalSeconds}");

            // Calculating Difference
            Console.WriteLine();
            Console.WriteLine("Calculating Difference:");
            var start = DateTimeOffset.UtcNow;
            var end = start.AddSeconds(45);

            TimeSpan difference = end - start;

            difference.Multiply(2);

            Console.WriteLine(difference);

            // Getting Week of the year
            Console.WriteLine();
            Console.WriteLine("Getting Week of the year:");
            var _start = new DateTimeOffset(2007, 12, 31, 0, 0, 0, TimeSpan.Zero);

            var week = calendar.GetWeekOfYear(_start.DateTime,
                CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday);

            Console.WriteLine(week);
            Console.WriteLine(GetIso8601WeekOfYear(_start.DateTime));

        }
    }
}
