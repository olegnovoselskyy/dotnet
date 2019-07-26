﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            int? days = player.DaysSinceLastLogin.GetValueOrDefault(0);
            Console.WriteLine($"{days.GetValueOrDefault()} Days");
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player has no name.");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            if (!player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine("Never logged in");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if (player.DateOfBirth == null)
            {
                Console.WriteLine(DateTime.Now);
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNew == null)
            {
                Console.WriteLine("Player experience is unknown");
            }
            else if (player.IsNew == true)
            {
                Console.WriteLine("Player is noob");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
            
        }
    }
}
