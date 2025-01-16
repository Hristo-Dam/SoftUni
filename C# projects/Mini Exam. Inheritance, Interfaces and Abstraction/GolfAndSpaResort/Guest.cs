using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfAndSpaResort
{
    public class Guest : Customer
    {
        public Guest(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public string NewGuest()
        {
            string result = $"Mr/Ms/Mrs {this.FirstName} {this.LastName} registers as a guest.";
            return result;
        }
    }
}
