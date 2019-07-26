using System;

namespace WorkingWithNullsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Destructor";

            PlayerDisplay.Write(player);
            Console.ReadLine();
        }
    }
}
