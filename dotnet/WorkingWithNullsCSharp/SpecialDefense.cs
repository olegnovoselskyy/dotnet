namespace WorkingWithNullsCSharp
{
    public abstract class SpecialDefense
    {
        public abstract int CalculateDamageReduction(int totalDamage);

        public static SpecialDefense Null { get; } = new NullDefense();

        private class NullDefense : SpecialDefense
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; // do nothing behavior
            }
        }
    }
}
