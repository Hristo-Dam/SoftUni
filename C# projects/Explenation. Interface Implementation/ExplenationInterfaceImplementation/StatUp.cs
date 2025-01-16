using Microsoft.VisualBasic;
using System;
using System.Net.NetworkInformation;

namespace ExplenationInterfaceImplementation
{
    internal class StatUp
    {
        static void Main(string[] args)
        {
            Invoice class1 = new Invoice(); //"Invoice" type object
            IPrintable Iclass1 = new Invoice(); //IPrintable restriced "Invoice" type object
                                                //(Invoice object that can use only the methods from the IPrintable interface)

            //INPLICITLY-----

            //The mothod takes only "Invoice" type objects.
            PrintMethod(class1); //Takes "Invoice" type object
            //PrintMethod(Iclass1); //Can't take "IPrintable Invoice" type object.


            //The mothod takes any object that has the IPrintable interface.
            PrintMethodI(class1); //Takes "Invoice" type object.
            PrintMethodI(Iclass1); //Takes "IPrintable Invoice" type object.

            //-------------



            //EXPLICITLY-----

            //PrintTextMethod(class1);
            //PrintTextMethod(Iclass1);

            //The mothod takes any object that has the IPrintable interface.
            PrintTextMethodI(class1); //Takes "Invoice" type object.
            PrintTextMethodI(Iclass1); //Takes "IPrintable Invoice" type object.

            //---------------
        }

        //INPLICITLY-----

        //The mothod takes only "Invoice" type objects.
        public static void PrintMethod(Invoice obj) //Takes only a "Invoice" type object
        {
            obj.Print();
        }

        //The mothod takes any object that has the IPrintable interface.
        public static void PrintMethodI(IPrintable obj)
        {
            obj.Print();
        }
        //--------------



        //EXPLICITLY-----

        //Explicit implementation DOES NOT allow to create method which takes an object directly.
        //public static void PrintTextMethod(Invoice obj) //Explicit methods can't take objects that are not restricted to their methods
        //{
        //    obj.PrintText();
        //}

        //The mothod takes any object that has the IPrintable interface.
        public static void PrintTextMethodI(IPrintable obj)
        {
            obj.PrintText();
        }
        //--------------
    }
}