using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1_oop
{
    class Program
    {
        static BankAccount newBankAccount()
        {
            BankAccount created = new BankAccount();
            
            long number = BankAccount.NextNumber();
            //Console.WriteLine("Account number {0}", created.Number());
            Console.WriteLine("Account Balnce {0}", created.Balance());
            //created.accNo = 5;
            return created;

           
        }
        static void Main(string[] args)
        {
            newBankAccount();
        }
    }

    struct BankAccount
    {
        public void Populate(long number, decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
        }

        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        private long accNo;
        private decimal accBal;
        private static long nextAccNo;

        public static long NextNumber()
        {
            return nextAccNo++;
        }

    }
}
