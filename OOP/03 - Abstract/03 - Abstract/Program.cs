using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Managers managers = new Managers();
            HR hR = new HR();
            managers.PrintName();

            hR.department = "Dep HR";
            hR.PrintDepart();
        }
    }
}
