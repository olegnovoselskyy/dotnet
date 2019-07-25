using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program_COUNTRIES
    {
        static void Main_COUNTRIES(string[] args)
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
            //Dictionary<string, Country> countries = reader.ReadAllCountries();

            //Console.Write("Enter country code: ");
            //string countryInput = Console.ReadLine();

            //bool gotCountry = countries.TryGetValue(countryInput, out Country country);
            //if (!gotCountry)
            //    Console.WriteLine($"The records must be incomplete. Country code: {countryInput} does not exist.");
            //else
            //    Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");

            string filePath = @"C:\Users\amid2\source\repos\dotnet\dotnet\Collections\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, List<Country>> countries = reader.ReadAllCountries();
            //Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            //int lilliputIndex = countries.FindIndex(x => x.Population < 2_000_000);
            //countries.Insert(lilliputIndex, lilliput);
            //countries.RemoveAt(lilliputIndex);
            foreach (string region in countries.Keys)
                Console.WriteLine(region);

            Console.Write("Which of the above regions do you want? ");
            string chosenRegion = Console.ReadLine();
            //var filteredCountries = countries.Where(x => !x.Name.Contains(','));
            //var filteredCountries2 = from country in countries
            //                         where !country.Name.Contains(',')
            //                         select country;
            if (countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].Take(10))
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            else
                Console.WriteLine("That is not a valid region");


            //string filePath = @"C:\Users\amid2\source\repos\dotnet\dotnet\Collections\Pop by Largest Final.csv";
            //CsvReader reader = new CsvReader(filePath);
            //List<Country> countries = reader.ReadAllCountries();
            //reader.RemoveCommaCountries(countries);

            //Console.WriteLine("Enter no. of countries to display");
            //bool inputIsInt = int.TryParse(Console.ReadLine(), out int countryCountInput);
            //if(!inputIsInt || countryCountInput <= 0)
            //{
            //    Console.WriteLine("You must type in a +ve integer. Exiting");
            //    return;
            //}

            //int maxToDisplay = countryCountInput;
            //for (int i = 0; i < countries.Count; i++)
            //{
            //    if(i > 0 && (i % maxToDisplay == 0))
            //    {
            //        Console.WriteLine("Hit return to continue, anything else to quit>");
            //        if (Console.ReadLine() != "")
            //            break;
            //    }

            //    Country country = countries[i];
            //    Console.WriteLine($"{i+1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            //}

            //Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            //Country finland = new Country("Finland", "FIN", "Europe", 5_282_223);

            //var countries = new Dictionary<string, Country>
            //{
            //    { norway.Code, norway },
            //    { finland.Code, finland }
            //};

            //Country selectedCountry = countries.ContainsKey(norway.Code) ? countries[norway.Code] : null;
            //Country selectedCountryTry = countries.TryGetValue("MUS", out Country country2) ? country2 : null;

            //if (selectedCountry != null)
            //    Console.WriteLine($"Selected Country: {selectedCountry.Name}");


            //if (selectedCountryTry != null)
            //{
            //    Console.WriteLine($"Attempted Country: {selectedCountry.Name}");
            //}
            //else
            //{
            //    Console.WriteLine($"Attempted Country is not in the dictionary");
            //}


            //Console.WriteLine();
            //Console.WriteLine("All Countries:");
            //foreach (var country in countries.Values) 
            //    Console.WriteLine(country.Name);
        }
    }
}
