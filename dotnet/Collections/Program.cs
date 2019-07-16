using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] daysOfWeek =
            //{
            //    "MONDAY",
            //    "TUESDAY",
            //    "WEDNESDAY",
            //    "THURSDAY",
            //    "FRIDAY",
            //    "SATURDAY",
            //    "SUNDAY"
            //};

            //var replace = "LAST DAY OF DIRT";
            //int index = 0;

            //foreach (string day in daysOfWeek)
            //{
            //    if (index != 2)
            //    {
            //        daysOfWeek[index] = replace;
            //    }
            //    Console.WriteLine(daysOfWeek[index]);

            //    index++;ss
            //}

            //Console.WriteLine();


            //Console.WriteLine("What day is it?");
            //int indexDay = int.Parse(Console.ReadLine()) - 1;
            //Console.WriteLine($"Today is {daysOfWeek[indexDay]}");

            string filePath = @"C:\Users\amid2\source\repos\dotnet\dotnet\Collections\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            int lilliputIndex = countries.FindIndex(x=>x.Population < 2_000_000);
            countries.Insert(lilliputIndex, lilliput);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
