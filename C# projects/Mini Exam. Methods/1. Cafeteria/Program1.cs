using System;

namespace _1._Cafeteria
{
    internal class Program
    {
        static  double TypeOfProduct(string product, double productQuantity)
        {
            double productPrice = 0;

            if (product == "water")
            {
                productPrice = 1.00;
            }
            else if (product == "coke")
            {
                productPrice = 1.40;
            }
            else if (product == "coffee")
            {
                productPrice = 1.50;
            }
            else if (product == "snacks")
            {
                productPrice = 2.00;
            }

            double totalPrice = productPrice * productQuantity;

            return totalPrice;
        }

        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double productQuantity = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(TypeOfProduct(product, productQuantity)):F2}");
        }
    }
}
