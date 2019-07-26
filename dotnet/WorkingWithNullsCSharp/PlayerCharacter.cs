﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithNullsCSharp
{
    class PlayerCharacter
    {
        private readonly SpecialDefense _specialDefense;

        public PlayerCharacter(SpecialDefense specialDefense)
        {
            _specialDefense = specialDefense;
        }

        public string Name { get; set; }

        public int Health { get; set; } = 100;
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }

        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //if (_specialDefense != null)
            //{
            //    damageReduction = _specialDefense.CalculateDamageReduction(damage);
            //}

            //int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefense.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }
    }
}
