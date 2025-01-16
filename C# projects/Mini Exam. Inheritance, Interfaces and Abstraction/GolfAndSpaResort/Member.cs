using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfAndSpaResort
{
    public class Member : Customer
    {
        public int MembershipId { get; set; }

        public Member(string firstName, string lastName, int membershipId) : base(firstName, lastName)
        {
            MembershipId = membershipId;
        }

        public string GetMembershipId(string freeAccess)
        {
            string result = $"Member {this.FirstName} {this.LastName} with membership number {this.MembershipId} gets free access to the {freeAccess}.";
            return result;
        }
    }
}
