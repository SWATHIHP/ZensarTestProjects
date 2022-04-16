using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialEg
{
   
    public class Factorial
    {
        public float GetFactorialOf(int p)
        {
            if (p < 2)
                return 1;
            return p * GetFactorialOf(p - 1);
        }
    }
}
