using Library.src.Manage.TypeOfCustomer;
using Library.src.Manage.Interface;

namespace Library.src.Manage.TypeOfBook 
{
    public class Novel: Book,IBorrowbook 
    {
        public string Genre {get;set;} = string.Empty;

        public Novel(string title, string author, string isbn, string publicationYear,string genre): base(title, author, isbn, publicationYear)
        {
            CanPrint = false;
            Genre = genre;
        }
        
        public void PrintInfo()  
        {
            base.PrintInfo();
            Console.Write($" Genre: {Genre}");
        }

        public void BorrowBook(LibraryManage  library, Customer customer) 
        {
            Console.WriteLine($"The novel {Title} is borrowed by {customer.Name}");
            library.BorrowBook(customer, this);
        }

        public void ReturnBook(LibraryManage  library, Customer customer) 
        {
            Console.WriteLine($"The novel {Title} is returned by {customer.Name}");
            library.ReturnBook(customer,this);
        }
    }
}