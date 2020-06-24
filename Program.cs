﻿using System;

namespace Polymorphism.cpp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;
            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Cannon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();


            printer.ShowPrint();

            Console.ReadKey();
        }
    }
}