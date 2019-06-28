using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{


    class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                int num;
                Console.Write("Pleas add your number : ");
                string tempo = Console.ReadLine();
                int i = Int32.Parse(tempo);

                Console.Write("Pleas add your number : ");
                tempo = Console.ReadLine();
                int j = Int32.Parse(tempo);

                int divide = i / j;
                Console.WriteLine(divide);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Here is een fout;");
                Console.ReadKey();
            }
        }
    }
    class Hello
    {
        static void h(string[] args)
        {
            try
            {
                int num;
                Console.Write("Pleas add your number : ");
                string tempo = Console.ReadLine();
                int i = Int32.Parse(tempo);

                Console.Write("Pleas add your number : ");
                tempo = Console.ReadLine();
                int j = Int32.Parse(tempo);

                int divide = i / j;
                Console.WriteLine(divide);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Here is een fout;");
                Console.ReadKey();
            }
        }

    }
}

namespace Abdul
{
    class A
    {
        static void Alepo()
        {
            Console.WriteLine("Hello");
        }
    }
}
