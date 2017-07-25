using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingapp
{
  public  class newcust
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string emailaddress { get; set; }
        public int accno { get; set; }
        public int accbal { get; set; }
        public DbSet<newcust> newCust { get; set; }
        
       

        
        
    }
}
