using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Tests
{
    public class StringExtension : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
