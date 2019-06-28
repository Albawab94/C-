using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statment_and_Iteration_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hallo";
            bool boo = false;

            if (boo)
            {
                 boo = true;
            }
            else{
                text = "dag";   
            }
            Console.WriteLine(text);

            int i = 0;
            int li = 1;
            do {
                li += li;
                i++;
            }while (i < 10);

            Console.WriteLine("This is the while and do : {0}", i);
            Console.WriteLine("This is the while and do  : {0}", li);


            for(int m = 0; m < 10; m++)
            {
                boo = !boo;
                Console.WriteLine(boo);
            }

            Console.ReadKey();

        }
    }
}
