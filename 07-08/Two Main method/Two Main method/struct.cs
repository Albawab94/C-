using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Main_method
{
    class ProgramStruct
    {
       public void structMethod()
        {

            myStatic my = new myStatic(10);
        }

    }


    class myStatic
    {

        public myStatic()
        {

        }

        public myStatic(int ID)
        {
            if (ID <= 0)
            {
                throw new ArgumentOutOfRangeException("id moet groeter dan 0 zijn");
            }
            else
            {
                Console.WriteLine("Hello " + ID);
            }


            this.ID = ID;
        }

        public int ID { get; private set; }


        static public int geefMeEengetal()
        {
            return 20;
        }

    }

}