using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        enum Manager { MANAGER1, MANAGER2, DIRECTOR, CEO }
        static void Main(string[] args)
        {
            //bool stuff;
            double Expenses = 0;
            String description = "";



            Console.WriteLine("Enter the expenses:");
            Expenses = Console.ReadLine(); 
            Console.WriteLine("Enter the description: ");
          description = Console.WriteLine();
            //stuff = isRejected(Expenses, description);

            if (isRejected(Expenses, description))
            {
                Console.WriteLine("Your request has been rejected.");
            }
            else
            {
                Console.WriteLine("Your request has not been rejected.");
            }


        }
        public static bool isRejected(double amount, string descr)
        {


            if (descr.Contains("entertainment"))
            {
                return true;


            }
            else if (descr.Contains("towncar"))
            {
                return true;
            }
            else if (descr.Contains("hardware") && amount > 5000)
            {
                return true;
            }


            else
                return false;

        }
        public static Manager isRejected(double amount, string descr)
        {


            if (descr.Contains("entertainment"))
            {

                return Manager.MANAGER1;


            }
            else if (descr.Contains("towncar"))
            {
                return Manager.MANAGER2;
            }
            else if (descr.Contains("hardware") && amount > 5000)
            {
                return Manager.DIRECTOR;
            }


            else
                return Manager.CEO;
        }


    }
}
