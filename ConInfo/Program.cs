using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConInfo
{
    class Program
    {

        public static string sProdName = "Widget";
        public static int iUnitQty = 100;
        public static double dUnitCost = 1.03;

        static void Main(string[] args)
        {


            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
            Debug.Listeners.Add(tr1);

            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));
            Debug.Listeners.Add(tr2);

            Debug.Indent();
            Debug.WriteLine("Debug Information-Product Starting");
            Debug.WriteLine("The product name is " + sProdName);
            Debug.WriteLine("The available units on hand are " + iUnitQty.ToString());
            Debug.WriteLine("The per unit cost is " + dUnitCost.ToString());

            System.Xml.XmlDocument oxml = new System.Xml.XmlDocument();
            Debug.WriteLine(oxml);

            Debug.WriteLine("The product name is " + sProdName, "Field");
            Debug.WriteLine("The units on hand are " + iUnitQty, "Field");
            Debug.WriteLine("The per unit cost is " + dUnitCost.ToString(), "Field");
            Debug.WriteLine("Total Cost is " + (iUnitQty * dUnitCost), "Calc");

            Debug.WriteLineIf(iUnitQty > 50, "This message will appear");
            Debug.WriteLineIf(iUnitQty < 50, "This message will NOT appear");

            Debug.Assert(dUnitCost > 1, "Message will NOT appear");

            //Inactive because it will fail the app
            Debug.Assert(dUnitCost < 1, "Message will appear since dUnitCost < 1 is False");

            Debug.Unindent();
            Debug.WriteLine("Debug Information-Product Ending");

            Debug.Flush();






        }
    }
}
