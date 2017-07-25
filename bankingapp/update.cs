using bankingapp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingapp
{
   public class update
    {
        public void adduser(string name) {
            using (dataEntities context = new dataEntities())
            {

             newcust du = new newcust();
             du.firstname = Console.ReadLine();
             du.lastname = Console.ReadLine();
             du.sex = Console.ReadLine();
             du.emailaddress = Console.ReadLine();
             du.accbal = Convert.ToInt32(Console.ReadLine());
             du.accno = Convert.ToInt32(Console.ReadLine());
             du.age = Convert.ToInt32(Console.ReadLine());
              
            }) ;
        }

    }
}
