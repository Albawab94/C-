using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_params
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = AddList(63, 21, 84);
            Console.WriteLine(x);
            Console.ReadKey();
        }

        static long AddList(params long[] v)
        {
            long total = 0,
                i;
            for (i = 0; i < v.Length; i++)
                total += v[i];
            return total;
        }

    }
}
