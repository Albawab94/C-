using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_return_value
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoPlusTwo();
        }

        static int TwoPlusTwo()
        {
            Int32 a, b;
            a = 2;
            b = 5;
            return a + b;
        }
    }
}
