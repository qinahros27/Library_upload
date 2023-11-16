using Library.src.Manage.TypeOfBook;

namespace Library.src.Manage.TypeOfCustomer 
{
    public class Customer: Person 
    {
        public List<Book> BorrowedBook;

        public Customer(int id, string name): base(id,  name) 
        {
            BorrowedBook = new List<Book>();
        }

        public void BorrowBook(LibraryManage  library, Book book) 
        {
            library.BorrowBook(this, book);
        }

        public void ReturnBook(LibraryManage  library, Book book) 
        {
            library.ReturnBook(this,book);
        }

        public void ViewBorrowedBook() 
        {
            foreach(var book in BorrowedBook) 
            {
                book.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}