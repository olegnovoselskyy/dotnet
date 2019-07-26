using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNew { get; set; }

        //public PlayerCharacter()
        //{
        //    Name = "No name given.";
        //    DateOfBirth = null;
        //    DaysSinceLastLogin = null;
        //}
    }
}
