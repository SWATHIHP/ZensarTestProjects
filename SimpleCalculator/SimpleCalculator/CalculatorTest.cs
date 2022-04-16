using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleCalculator.Calculator;

namespace SimpleCalculator
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator calculator;

        [SetUp]
        public void Initialize()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AdditionTest()
        {
            int number1 = 10;
            int number2 = 20;

            Assert.That(number1 + number2, Is.EqualTo(calculator.Add(number1, number2)));

            //You can use Assert.AreEqual too to check above
            Assert.AreEqual(number1 + number2, calculator.Add(number1, number2));
        }

        [Test]
        public void SubtractionTest()
        {
            int number1 = 20;
            int number2 = 10;

            Assert.That(number1 - number2, Is.EqualTo(calculator.Subtraction(number1, number2)));

            //You can use Assert.AreEqual too to check above
            Assert.AreEqual(number1 - number2, calculator.Subtraction(number1, number2));
        }

        [Test]
        public void MultiplicationTest()
        {
            int number1 = 10;
            int number2 = 20;

            Assert.That(number1 * number2, Is.EqualTo(calculator.Multiply(number1, number2)));

            //You can use Assert.AreEqual too to check above
            Assert.AreEqual(number1 * number2, calculator.Multiply(number1, number2));
        }

        [Test]
        public void DivideTest()
        {
            int number1 = 20;
            int number2 = 5;

            Assert.That(number1 / number2, Is.EqualTo(calculator.Divide(number1, number2)));

            //You can use Assert.AreEqual too to check above
            Assert.AreEqual(number1 / number2, calculator.Divide(number1, number2));
        }

        [Test]
        public void DivideWithExceptionTest()
        {
            int number1 = 10;
            int number2 = 0;

            Assert.Throws<DivideByZeroException>(() => calculator.Divide(number1, number2));
        }

        [Test]
        public void DivideWithGreaterDenominatorTest()
        {
            int number1 = 10;
            int number2 = 20;

            Assert.Throws<DenominatorGreaterException>(() => calculator.Divide(number1, number2));
        }
    }
}
