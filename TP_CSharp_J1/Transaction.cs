using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class Transaction
    {
        public int transId {  get; set; }
        public int memberId { get; set; }
        public int bookId { get; set; }
        public DateOnly dateOfIssue { get; set; }
        public DateOnly dueDate { get; set; }

        public void createTransation()
        {

        }

        public void deleteTransaction()
        {

        }

        public void retrieveTransaction()
        {

        }
    }
}
