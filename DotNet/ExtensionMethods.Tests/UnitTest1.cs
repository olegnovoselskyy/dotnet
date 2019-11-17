using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods.Tests
{
    public class Tests
    {
        IEnumerable<string> _strings;
        [SetUp]
        public void Setup()
        {
            _strings = new List<string> { "a", "b", "c" };
        }

        [Test]
        public void Count()
        {
            Assert.AreEqual(3, _strings.Count());

            var stringExt = new StringExtension();
            Assert.AreEqual(0, stringExt.Count());
        }
    }
}