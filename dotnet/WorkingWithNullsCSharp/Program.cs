using System;

namespace WorkingWithNullsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter {Name = "Dima"},
                new PlayerCharacter (),
                null

            };

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            Console.ReadLine();
        }
    }
}
