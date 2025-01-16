using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Customers._Extended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                    .Split()
                    .ToList();

            List<Customers> customers = new List<Customers>();

            while (input[0] != "end")
            {

                Customers customer = new Customers();
                customer.FirstName = input[0];
                customer.LastName = input[1];
                customer.Orders = input[2];
                customer.Status = input[3];

                customers.Add(customer);

                input = Console.ReadLine()
                    .Split()
                    .ToList();
            }

            string status = Console.ReadLine();

            foreach (Customers customer in customers)
            {
                if (customer.Status == status)
                {
                    Console.WriteLine($"{customer.FirstName} {customer.LastName} has {customer.Orders} orders.");
                }
            }
        }
    }

    public class Customers
    {
        public string FirstName;
        public string LastName;
        public string Orders;
        public string Status;
    }
}
