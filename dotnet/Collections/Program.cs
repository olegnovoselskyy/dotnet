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

            Console.WriteLine("What day is it?");
            int inputtedDay = int.Parse(Console.ReadLine()) - 1;

            string chosenDay = daysOfWeek[inputtedDay];
            Console.WriteLine($"Today is {chosenDay}");
        }
    }
}
