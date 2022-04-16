using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeConvertEg
{
    [TestFixture]
    public class DegreeConverTests
    {
        [Test]
        public void ToFahrenheit_ZeroClecius_Returns32()
        {
            var converter = new DegreeConvert();
            double result = converter.ToFahrenheit(0);

            Assert.That(result, Is.EqualTo(32));
        }
        [Test]
        public void ToCelsius_1Fahrenheit_Returns0()
        {
            var converter = new DegreeConvert();
            double result = converter.ToCelsius(1);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
