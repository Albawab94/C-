using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP
{
    class Person
    {
        private string name;
        private int age;
        public void Print()
        {
            Console.WriteLine($"Name = {name} Age = {age}");
        }

        // constructor
        public Person()
        {

        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        // setters and getter method
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return this.age;
        }
    }
}
