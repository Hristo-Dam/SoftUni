using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StacionaryPhone : ICallOtherPhones
    {
        public void Call(string n)
        {
            Console.WriteLine("Dialing... " + n);
        }
        //public void Call(string[] numbersToCall)
        //{
        //    for (int i = 0; i < numbersToCall.Length; i++)
        //    {
        //        if (numbersToCall[i].All(char.IsDigit))
        //        {
        //            Console.WriteLine($"Dialing... {numbersToCall[i]}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invelid number!");
        //        }
        //    }
        //}
    }
}
