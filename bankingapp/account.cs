using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingapp
{
   public  class account
    { 
        public decimal amount;
       
        public decimal balance;
        public virtual decimal balancee
        {
            get { return balance; }
        }
        public virtual decimal amounts
        {
            get { return amount; }
        }
        public virtual void deposit( decimal balance)
        {
            Console.WriteLine("please enter the amount you would like to deposit");
            decimal  amount =Convert.ToInt32( Console.ReadLine());
            balance = amount + balance;
            Console.WriteLine("your balance after depositing  is " + balance);
        }
        public virtual void withdraw(decimal balance)

        {
            Console.WriteLine("please enter the amount you would like to deposit");
            decimal amount = Convert.ToInt32(Console.ReadLine());
            balance -= amount;
            Console.WriteLine("your balance after withdrawing is " + balance);
        }
        
        public bool create(newcust newCust)
        {

            using (var contex = new dataEntities())
            {
                newCust = new  newcust{
            firstname=Console.ReadLine(),
            lastname = Console.ReadLine(),
            sex=Console.ReadLine(),
            emailaddress=Console.ReadLine(),
            accbal= Convert.ToInt32(Console.ReadLine()),
            accno=Convert.ToInt32(Console.ReadLine()),
            age=Convert.ToInt32(Console.ReadLine()), } ;
              
               
            contex.Add(){ };
            return contex.SaveChanges() > 3;

            }
        }
        public void iu(dataEntities context) {
            var newCust = new List<newcust>
        {
            new  newcust{
            firstname=Console.ReadLine(),
            lastname = Console.ReadLine(),
            sex=Console.ReadLine(),
            emailaddress=Console.ReadLine(),
            accbal= Convert.ToInt32(Console.ReadLine()),
            accno=Convert.ToInt32(Console.ReadLine()),
            age=Convert.ToInt32(Console.ReadLine()), } };

            newCust.ForEach(category => context.Entry.(category));

        }
        }
        
            
    }

}
