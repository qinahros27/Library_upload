using Library.src.Manage.TypeOfCustomer;
using Library.src.Manage.Interface;

namespace Library.src.Manage.TypeOfBook 
{
    public class TextBook: Book,IBorrowbook 
    {
        private int _maxPage = 20;

        public TextBook(string title, string author, string isbn, string publicationYear): base(title, author, isbn, publicationYear){}
        
        public void BorrowBook(LibraryManage  library, Customer customer) 
        {
            Console.WriteLine($"The textbook {Title} is borrowed by {customer.Name}");
            library.BorrowBook(customer, this);
        }

        public void ReturnBook(LibraryManage  library, Customer customer) 
        {
            Console.WriteLine($"The textbook {Title} is returned by {customer.Name}");
            library.ReturnBook(customer,this);
        }

        public void PrintPages(int startPage, int endPage) 
        {
            int amountPage = endPage - startPage;
            if(amountPage >= _maxPage) 
            {
                Console.WriteLine("Amount of page to be printed can not exceed 20 pages.");
            }
            else 
            {
                Console.WriteLine($"Print the book from page {startPage} to {endPage}.");
            }
        }
    }
}