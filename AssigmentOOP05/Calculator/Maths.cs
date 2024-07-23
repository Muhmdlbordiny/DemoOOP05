using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP05.Calculator
{
    internal class Maths : IMaths
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Dividing(int x, int y)
        {
            return x / y;
        }

        public int Multiply(int x, int y)
        {
            return x*y;
        }

        public int Sub(int x, int y)
        {
            return x - y ;
        }
    }
}
