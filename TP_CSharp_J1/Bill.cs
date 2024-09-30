using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class Bill
    {
        // Attributes
        public int billNo { get; set; }
        public DateTime date { get; set; }
        public int memberId { get; set; }
        public double amount { get; set; }

        // Constructor for Bill
        public Bill(int billNo, DateTime date, int memberId, double amount)
        {
            this.billNo = billNo;
            this.date = date;
            this.memberId = memberId;
            this.amount = amount;
        }

        // Methods
        public void billCreate()
        {
        }

        public void billUpdate()
        {

        }
    }
}
