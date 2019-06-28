using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// this is the enumeration
        /// </summary>
        enum Auto { Opel, Nissan}
        static void Main(string[] args)
        {
            Auto auto = Auto.Opel;
            Console.WriteLine(auto);

            int intValue = 123;
            long longValue = intValue;
            Console.WriteLine("(long)" + intValue + longValue);

            long lValue = Int64.MaxValue;

            int iValue = (int)lValue;
            Console.WriteLine("(int)" + lValue+"===="+ iValue);

            Console.ReadKey();
        }
    }
}
