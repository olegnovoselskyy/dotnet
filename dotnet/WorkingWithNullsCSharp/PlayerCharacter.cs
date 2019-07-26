using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithNullsCSharp
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public Nullable<int> DaysSinceLastLogin { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = null;
            DaysSinceLastLogin = null;
        }
    }
}
