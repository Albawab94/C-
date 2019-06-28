using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     public abstract class Abstraction
    {
        public abstract void Print();
        public void Print2()
        {
            Console.WriteLine("Hallo print 2");
        }
        
    }

     class Abstraction1 : Abstraction
    {
        public override void Print()
        {
            Console.WriteLine("Hallo ");
        }
    }

    abstract class Abstraction2 : Abstraction
    {

    }
}
