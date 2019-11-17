using System;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace ExtensionMethods
{
    public static class ConfigurationExtensions
    {
        public static bool IsLoaded(this IConfiguration config)
        {
            return config != null && config.AsEnumerable().Any();
        }
    }
}
