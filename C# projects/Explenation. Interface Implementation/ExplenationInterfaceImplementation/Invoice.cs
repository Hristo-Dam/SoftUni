using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplenationInterfaceImplementation
{
    public class Invoice : IPrintable
    {
        //Inplicit implementation
        public void Print()
        {
            Console.WriteLine("printed");
        }
        //-----------------------


        //Explicit implementation
        void IPrintable.PrintText()
        {
            Console.WriteLine("text printed");
        }
        //------------------------
    }
}
