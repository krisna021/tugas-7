using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.cpp
{

    public class Canon : PrinterWindows
    {
        public override void ShowPrint()
        {
            Console.WriteLine("Canon display dimension  9.5 * 12");
            Console.WriteLine("Canon printer printing....");
        }
    }

}