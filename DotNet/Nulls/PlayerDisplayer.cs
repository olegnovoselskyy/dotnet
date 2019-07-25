using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if (player.DaysSinceLastLogin == 0)
            {
                Console.WriteLine("Never logged in");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if (player.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine(DateTime.Now);
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }
            
        }
    }
}
