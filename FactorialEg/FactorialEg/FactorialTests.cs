using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialEg
{
    public class FactorialTests
    {
        [Test]
        public void ZeroFactorialIsOne()
        {
            Factorial calculator = new Factorial();
            float result = calculator.GetFactorialOf(0);

            Assert.AreEqual(1, result);
        }
        [Test]
        public void OneFactorialIsOne()
        {
            Factorial calculator = new Factorial();
            float result = calculator.GetFactorialOf(1);

            Assert.AreEqual(1, result);
        }
        [Test]
        public void TwoFactorialIsTwo()
        {
            Factorial calculator = new Factorial();
            float result = calculator.GetFactorialOf(2);

            Assert.AreEqual(2, result);
        }
        [Test]
        public void ThreeFactorialIsSix()
        {
            Factorial calculator = new Factorial();
            float result = calculator.GetFactorialOf(3);

            Assert.AreEqual(6, result);
        }
    }
}
