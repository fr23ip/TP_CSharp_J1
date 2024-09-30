using TP_CSharp_J1;

class Program
{
    static void Main(string[] args)
    {
        //// Creating new book
        //Book myBook = new Book(
        //    bookId: 1,
        //    author: "J.R.R. Tolkien",
        //    name: "The Fellowship of the Ring",
        //    price: 17.99,
        //    rackNo: 12,
        //    status: "Available",
        //    edition: "2",
        //    dateOfPurchase: new DateTime(2023, 1, 10)
        //);

        //// Displaying current book details
        //Console.WriteLine("Before status update:");
        //myBook.displayBookDetails();

        //// Updating the status to "Checked Out"
        //myBook.updateStatus("Checked Out");

        List<Book> books = new List<Book>
        {
            new Book(1, "J.R.R. Tolkien", "The Fellowship of the Ring", 17.99, 12, "Available", "2nd", new DateTime(2023, 1, 10)),
            new Book(2, "George Orwell", "1984", 15.50, 8, "Available", "1st", new DateTime(2023, 2, 15)),
            new Book(3, "Harper Lee", "To Kill a Mockingbird", 14.99, 5, "Available", "3rd", new DateTime(2023, 3, 20)),
            new Book(4, "F. Scott Fitzgerald", "The Great Gatsby", 13.45, 3, "Available", "4th", new DateTime(2023, 4, 25)),
            new Book(5, "Jane Austen", "Pride and Prejudice", 12.99, 1, "Available", "5th", new DateTime(2023, 5, 30)),
            new Book(6, "Mark Twain", "The Adventures of Tom Sawyer", 11.99, 10, "Available", "1st", new DateTime(2023, 6, 15)),
            new Book(7, "J.K. Rowling", "Harry Potter and the Sorcerer's Stone", 19.99, 7, "Available", "1st", new DateTime(2023, 7, 1)),
            new Book(8, "Stephen King", "The Shining", 22.50, 2, "Available", "1st", new DateTime(2023, 8, 5)),
            new Book(9, "G. R. R. Martin", "A Game of Thrones", 25.00, 4, "Available", "1st", new DateTime(2023, 9, 10)),
            new Book(10, "Agatha Christie", "Murder on the Orient Express", 10.99, 9, "Available", "1st", new DateTime(2023, 10, 12))
        };

        // Displaying all books
        Console.WriteLine("List of Books:");
        foreach (Book book in books)
        {
            book.displayBookDetails();
        }

        List<MemberRecord> members = new List<MemberRecord>
        {
            new MemberRecord(1, "Regular", new DateTime(2022, 5, 20), 2, 5, "Alice Johnson", "123 Main St", 0695846252),
            new MemberRecord(2, "Premium", new DateTime(2021, 8, 15), 4, 10, "Bob Smith", "456 Elm St", 0694859385),
            new MemberRecord(3, "Regular", new DateTime(2023, 1, 10), 1, 3, "Charlie Brown", "789 Maple St", 0644223399),
            new MemberRecord(4, "Premium", new DateTime(2020, 12, 5), 3, 8, "Diana Prince", "321 Oak St", 0633445533)
        };

        // Displaying all members
        Console.WriteLine("List of Members:");
        foreach (MemberRecord member in members)
        {
            Console.WriteLine($"Member ID: {member.memberId}, Name: {member.name}, Type: {member.type}, Books Issued: {member.noBookIssued}");
        }
    }
}