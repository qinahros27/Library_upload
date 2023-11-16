using Library.src.Manage.TypeOfBook;
using Library.src.Manage.TypeOfCustomer;

namespace Library.src.Manage 
{
    public class LibraryManage 
    {
        private List<Book> _books;
        private List<Person> _person;

        public LibraryManage () 
        {
            _books = new List<Book>();
            _person = new List<Person>();
        }

        public void AddBook(Librarian person, Book book) 
        {
            var checkExisted = _books.Exists(b => b.Isbn == book.Isbn);
            if(checkExisted) 
            {
                throw new ArgumentException("This book exists");
            }
            else 
            {
                _books.Add(book);
            }
        }

        public void RemoveBook(Book book) 
        {
            var checkExisted = _books.Exists(b => b.Isbn == book.Isbn);
            if(!checkExisted) 
            {
                throw new ArgumentException("Can not find this book.");
            }
            else 
            {
                _books.Remove(book);
            }
        }

        public void EditBook(Book book) 
        {
            var findBook = _books.FirstOrDefault(b => b.Isbn == book.Isbn);
            if(findBook == null) 
            {
                throw new ArgumentException("Can not find this book");
            }
            else 
            {
                findBook.Title = book.Title;
                findBook.Author = book.Author;
                findBook.PublicationYear = book.PublicationYear;
                findBook.CanBorrow = book.CanBorrow;
                findBook.CanPrint = book.CanPrint;
            }
        }

        public void BorrowBook(Customer customer, Book book) 
        {
            var findBook = _books.FirstOrDefault(b => b.Isbn == book.Isbn);
            if(findBook == null) 
            {
                throw new ArgumentException("Can not find this book");
            }
            else 
            {
                if(book.CanBorrow == true) 
                {
                    customer.BorrowedBook.Add(book);
                    book.CanBorrow = false;
                }
                else 
                {
                    Console.WriteLine($"The book {book.Title} is not available for borrowing.");
                }
            }
        }

        public void ReturnBook(Customer customer,Book book) 
        {
            var findBook = customer.BorrowedBook.FirstOrDefault(b => b.Isbn == book.Isbn);
            if(findBook == null) 
            {
                throw new ArgumentException($"This book is not in {customer.Name}'s borrowed list.");
            }
            else 
            {
                customer.BorrowedBook.Remove(book);
                book.CanBorrow = true;     
            }
        }
        
        public void AddPerson(Person person) 
        {
            if(_person.Exists(p => p.Id == person.Id)) 
            {
                throw new ArgumentException("This person exists.");
            }
            else 
            {
                _person.Add(person);
            }
        }

        public void RemovePerson(Person person)
        {
            if(_person.Exists(p => p.Id == person.Id)) 
            {
                _person.Remove(person);
            }
            else 
            {
                throw new ArgumentException("Cannot find this person");
            }
        }

        public void EditPerson(Person person)
        {
            var existPerson = _person.FirstOrDefault(p => p.Id == person.Id);
            if(existPerson == null) 
            {
                throw new ArgumentException("Cannot find this person");
            }
            else 
            {
                existPerson.Name = person.Name;
            }
        }

        public void ViewPeople() 
        {
            foreach(var person in _person) 
            {
                Console.WriteLine($"Name: {person.Name}");
            }
        }

        public void ViewBooks() 
        {
            foreach(var book in _books) 
            {
                book.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}