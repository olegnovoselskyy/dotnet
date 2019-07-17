using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {


            string filePath = @"D:\Repos\dotnet\DotNet\Collections\PopbyLargestFinal.csv";

            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                
                Console.WriteLine($"{country.Population} : {country.Name}");
            }

            #region Old Code

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
