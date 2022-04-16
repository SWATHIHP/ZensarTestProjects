using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    public class FibonacciSequenceTests
    {
        // 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144

        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        [TestCase(6, 13)]
        [TestCase(7, 21)]
        [TestCase(8, 34)]
        [TestCase(9, 55)]
        [TestCase(10, 89)]
        [TestCase(11, 144)]
        public void FibonacciSequence_Element_IsValue(int n, long expected)
        {
            var seq = new FibonacciSequence();
            var result = seq.ElementAt(n);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FibonacciSequence_DoesNotOverflowAtElement46()
        {
            var seq = new FibonacciSequence();
            var value46 = seq.ElementAt(45);
            var value47 = seq.ElementAt(46);
            Assert.Greater(value47, value46);
        }
    }
}
