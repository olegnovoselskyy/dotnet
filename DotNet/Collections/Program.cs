using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {


            string filePath = @"D:\Repos\dotnet\DotNet\Collections\PopbyLargestFinal.csv";

            CsvReader reader = new CsvReader(filePath);


            var countryOfOlaha = new Country("Olaha's Kingdom", "OK", "Olaha's Room", 60000);

            var countries = reader.ReadAllCountries();
            //int index = countries.FindIndex(x => x.Population < 60000);
            //countries.Insert(index, countryOfOlaha);

            Console.Write("Enter # of coutnires to display: ");
            bool isValid = int.TryParse(Console.ReadLine(), out var input);
            if (isValid && input >= 0)
            {
                int maxToDsiplay = Math.Min(input, countries.Count);
                for (int i = 0; i < maxToDsiplay; i++)
                {
                    Country country = countries[i];
                    Console.WriteLine($"{country.Name} has an index of {i}");                                     
                }
            }
            else
            {
                Console.WriteLine("That's not a valid interger, exiting program.");
            }

            //foreach (Country country in countries)
            //{

            //    Console.WriteLine($"{country.Population} : {country.Name}");
            //}

            #region Old Code


            //Console.WriteLine("Enter a country code to look up a country:");
            //var countries = reader.ReadAllDictionaryCountries();
            //string userInput = Console.ReadLine();

            //bool gotCountry = countries.TryGetValue(userInput, out Country country);

            //if (!gotCountry)
            //    Console.WriteLine($"C'mon now... be real... {userInput} is not a country!");
            //else
            //    Console.WriteLine($"{country.Name} has a population of {country.Population}");

            //var countries = new Dictionary<string, Country>
            //{
            //    { "AUS", new Country("Australia", "AUS", "Oceania", 100000000)},
            //    { "RUS", new Country("Russia", "RUS", "Europe", 200000000)}
            //};

            //Country selectedCountry = countries["AUS"];

            //Console.WriteLine($"{selectedCountry.Name} has {selectedCountry.Population} people!");

            //foreach (var country in countries.Values)
            //    Console.WriteLine(country.Name);


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
