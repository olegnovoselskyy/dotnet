using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {


            //string filePath = @"D:\Repos\dotnet\DotNet\Collections\PopbyLargestFinal.csv";

            //CsvReader reader = new CsvReader(filePath);

            //var countryOfOlaha = new Country("Olaha's Kingdom", "OK", "Olaha's Room", 60000);

            //var countries = reader.ReadAllCountries();
            //int index = countries.FindIndex(x => x.Population < 60000);
            //countries.Insert(index, countryOfOlaha);

            //foreach (Country country in countries)
            //{

            //    Console.WriteLine($"{country.Population} : {country.Name}");
            //}

            var australia = new Country("Australia", "AUS", "Oceania", 100000000);
            var russia = new Country("Russia", "RUS", "Europe", 200000000);

            var countries = new Dictionary<string, Country>();
            countries.Add("AUS", australia);
            countries.Add("RUS", russia);

            Country selectedCountry = countries["AUS"];

            Console.WriteLine($"{selectedCountry.Name} has {selectedCountry.Population} people!");

            foreach (var country in countries.Values)
                Console.WriteLine(country.Name);




            #region Old Code


            //string filePath = @"D:\Repos\dotnet\DotNet\Collections\PopbyLargestFinal.csv";

            //CsvReader reader = new CsvReader(filePath);

            //Country[] countries = reader.ReadFirstNCountries(10);

            //foreach (Country country in countries)
            //{

            //    Console.WriteLine($"{country.Population} : {country.Name}");
            //}


            //List<int> ints = new List<int>();
            //List<string> daysOfWeek = new List<string>();
            //daysOfWeek.Add("Monday");
            //daysOfWeek.Add("Tuesday");
            //daysOfWeek.Add("Wednesday");
            //daysOfWeek.Add("Thursday");
            //daysOfWeek.Add("Friday");
            //daysOfWeek.Add("Saturday");
            //daysOfWeek.Add("Sunday");

            //string[] daysOfWeek =
            //{
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "Thursday",
            //    "Friday",
            //    "Saturday",
            //    "Sunday"
            //};

            //// daysOfWeek[6] = "Day of the LORD!"; 
            //int count = 0;
            //foreach (string day in daysOfWeek)
            //{

            //    if (count != 2)
            //    {
            //        daysOfWeek[count] = "LAST DAY OF DIRT!";
            //    }

            //    Console.WriteLine(daysOfWeek[count]);
            //    count++;
            //}


            //Console.WriteLine(daysOfWeek[1]);


            //Console.WriteLine("What day of the week would you like to display? (1-7)");
            //var input = Console.ReadLine();         
            //Console.WriteLine($"That day is {daysOfWeek[Convert.ToInt32(input)-1]}");

            #endregion

        }
    }
}
