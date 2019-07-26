using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithNullsCSharp
{
    class PlayerDisplay
    {
        public static void Write(PlayerCharacter player)
        {
            if (String.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is unknown.");
            }
            else
            {
                Console.WriteLine(player.Name);
            }


            int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1337;
            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1337);
            Console.WriteLine(days + " day(s) since last login");

            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin.Value + " day(s) since last login");
            //}
            //else
            //{
            //    Console.WriteLine("Days Since Last Login is unknown.");
            //}

            if (player.DateOfBirth.HasValue)
            {
                Console.WriteLine("DOB: " + player.DateOfBirth);
            }
            else
            {
                Console.WriteLine("Date Of Birth is unknown.");
            }

            if(!player.IsNoob.HasValue)
            {
                Console.WriteLine("Player noob status is unknown.");

            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine(player.Name + " is a noob.");
            }
            else
            {
                Console.WriteLine(player.Name + " is a not a noob.");
            }

        }
    }
}
