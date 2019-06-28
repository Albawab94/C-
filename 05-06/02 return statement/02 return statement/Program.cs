using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_return_statement
{
    class Program
    {
       static Int32 ncount;
        static void Main(string[] args)
        {
            Int32 num = 0;
            Console.WriteLine("Hello");
            Console.ReadKey();
            if (num > 10)
                return;
            Console.WriteLine("World");
            Init();
            CountCall();
            CountCall();
            CountCall();
            CountCall();
            newValue();
            CountCall();
            CountCall();
            newValue();
            Console.ReadKey();
        }

        static void Init()
        {
             ncount =0;
            Console.WriteLine(ncount);
        }
        static void CountCall()
        {       
            ncount++;
            Console.WriteLine("Hello {0}" , ncount);
        }

        static void newValue()
        {
            Console.WriteLine(ncount);
        }
    }
}
