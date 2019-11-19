using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Library
{
    public static class TargetExtensions
    {
        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();
        }
    }
}
