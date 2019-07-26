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

            if (player.DaysSinceLastLogin == null)
            {
                Console.WriteLine("Days Since Last Login is unknown.");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin + " day(s) since last login");
            }

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("Date Of Birth is unknown.");
            }
            else
            {
                Console.WriteLine("DOB: " + player.DateOfBirth);
            }

            if(player.IsNoob == null)
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
