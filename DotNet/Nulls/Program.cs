﻿using System;

namespace Nulls
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.DaysSinceLastLogin = 5;

            PlayerDisplayer.Write(player);

        }
    }
}
