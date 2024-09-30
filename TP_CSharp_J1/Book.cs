using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class Book
    {
        //Attributes
        public int bookId { get; set; }
        public string author { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int rackNo { get; set; }
        public string status { get; set; }
        public string edition { get; set; }
        public DateTime dateOfPurchase { get; set; }


        // Constructor for Book
        public Book(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurchase)
        {
            this.bookId = bookId;
            this.author = author;
            this.name = name;
            this.price = price;
            this.rackNo = rackNo;
            this.status = status;
            this.edition = edition;
            this.dateOfPurchase = dateOfPurchase;
        }


        // Method to display book details
        public void displayBookDetails()
        {
            Console.WriteLine("Book ID: " + bookId);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: €" + price);
            Console.WriteLine("Rack Number :" + rackNo);
            Console.WriteLine("Book Status: " + status);
            Console.WriteLine("Book edition: " + edition);
            Console.WriteLine("Date of purchase: " + dateOfPurchase.ToShortDateString());

        }

        // Method to update the status of a book
        public void updateStatus(string newStatus)
        {
            this.status = newStatus;
            Console.WriteLine("Book status updated to: " + this.status);
        }
    }
}

