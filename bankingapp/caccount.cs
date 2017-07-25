using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingapp
{
      public class caccount:account
    {
        public decimal commision;
        public override void withdraw(decimal balance)
        {
            Console.WriteLine("please enter the amount you would like to deposit");
            decimal amount = Convert.ToInt32(Console.ReadLine());

            balance -= amount;
            if (amount < balance)
                commision = -(decimal)0.25;
            Console.WriteLine("your balance after withdrawing is " + balance);
        }
        public override void deposit(decimal balance)
        {
            Console.WriteLine("please enter the amount you would like to deposit");
            decimal amount = Convert.ToInt32(Console.ReadLine());
            balance = amount + balance;
            Console.WriteLine("your balance after depositing  is " + balance);
        }
    }
}
