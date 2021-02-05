using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    using WebService;
    class Program
    {
        static void Main(string[] args)
        {
            // Letters_Binding ws = new Letters_Binding();
            SalesOrder_Binding ws = new SalesOrder_Binding();
            SalesOrder nso = new SalesOrder();
            ws.UseDefaultCredentials = true;
            ws.Url = "http://localhost:7647/DynamicsNAV110/WS/CRONUS%20USA%2C%20Inc./Page/SalesOrder";
            
            // Sets Sell-to Customer
            nso.Sell_to_Customer_No = "10000";
            ws.Create(ref nso);
            string outputstring;

            // Calls the Microsoft Dynamics NAV codeunit web service.  
            outputstring = nso.No + ' ' + nso.Sell_to_Customer_Name + ' ' + nso.Sell_to_Contact;
            // ws.Capitalize(inputstring);

            // Writes output to the screen.  
            Console.WriteLine("Result: {0}", outputstring);
            nso.Ship_to_Contact = "Avery Genosi";
            ws.Update(ref nso);

            string outputstring2;

            // Calls the Microsoft Dynamics NAV codeunit web service.  
            outputstring2 = nso.No + ' ' + nso.Sell_to_Customer_Name + ' ' + nso.Ship_to_Contact;
                // ws.Capitalize(inputstring);

            // Writes output to the screen.  
            Console.WriteLine("Result: {0}", outputstring2);

            // Keeps the console window open until you press ENTER.  
            Console.ReadLine();
        }
    }
}
