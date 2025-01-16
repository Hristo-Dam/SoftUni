using System.ComponentModel;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> numbersToCall = new List<string>();
            List<string> numbersToDial = new List<string>();
            List<string> sitesToVisit = new List<string>();

            Smartphone smartphone = new Smartphone();
            StacionaryPhone stacionaryPhone = new StacionaryPhone();

            string[] numbers = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string[] websites = Console.ReadLine()
                .Split(" ")
                .ToArray();

            foreach(string n in numbers)
            {
                if(n.All(char.IsDigit) && n.Length == 10)
                {
                    smartphone.Call(n);
                }
                else if(n.All(char.IsDigit) && n.Length == 7)
                {
                    stacionaryPhone.Call(n);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach(string s in websites)
            {
                if (!s.Any(char.IsDigit))
                {
                    smartphone.Browse(s);
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }
    }
}
