using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfFood = int.Parse(Console.ReadLine());
            List<int> listOfOrders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> ordersLeft = new List<int>();

            Queue<int> queueOfOrders = new Queue<int>(listOfOrders);

            int biggestOrder = 0;

            for (int i = 0; i < listOfOrders.Count; i++)
            {
                int currentOrder = queueOfOrders.Peek();

                if (currentOrder > biggestOrder)
                {
                    biggestOrder = currentOrder;
                }

                if (currentOrder <= amountOfFood)
                {
                    amountOfFood -= currentOrder;
                    queueOfOrders.Dequeue();
                }
                else if (currentOrder > amountOfFood)
                {
                    int numberOfOrdersLeft = queueOfOrders.Count;
                    for (int k = 0; k < numberOfOrdersLeft; k++)
                    {
                        ordersLeft.Add(queueOfOrders.Dequeue());
                    }
                    Console.WriteLine(biggestOrder);
                    Console.WriteLine($"Orders left: {string.Join(" ", ordersLeft)}");
                    return;
                }
            }
            Console.WriteLine(biggestOrder);
            Console.WriteLine("All orders are completed");
        }
    }
}
