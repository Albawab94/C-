using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public struct BankAccounte
    {
        private long accNo;
        public decimal accBal;
        public AccountType accType;


        public long AccNo
        {
            get {
                return this.accNo;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Waarde mag niet lager zijn dan 0");
                }

                this.accNo = value;
            }
        }
    }
}
