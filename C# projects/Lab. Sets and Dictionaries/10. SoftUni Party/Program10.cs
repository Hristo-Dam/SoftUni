using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> reserv = new HashSet<string>();
            HashSet<string> vipReserv = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                input = Console.ReadLine();
                if (input[0] >= 0 && input[0] <= 9)
                {
                    vipReserv.Add(input);
                }
                else if (input != "END" && input != "PARTY")
                {
                    reserv.Add(input);
                }
                else if (input == "PARTY")
                {
                    while (input != "END")
                    {
                        input = Console.ReadLine();

                        if (input[0] >= 0 && input[0] <= 9)
                        {
                            vipReserv.Remove(input);
                        }
                        else if (input[0] != 1)
                        {
                            reserv.Remove(input);
                        }
                        else if (input == "END")
                        {
                            Console.WriteLine(vipReserv.Count + reserv.Count);

                            foreach (string vipR in vipReserv)
                            {
                                Console.WriteLine(vipR);
                            }

                            foreach (string s in reserv)
                            {
                                Console.WriteLine(s);
                            }
                        }
                    }
                }
            }

            if (input == "END")
            {
                Console.WriteLine(vipReserv.Count + reserv.Count);

                foreach (string vipR in vipReserv)
                {
                    Console.WriteLine(vipR);
                }

                foreach (string s in reserv)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
