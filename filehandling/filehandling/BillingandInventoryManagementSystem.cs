using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    public class Billing_and_InventorySystem
    {
        /*  public void User_Module()
          {
              FileStream fst = new FileStream(@"C:\Users\ANI\OneDrive\Desktop\Billing and Inventory Management System\user.txt", FileMode.Append, FileAccess.Write);
              StreamWriter sw = new StreamWriter(fst);
              Console.Write("Enter the UserId: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the Firstname: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the Lastname: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the Email address: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the Phone number: ");
              sw.Write(Console.ReadLine());
              sw.WriteLine("");
              sw.Close();
              fst.Close();
          }
          public void Category_Module()
          {
              FileStream fst = new FileStream(@"C:\Users\ANI\OneDrive\Desktop\Billing and Inventory Management System\category.txt", FileMode.Append, FileAccess.Write);
              StreamWriter sw = new StreamWriter(fst);
              Console.Write("Enter the CategoryId: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the CategoryType: ");
              sw.Write(Console.ReadLine());

              sw.WriteLine("");
              sw.Close();
              fst.Close();
          }
          public void Product_Module()
          {

              FileStream fst = new FileStream(@"C:\Users\ANI\OneDrive\Desktop\Billing and Inventory Management System\Product.txt", FileMode.Append, FileAccess.Write);
              StreamWriter sw = new StreamWriter(fst);
              Console.Write("Enter the Productid: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the categorytype: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the productname: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the quantity: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the price: ");
              sw.Write(Console.ReadLine());
              sw.WriteLine("");
              sw.Close();
              fst.Close();

          }
          public void Purchase_and_Sales_Module()
          {


              FileStream fst = new FileStream(@"C:\Users\ANI\OneDrive\Desktop\Billing and Inventory Management System\purchase.txt", FileMode.Append, FileAccess.Write);
              StreamWriter sw = new StreamWriter(fst);
              Console.Write("Enter the SalesId: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the Productid: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the price: ");
              sw.Write(Console.ReadLine());
              sw.Write(',');

              Console.Write("Enter the salesdate: ");
              sw.Write(Console.ReadLine());



              sw.WriteLine("");
              sw.Close();
              fst.Close();


          }
      }
  }
        */
        /*  public void ReadFile()
          {



              FileStream fileStreamObj = new FileStream(@"C:\Users\ANI\OneDrive\Desktop\New folder\string.txt", FileMode.Open, FileAccess.Read);
              StreamReader streamReaderObj = new StreamReader(fileStreamObj);
              //streamReaderObj.ReadLine();
              Console.WriteLine("Id" + "\t" + "Source" + "\t\t" + "Destination" + "\t" + "Date\t\t" + "Time\t\t" + "Status" + "\t" + "Network");
              while (streamReaderObj.Peek() >0)
              {
                  string line = streamReaderObj.ReadLine(); //studid
                  if (line != "")
                  {
                      string[] myStrs = line.Split(':');
                      if (myStrs[0] == "Date")
                      {

                          string[] dateTime = myStrs[1].Split(' ');
                          Console.Write(dateTime[0] + "\t" + dateTime[1] + ":" + myStrs[2] + ":" + myStrs[3] + "\t");

                      }
                      else
                      {
                          Console.Write(myStrs[1] + "\t");
                      }
                  }
                  else
                  {
                      Console.WriteLine();
                  }

              }

              Console.WriteLine("\n"+"Read operation completed");

          }
      }
  }*/
        public void ReadFile()
        {



            FileStream fileStreamObj = new FileStream(@"C:\Users\ANI\OneDrive\Desktop\New folder\string.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
