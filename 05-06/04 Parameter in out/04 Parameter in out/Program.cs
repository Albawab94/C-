using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Parameter_in_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 6;    
            Value(k);
            Console.WriteLine("This is a value method {0} ",k);
            refValue(ref k);
            Console.WriteLine("This is the ref Value {0} ", k);
            Console.ReadKey();
        }

        static void Value(int x)
        {
            x++;
        }

        static void refValue(ref int x)
        {
            x++;
        }
    }
}
