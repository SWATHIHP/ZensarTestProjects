using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Calculator
    {
        private int result;

        public int Add(int num1, int num2)
        {
            this.result = num1 + num2; //Logic to do addition
            return this.result;
        }

        public int Subtraction(int num1, int num2)
        {
            this.result = num1 - num2; //Logic to do subtraction
            return this.result;
        }

        public int Multiply(int num1, int num2)
        {
            this.result = num1 * num2; //Logic to do multiply
            return this.result;
        }

        public int Divide(int num1, int num2)
        {
            if (num2 > num1)
                throw new DenominatorGreaterException();

            this.result = num1 / num2; //Logic to do division
            return this.result;
        }
        public class DenominatorGreaterException : ApplicationException
        {

        }
    }
}

