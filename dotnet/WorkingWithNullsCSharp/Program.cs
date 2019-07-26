using System;

namespace WorkingWithNullsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Young Dim Flexmaster Floss";
            //player.DaysSinceLastLogin = 1;
            player.DateOfBirth = Convert.ToDateTime("10/31/1913 3:00 AM");

            PlayerDisplay.Write(player);
            Console.ReadLine();
        }
    }
}
