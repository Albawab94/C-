using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine(" The customer Account Type is {0} ", goldAccount);
            Console.WriteLine(" The customer Account Type is {0} ", platinumAccount);

            BankAccounte gold = new BankAccounte();
            gold.accType = AccountType.Deposit;
            gold.accBal = (decimal)3200.00;

            Console.Write("Enter The account number :");
            gold.AccNo = long.Parse(Console.ReadLine());

            Console.WriteLine("The Account No is : {0}", gold.AccNo);

            Accounttype accountType = Accounttype.Deposit;
            Console.WriteLine("accounttype = {0} {1}", (int)accountType, accountType);
            switch (accountType)
            {
                case Accounttype.Deposit:
                    
                    break;
                case Accounttype.Checking:
                    break;
            }

            Console.ReadKey();
        }
    }
}
