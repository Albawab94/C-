using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)

        {
            //This is the Abstractur class
            Abstraction1 abstraction = new Abstraction1();
            abstraction.Print();
            abstraction.Print2();

            // thid is the encapsulation

            Capsulation capsulation = new Capsulation();
            capsulation.setNumber(13);
            Console.WriteLine("this is the capsulation : "+capsulation.getNumber());

            // this is the static

           int staticMethod =   Static.staticMethod();
            Console.WriteLine("Thsi is the static metod : " + staticMethod);

            Static.staticEnDataMethod();





            List<Vervoersmiddel> vervoersmiddelen = new List<Vervoersmiddel>();

            vervoersmiddelen.Add(new Auto() { Kleur = "Paars" , Maxspeed =120 });
            vervoersmiddelen.Add(new Fiets() { Kleur = "Rood"});
            
            vervoersmiddelen.Add(new Fiets() { Maxspeed = 30 });

            foreach (Vervoersmiddel vm in vervoersmiddelen)
            {
                vm.Beweeg();
                Console.WriteLine(vm.Kleur);
                Console.WriteLine(vm.Maxspeed);
            }
        }
    }

    public class Vervoersmiddel
    {

        public Vervoersmiddel()
        {

        }

        public int Maxspeed { get; set; }
        public string Kleur { get; set; }

        public virtual void Beweeg()
        {

        }
    }


    public class Auto : Vervoersmiddel
    {
        public Auto()
        {
        }

        public override void Beweeg()
        {
            // base.Beweeg();
        }
    }

    public class Fiets : Vervoersmiddel
    {
        public Fiets()
        {

        }

        public override void Beweeg()
        {
            //base.Beweeg();
        }
    }
}
