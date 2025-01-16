using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Bank_Accounts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] command = Console.ReadLine().Split();
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

            while (command[0] != "End")
            {
                if (command[0] == "Create")
                {
                    int id = int.Parse(command[1]);

                    if (!accounts.ContainsKey(id))
                    {
                        BankAccount account = new BankAccount();
                        account.Id = id;
                        account.Balance = 0;

                        accounts[id] = account; // add the new accout to the dict
                    }
                    else
                    {
                        Console.WriteLine("Account already exists");
                    }
                }


                else if (command[0] == "Deposit")
                {
                    int id = int.Parse(command[1]);

                    if (accounts.ContainsKey(id))
                    {
                        double amount = double.Parse(command[2]);
                        accounts[id].Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }
                else if (command[0] == "Withdraw")
                {
                    int id = int.Parse(command[1]);
                    if (accounts.ContainsKey(id))
                    {
                        double amount = double.Parse(command[2]);
                        accounts[id].Withdraw(amount);
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }
                else if (command[0] == "Print")
                {
                    int id = int.Parse(command[1]);

                    if (accounts.ContainsKey(id))
                    {
                        BankAccount account = accounts[id];
                        Console.WriteLine($"Account ID {id}, balance {account.Balance:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }

                command = Console.ReadLine().Split();
            }
        }
    }

    class BankAccount
    {
        public int Id;
        public double Balance;

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= amount;
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
