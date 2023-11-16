using Library.src.Manage.TypeOfCustomer;
using Library.src.Manage.Interface;

namespace Library.src.Manage.TypeOfBook 
{
    public class Comic: Book, IBorrowbook
    {
        public string Artist {get;set;} = string.Empty;

        public Comic(string title, string author, string isbn, string publicationYear, string artist): base(title, author, isbn, publicationYear)
        {
            CanPrint = false;
            Artist = artist;
        }

        public void PrintInfo()  
        {
            base.PrintInfo();
            Console.Write($"; Artist: {Artist}");
        }

        public void BorrowBook(LibraryManage library, Customer customer) 
        {
            Console.WriteLine($"The comic {Title} is borrowed by {customer.Name}");
            library.BorrowBook(customer, this);
        }

        public void ReturnBook(LibraryManage library, Customer customer) 
        {
            Console.WriteLine($"The comic {Title} is returned by {customer.Name}");
            library.ReturnBook(customer,this);
        }
    }
}