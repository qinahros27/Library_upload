using Library.src.Manage.TypeOfBook;

namespace Library.src.Manage.TypeOfCustomer 
{
    public class Librarian: Person 
    {
        public Librarian(int id, string name): base(id,name) {}

        public void AddBook(LibraryManage library, Book book) 
        {
            library.AddBook(this,book);
        }

        public void RemoveBook(LibraryManage  library, Book book) 
        {
            library.RemoveBook(book);
        }

        public void EditBook(LibraryManage  library, Book book) 
        {
            library.EditBook(book);
        }
    }
}