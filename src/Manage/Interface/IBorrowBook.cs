using Library.src.Manage.TypeOfBook;
using Library.src.Manage.TypeOfCustomer;
namespace Library.src.Manage.Interface 
{
    interface IBorrowbook 
    {
        public void BorrowBook(LibraryManage library, Customer customer) ;
        public void ReturnBook(LibraryManage library, Customer customer) ;
    }
}