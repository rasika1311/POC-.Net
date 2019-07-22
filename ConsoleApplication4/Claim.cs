using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
    public class Class1
    {
        static void Main(string[] args)
        {
            CSVReader cr = new CSVReader();
            Console.WriteLine("Calling read function from Main method...");
            cr.Read();
        }
    }
}
