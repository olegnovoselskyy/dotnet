using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithNullsCSharp
{
    public class IronBonesDefense : ISpecialDefense
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
            
    }
}
