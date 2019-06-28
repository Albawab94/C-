using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Array_as_Parameter
{
    class Program
    {
        static void Main()
        {
            int[] par = new int[] { 2,5,6,8};
            Method(par);
        }

        static void Method(int[] argument)
        {
            argument[0]++;
            Console.WriteLine(argument[3]);
        }
    }
}
