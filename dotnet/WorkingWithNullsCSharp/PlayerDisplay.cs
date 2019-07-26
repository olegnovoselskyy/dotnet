using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithNullsCSharp
{
    class PlayerDisplay
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);
            if (player.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No value for Days Since Last Login");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }
            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No Date Of Birth");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }
        }
    }
}
