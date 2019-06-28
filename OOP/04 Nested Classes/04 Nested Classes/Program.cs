using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nested_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee = new Employees();
            employee.print();

            Employees.Department department = new Employees.Department();
            department.print();
        }
    }
}
