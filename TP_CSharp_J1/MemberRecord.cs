using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class MemberRecord
    {
        // Attributes
        public int memberId { get; set; }
        public string type { get; set; }
        public DateTime dateOfMembership { get; set; }
        public int noBookIssued { get; set; }
        public int maxBookLimit { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int phoneNo { get; set; }

        // Constructor for MemberRecord
    public MemberRecord(int memberId, string type, DateTime dateOfMembership, int noBookIssued, int maxBookLimit, string name, string address, int phoneNo)
    {
        this.memberId = memberId;
        this.type = type;
        this.dateOfMembership = dateOfMembership;
        this.noBookIssued = noBookIssued;
        this.maxBookLimit = maxBookLimit;
        this.name = name;
        this.address = address;
        this.phoneNo = phoneNo;
    }

        // Methodes
        public void retrieveMember()
        {

        }
        public void increaseBookIssued()
        {

        }

        public void decreaseBookIssued()
        {

        }

        public void payBill()
        {

        }
    }
}
