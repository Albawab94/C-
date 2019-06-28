using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Overload_method
{
    class Program
    {
        static void Main(string[] args)
        {
           int sum1 = Add(1, 2);
            int sum2 = Add(1, 2, 3);

            Console.WriteLine(sum1 +" "+ sum2);
            Console.ReadKey();
        }

        static int Add(int a , int b)
        {
            return a + b;
        }

        static int Add( int a, int b , int c)
        {
            return a + b + c;
        }
    }
}
