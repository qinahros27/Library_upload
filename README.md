# Library Management System
This project is to implement a basic Library Management System as a C# console application.

## Description
A library has books and users. Users can be either cutomers or librarians. Librarians can add or remove books from the library and also can issue books to customers. Customers can request to borrow or return books. Also, library can have different types of books (Comic, Novel, TextBook, ResearchPaper) as well.

## Features
1. `Library` manage the collection of Book objects, and `Person` objects. This class have following methods:
   - Add, Remove, Borrow, and Return books
   - Add, Remove, Edit `Person` objects
2. `Person` has properties such as Name and ID. `Customer` and `Librarian` inherit from this class and have additional properties/features:
   - `Customer` can Borrow and Return books.
   - `Librarian` can Add, Remove, Edit books.
3. `Book` has properties like Title, Author, ISBN, PublicationYear, CanBorrow, and CanPrint. Each book has an unique record with unique ISBN in the `Library`. In addition, `Book` has `PrintInfo()` method to print information about each book (uses `Console.WriteLine`). `Comic`, `Novel`, `TextBook`, and `ResearchPaper`should inherit properties from `Book` and have additional properties/features:
   - `Comic` has `Artist`, `Novel` has `Genre`
   - `Comic`, `Novel`, `TextBook` can be borrowed, but `ResearchPaper` cannot. If books are borrowable, they should have both `Borrow()` and `Return()` method
   - `TextBook`, and `ResearchPaper` can be printed (to certain amount of pages), but `Comic`, `Novel` cannot. The `PrintPages(int startPage, endPage)`method uses `Console.WriteLine` to inform the start page and end page to be printed, in case the amount of to-be-printed pages do not exceed the maximum allowed pages.
   - `Comic`and `Novel` should have different implementations of `PrintInfo()` with extra information about the extra properties, while `TextBook`, and `ResearchPaper` have default implementation.

## Technology
- C#

## Project structure
```
.
└───FS15_13-LIBRARY
    └───src
        └───Manage
            └───TypeOfBook
                └───Book.cs
                └───Comic.cs
                └───Novel.cs
                └───ResearchPaper.cs
                └───TextBook.cs
            └───TypeOfCustomer
                └───Customer.cs
                └───Librarian.cs
                └───Person.cs
            └───Library.cs
        └───Program.cs
    └───README.md
```

## Result
![Result](image.png)
