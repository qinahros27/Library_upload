namespace Library.src.Manage.TypeOfBook
{
    public abstract class Book 
    {
        private string _title {get;set;} = string.Empty;
        private string _author {get;set;} = string.Empty;
        private string _isbn {get;set;} = string.Empty;
        private string _publicationYear {get;set;} = string.Empty;
        private bool _canBorrow {get;set;}
        private bool _canPrint {get;set;} 
        
        public Book(string title, string author, string isbn, string publicationYear) 
        {
            _title = title;
            _author = author;
            _isbn = isbn;
            _publicationYear = publicationYear;
            _canBorrow = true;
            _canPrint = true;
        }

        public void PrintInfo() 
        {
            Console.Write($"Title: {_title}; Author: {_author}; ISBN: {_isbn}; Publication Year: {_publicationYear}; Can Borrow: {_canBorrow}; Can Print: {_canPrint}");
        }

        public string Title {
            set{_title = value;}
            get{return _title;}
        } 

        public bool CanBorrow {
            set{_canBorrow = value;}
            get{return _canBorrow;}
        }

        public bool CanPrint {
            set{_canPrint = value;}
            get{return _canPrint;}
        }

        public string Author {
            set{_author = value;}
            get{return _author;}
        }

        public string PublicationYear {
            set{_publicationYear = value;}
            get{return _publicationYear;}
        }

        public string Isbn {
            get{return _isbn;}
        }
    }
}