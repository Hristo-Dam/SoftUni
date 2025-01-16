using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICallOtherPhones, IBrowse
    {
        public void Call(string n)
        {
            Console.WriteLine("Calling... " +  n);
        }
        public void Browse(string s)
        {
            Console.WriteLine("Browsing: " + s + "!");
        }

        //public void Call(string[] numbersToCall)
        //{
        //    for (int i = 0; i < numbersToCall.Length; i++)
        //    {
        //        if (numbersToCall[i].All(char.IsDigit))
        //        {
        //            Console.WriteLine($"Calling... {numbersToCall[i]}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invelid number!");
        //        }
        //    }
        //}
        //public void Browse(List<string> sitesToVisit)
        //{
        //    for (int i = 0; i < sitesToVisit.Count; i++)
        //    {
        //        if (sitesToVisit[i].Any(char.IsDigit))
        //        {
        //            Console.WriteLine("Invalid URL!");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Browsing: {sitesToVisit[i]}!");
        //        }
        //    }
        //}
    }
}
