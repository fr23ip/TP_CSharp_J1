using TP_CSharp_J1;

class Program
{
    static void Main(string[] args)
    {
        // Creating new book
        Book myBook = new Book(
            bookId: 1,
            author: "J.R.R. Tolkien",
            name: "The Fellowship of the Ring",
            price: 17.99,
            rackNo: 12,
            status: "Available",
            edition: "2",
            dateOfPurchase: new DateTime(2023, 1, 10)
        );

        // Displaying current book details
        Console.WriteLine("Before status update:");
        myBook.displayBookDetails();

        // Updating the status to "Checked Out"
        myBook.updateStatus("Checked Out");
    }
}