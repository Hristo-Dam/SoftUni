using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            while (true)
            {
                List<string> list = Console.ReadLine()
                    .Split(", ")
                    .ToList();

                if (list[0] == "END")
                {
                    if (parkingLot.Count == 0)
                    {
                        Console.WriteLine("Parking Lot is Empty");
                    }
                    else
                    {
                        foreach(string car in parkingLot)
                        {
                            Console.WriteLine(car);
                        }
                    }
                    return;
                }
                else if (list[0] == "IN")
                {
                    string carNum = list[1];
                    parkingLot.Add(carNum);
                }
                else if (list[0] == "OUT")
                {
                    string carNum = list[1];
                    parkingLot.Remove(carNum);
                }
            }
        }
    }
}
