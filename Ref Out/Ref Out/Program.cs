using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    class Program
    {
       static void Main(string[] args)
        {
            int i;
            int m = 5 ;
            RefOut(out i);
            Console.WriteLine("this is the out "+i);

            Ref(ref m);
            Console.WriteLine("This is the Ref " + m);
            Console.ReadKey();
        }

        public static void RefOut(out int ut)
        {
            ut = 5;
        }

        public static void Ref(ref int i)
        {
            i += 5;
        }
    }
}
