using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithNullsCSharp
{
    public class IronBonesDefense : SpecialDefense
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
            
    }
}
