using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingapp
{
    public class @interface : newcust
    {

        public void startapp()
        {


            var context = new dataEntities();
            var det = context.bankcustomerinfoes;
            var accno = context.bankcustomerinfoes.Find(130806064);
            //var accno2 = context.bankcustomerinfoes.Find(130806065);
            //var accno3 = context.bankcustomerinfoes.Find(130806066);

            string response;
            int cresponse;
            int dresponse;

            {



                Console.WriteLine("WELCOME TO ABABA BANKS");

                Console.WriteLine("PRESS 1  FOR NEW CUSTOMER");
                Console.WriteLine("PRESS 2 FOR EXISTING CUSTOMER");
                Console.WriteLine("PRESS 3 TO EXIT THE PROGRAM");

                int p = Convert.ToInt32(Console.ReadLine());
                while (p != 3)
                {
                    if (p == 1)
                    {
                        try
                        {
                            Console.WriteLine("PRESS 1 TO CREATE A SAVINGS ACCOUNT AND 2 FOR CURRENT ACCOUNT");

                            Console.WriteLine("PRESS 3 TO EXIT TAB");
                            response = Console.ReadLine();
                            cresponse = Convert.ToInt32(response);

                            {
                                if (cresponse == 1)

                                    Console.WriteLine();
                                Console.WriteLine("PLEASE CHOOSE YOUR CHOICE");
                                Console.WriteLine("ENTER 1 FOR DEPOSIT ");
                                Console.WriteLine("ENTER 2 FOR WITHDRAWAL");
                                Console.WriteLine("ENTER 3 TO VIEW CUSTOMER DETAILS");
                                Console.WriteLine("ENTER 4 TO  EXIT THE TAB");
                                string responset = Console.ReadLine();
                                dresponse = Convert.ToInt32(responset);

                                while (dresponse != 4)
                                {
                                    switch (dresponse)
                                    {
                                        case 1:


                                            break;
                                        case 2:

                                            break;
                                        case 3:
                                            break;

                                    }
                                }
                            }



                        }
                        catch (Exception) { }
                        Console.WriteLine("THANK YOU FOR BANKING WITH US TODAY");
                    }      }
               
       

                    if (p == 2)
                    {
                        Console.WriteLine("please enter your account number");
                        int ui = Convert.ToInt32((Console.ReadLine()));
                        accno = context.bankcustomerinfoes.Find(ui);
                        Console.WriteLine("PLEASE CHOOSE YOUR CHOICE");
                        Console.WriteLine("ENTER 1 FOR DEPOSIT ");
                        Console.WriteLine("ENTER 2 FOR WITHDRAWAL");
                        Console.WriteLine("ENTER 3 TO VIEW CUSTOMER DETAILS");
                        Console.WriteLine("ENTER 4 TO  EXIT THE TAB");

                        string responset = Console.ReadLine();
                        dresponse = Convert.ToInt32(responset);

                        
                            switch (dresponse)
                            {
                                case 1:
                                    decimal i = accno.accountbalance;
                                    i = (accno.accountbalance);
                                    deposit(i);
                                    accno.accountbalance = i;
                                    context.SaveChanges();

                                   break;


                                case 2:
                                     i = (decimal)(accno.accountbalance);
                                     decimal  i = (decimal)(accno.accountbalance);
                                    withdraw(i);
                                    context.SaveChanges();
                                    break;
                                

                            }


                        }

                    }

                }

            }
        }
    }
