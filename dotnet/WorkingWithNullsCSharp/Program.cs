using System;

namespace WorkingWithNullsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = null;
            //player.Name = "Young Dim Flexmaster Floss";
            //player.DaysSinceLastLogin = 1;
            //player.DateOfBirth = Convert.ToDateTime("10/31/1913 3:00 AM");

            int days = player?.DaysSinceLastLogin ?? -1;

            //if(player != null)
            //{
            //    days = player.DaysSinceLastLogin ?? -1;
            //}
            //else
            //{
            //    days = -1;
            //}

            Console.WriteLine(days);

            //PlayerDisplay.Write(player);
            Console.ReadLine();
        }
    }
}
