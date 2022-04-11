using System;
using System.Collections.Generic;
using System.Text;
namespace MyDatabase
{
    class program
    {
        static void Main(string[] args)
        {
            MyDB.showCustomer();
           // MyDB.changeCustomerName();
            //MyDB.changeCustomerID();
           // MyDB.showCustomer();
        }
    }
    class MyDB
    {
        static int customerID = 100;
        static string strName = "Mr. Panom";
        static string address = "999, 543Rd.";

        public static void showCustomer()
        {
            Console.WriteLine("Customer ID is {0}", customerID);
            Console.WriteLine("Customer name is {0}", strName);
            Console.WriteLine("Customer address is {0}", address);

        }
       // public static void changeCustomerName()
       // {
           // Console.Write("Please Enter new Customer Name:");
           // strName = Console.ReadLine();
       // }

        public static void changeCustomerID()
        {
            Console.Write("Please Enter new Customer ID:");
            customerID = int.Parse(Console.ReadLine());
        }
        

    }
}