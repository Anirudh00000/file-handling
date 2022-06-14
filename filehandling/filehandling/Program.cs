
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using filehandling;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Billing_and_InventorySystem performfilehandling = new Billing_and_InventorySystem();
            /* Console.WriteLine("Enter the User DETAILS ....");
            performfilehandling.User_Module();
            Console.WriteLine("************************************************");
            Console.WriteLine();

            Console.WriteLine("Enter the Category DETAILS ....");
            performfilehandling.Category_Module();
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine("Enter the Product DETAILS ....");
            performfilehandling.Product_Module();
            Console.WriteLine("************************************************");

            Console.WriteLine();
            Console.WriteLine("Enter the PURCHASE AND Sales DETAILS ....");
            performfilehandling.Purchase_and_Sales_Module();
            Console.WriteLine("Please Enter Any key to Quit This Window");*/

            performfilehandling.ReadFile();


            Console.ReadKey();
        }
    }
}