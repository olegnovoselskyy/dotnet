﻿using System;

namespace WorkingWithNullsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter destuctor = new PlayerCharacter(new IronBonesDefense())
            {
                Name = "Destructor",
                IsNoob = false
            };

            PlayerDisplay.Write(destuctor);
            Console.WriteLine();

            PlayerCharacter mickey = new PlayerCharacter(SpecialDefense.Null)
            {
                Name = "Mickey Mouse",
                DaysSinceLastLogin = 1,
                DateOfBirth = Convert.ToDateTime("11/18/1928"),
                IsNoob = true
            };

            PlayerDisplay.Write(mickey);
            Console.WriteLine();

            PlayerCharacter dima = new PlayerCharacter(new DiamondSkinDefense())
            {
                Name = "Dima",
                DaysSinceLastLogin = 11,
                DateOfBirth = Convert.ToDateTime("11/01/1928")
            };

            PlayerDisplay.Write(dima);
            Console.WriteLine();

            destuctor.Hit(10);
            mickey.Hit(10);
            dima.Hit(10);

            Console.ReadLine();
        }
    };
}
    
    

