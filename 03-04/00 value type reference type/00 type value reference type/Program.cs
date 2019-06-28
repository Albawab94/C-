using System;

namespace _00_type_value_reference_type
{
    class Program
    {
        public class A
        {
            public Int32 x;
        }
        static void Main(string[] args)
        {
           
            A a = new A();
            a.x = 10;

            Console.WriteLine("a.x " +a.x );

            A b = new A();
            b.x = 20;
            Console.WriteLine("b.x "+b.x );
            Console.WriteLine("a.x "+a.x );

            A c = a;
            c.x = 30;
            Console.WriteLine("c.x "+c.x);
            Console.WriteLine("a.x "+a.x);
            Console.WriteLine("b.x " + b.x);
            Console.WriteLine("a.x " + a.x);

            A d = new A();
            d.x = 50;
            Console.WriteLine("d.x "+d.x);
            Console.WriteLine("a.x " + a.x);

            Program2.a();
            Console.ReadKey();
        }
    }
    class Program2
    {

       public static void a()
        {

            Console.WriteLine("This is the value type");

            int x = 10;

            Console.WriteLine("a.x " + x);


            x = 20;
            Console.WriteLine("b.x " + x);
            Console.WriteLine("a.x " + x);


            x = 30;
            Console.WriteLine("c.x " + x);
            Console.WriteLine("a.x " + x);
            Console.WriteLine("b.x " + x);
            Console.WriteLine("a.x " + x);

            Console.ReadKey();
        }
    }

}
