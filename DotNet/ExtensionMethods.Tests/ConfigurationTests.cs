using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using ExtensionMethods;

namespace ExtensionMethods.Tests
{
    class ConfigurationTests
    {
        [Test]
        public void IsLoaded()
        {
            IConfiguration config = null;
            Assert.IsFalse(config.IsLoaded());
        }
    }
}
