using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {       
            string[] daysOfWeek =
            {
                "MONDAY",
                "TUESDAY",
                "WEDNESDAY",
                "THURSDAY",
                "FRIDAY",
                "SATURDAY",
                "SUNDAY"
            };

            var replace = "LAST DAY OF DIRT";
            int index = 0;

            foreach (string day in daysOfWeek)
            {
                if (index != 2)
                {
                    daysOfWeek[index] = replace;
                }
                Console.WriteLine(daysOfWeek[index]);

                index++;
            }

            Console.WriteLine();
            

            Console.WriteLine("What day is it?");
            int indexDay = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"Today is {daysOfWeek[indexDay]}");
        }
    }
}
