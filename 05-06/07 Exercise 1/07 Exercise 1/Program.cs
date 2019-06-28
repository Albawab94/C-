using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("add a number");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("add an another number");
            int y = Int32.Parse(Console.ReadLine());

            int greater = Utils.Greater(x, y);
            Console.WriteLine(greater);



            Utils.Swap(ref x, ref y);
            Console.WriteLine("The y is the two value {0} ",y);

            Console.WriteLine();
            Console.WriteLine("wij zijn bezig met bool");
            bool ok;
            int f;
            Console.Write("Add a number for bool test");
            int c = Int32.Parse(Console.ReadLine());
            ok = Utils.Factorial(c, out f);
            if (ok)
            {
                Console.WriteLine("Factorial  " + c + " = " + f);
            }
            else
            {
                Console.WriteLine("can not ");
            }


            Console.ReadKey();

            
        }
    }
}
