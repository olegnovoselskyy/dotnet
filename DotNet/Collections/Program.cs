using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            daysOfWeek[6] = "Day of the LORD!"; 

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            //Console.WriteLine(daysOfWeek[1]);


            //Console.WriteLine("What day of the week would you like to display? (1-7)");
            //var input = Console.ReadLine();         
            //Console.WriteLine($"That day is {daysOfWeek[Convert.ToInt32(input)-1]}");
        }
    }
}
