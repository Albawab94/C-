using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Persoon
    {
        //lengte in centimeters
        int lengte; 

        // gewicht in kilo
        int gewicht;

        Geslacht geslacht = Geslacht.Onbekend;

         public Persoon()
        {
            SByte byteWaarde = 127;

            Int16 int16Waarde = 32767;
            int16Waarde = -32767;
            UInt16 uint16Waarde = 65535;
            //uint16Waarde = -32768;

            Int32 int32waarde = 2147483647;
                  int32waarde = -2147483647;
            UInt32 uInt32waarde = 4294967295;

            Int64 int64waarde = 9223372036854775807;
                  int64waarde = -9223372036854775808;
            UInt64 uInt64waarde = 18446744073709551615;

        }



        /*
        Int16;
        Int32;
        Int64
        double;
        float;
        decimal;
        bool;
        Boolean;
        int;
        Uint16;
        Uint32;
        Uint64;
        long;
        Byte;
        short;
        char;
        SByte;
        */













    }
}
