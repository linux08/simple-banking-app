using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingapp
{
    class saccount:account
    {
        public void addinterest()
        {
            balance += balance * (decimal)0.25;
            Console.WriteLine("your balance after deposit is " + balance);
        }
        public override void deposit( decimal balance)
        {
            Console.WriteLine("please enter the amount you would like to deposit");
            decimal amount = Convert.ToInt32(Console.ReadLine());

            balance = amount + balance;
         
            Console.WriteLine("your balance after depositing  is " + balance);
        }
        public override void withdraw(decimal balance)
        {
            Console.WriteLine("please enter the amount you would like to deposit");
            decimal amount = Convert.ToInt32(Console.ReadLine());

            if (amount < balance)
            {
                balance -= amount;
                Console.WriteLine("your balance after withdrawing is " + balance);
            }
            else
                throw new Exception("cannot withdraw");
        }
        private decimal calcyearlyinterest(decimal balance)
        {
            decimal j = (balance * (decimal)0.25) / 12;
            return (j + balance);
        }
        private decimal calcmonthinterest(decimal balance)
        {
            decimal j = (balance * (decimal)0.25);
            return (j + balance);
        }
    }
}
