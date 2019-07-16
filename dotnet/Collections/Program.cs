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

            //string filePath = @"C:\Users\amid2\source\repos\dotnet\dotnet\Collections\Pop by Largest Final.csv";
            //CsvReader reader = new CsvReader(filePath);

            //List<Country> countries = reader.ReadAllCountries();
            //Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            //int lilliputIndex = countries.FindIndex(x=>x.Population < 2_000_000);
            //countries.Insert(lilliputIndex, lilliput);
            //countries.RemoveAt(lilliputIndex);

            //foreach (Country country in countries)
            //{
            //    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            //}
            //Console.WriteLine($"{countries.Count} countries");

            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe", 5_282_223);

            var countries = new Dictionary<string, Country>
            {
                { norway.Code, norway },
                { finland.Code, finland }
            };

            Country selectedCountry = countries.ContainsKey(norway.Code) ? countries[norway.Code] : null;
            Country selectedCountryTry = countries.TryGetValue("MUS", out Country country2) ? country2 : null;

            if (selectedCountry != null)
                Console.WriteLine($"Selected Country: {selectedCountry.Name}");


            if (selectedCountryTry != null)
            {
                Console.WriteLine($"Attempted Country: {selectedCountry.Name}");
            }
            else
            {
                Console.WriteLine($"Attempted Country is not in the dictionary");
            }


            Console.WriteLine();
            Console.WriteLine("All Countries:");
            foreach (var country in countries.Values) 
                Console.WriteLine(country.Name);
        }
    }
}
