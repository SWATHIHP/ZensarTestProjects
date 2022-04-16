using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralEg
{
    [TestFixture]
    public class RomanNumeralTests
    {
        [TestCase(1,"I")]
        [TestCase(5, "V")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanNumeral.Parse(roman));
        }
    }
}
