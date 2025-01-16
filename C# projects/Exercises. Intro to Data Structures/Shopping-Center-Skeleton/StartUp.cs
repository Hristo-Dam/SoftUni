using System;
using System.Collections.Generic;

namespace Shopping_Center
{
    public class StartUp
    {
        private static readonly ProductList ProductList = new ProductList();

        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var command = Console.ReadLine();
                ProcessCommand(command);
            }
        }

        private static void ProcessCommand(string input)
        {
            input = input.Trim();

            var index = input.IndexOf(' ');
            var command = input.Substring(0, index);

            input = input.Substring(index + 1);

            var args = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string result;

            switch (command)
            {
                case "AddProduct":
                    result = AddProduct(args);
                    break;
                case "DeleteProducts":
                    result = DeleteProducts(args);
                    break;
                case "FindProductsByName":
                    result = FindProductsByName(args);
                    break;
                case "FindProductsByProducer":
                    result = FindProductsByProducer(args);
                    break;
                case "FindProductsByPriceRange":
                    result = FindProductsByPriceRange(args);
                    break;
                default:
                    result = "Invalid Command";
                    break;
            }

            Console.WriteLine(result);
        }

        private static string FindProductsByPriceRange(string[] args)
        {
            //TODO: implement using ProductList methods
            string name = args[0];
            decimal price = decimal.Parse(args[1]);
            string producer = args[2];
            ProductList.FindProductsByPriceRange();
            return null;
        }

        private static string FindProductsByProducer(string[] args)
        {
            //TODO: implement using ProductList methods
            return null;
        }

        private static string FindProductsByName(string[] args)
        {
            //TODO: implement using ProductList methods
            return null;
        }

        private static string ConcatenateProducts(IEnumerable<Product> products)
        {
            //TODO: implement using ProductList methods
            return null;
        }

        private static string DeleteProducts(string[] args)
        {
            //TODO: implement using ProductList methods

            string name = args[0];
            decimal price = decimal.Parse(args[1]);
            string producer = args[2];
            
            return null;
        }

        private static string AddProduct(string[] args)
        {
            //TODO: implement using ProductList methods
            string name = args[0];
            decimal price = decimal.Parse(args[1]);
            string producer = args[2];
            ProductList.AddProduct(name, price, producer);
            return "Product added";
        }
    }
}
