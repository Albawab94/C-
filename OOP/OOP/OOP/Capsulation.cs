using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Capsulation
    {
        private float Number;
        public static int nummer { get; set; }
        public void setNumber(float num)
        {
            if (num > 10)
            {
                Number = num;
            }else
            {
                Number = -1;
            }
        }

        public float getNumber()
        {
            return Number;
        }
    }
}
