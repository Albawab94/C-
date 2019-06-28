using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Main_method
{
    class Programone
    {
        void NoStatic()
        {
            Console.WriteLine("This is the method NoStatic");
        }
          static void Main()
        {

            ProgramStruct prg = new ProgramStruct();
            prg.structMethod();

            Time now = new Time();
            now.GetHour(3);
            now.setHour();

            Auto auto; // ik heb geen (new Auto) gebruikt
            auto.name = "Nissan";
            Console.WriteLine( auto.name);

            Programone noStatic = new Programone();
            noStatic.NoStatic();
            Console.WriteLine("Hello method one");
        }
    }

    struct Time
    {
        private int hour, minute;
        public void GetHour(int h)
        {
            hour = h;
        }
        public int setHour()
        {
            Console.WriteLine(hour);
            return hour;
        }
    }

    struct Auto
    {
        public string name;
    }

    
}
