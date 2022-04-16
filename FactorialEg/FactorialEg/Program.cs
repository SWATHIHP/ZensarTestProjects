using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialEg
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial calculator = new Factorial();

            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(calculator.GetFactorialOf(i));
            }
        }
    }
}
