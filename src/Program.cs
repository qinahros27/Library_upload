﻿using Library.src.Manage;
using Library.src.Manage.TypeOfBook;
using Library.src.Manage.TypeOfCustomer;

namespace Library.src 
{
    public class Program 
    {
        private static void Main(string[] args)
        {   
            LibraryManage library = new LibraryManage();
            Customer customer1 = new Customer(1,"Anna");
            Customer customer1_edit = new Customer(1,"Anna Belle");
            Customer customer2 = new Customer(2,"Bella");
            Librarian librarian1 = new Librarian(1,"Candy");
            Comic comic1 = new Comic("Doreamon", "Fujiko Fukjio","1234","2020", "Fujiko");
            TextBook textbook1 = new TextBook("Textbook1", "David", "4567","2021");
            TextBook textbook1_edit = new TextBook("Textbook1", "David", "4567","2023");
            Novel novel1 = new Novel("The power of letting go","John Purkiss", "7890","2020","Literary");
            ResearchPaper researchPaper1 = new ResearchPaper("research paper 1", "Elena","0123","2022");

            // Add,edit,remove person
            Console.WriteLine("Add person function: ");
            library.AddPerson(customer1);
            library.AddPerson(customer2);
            Console.WriteLine("People lists after add: ");
            library.ViewPeople();
            library.EditPerson(customer1_edit);
            Console.WriteLine("People lists after edit customer1: ");
            library.ViewPeople();
            library.RemovePerson(customer2);
            Console.WriteLine("People lists after remove customer2: ");
            library.ViewPeople();
            // add, edit , remove book
            librarian1.AddBook(library, comic1);
            librarian1.AddBook(library, textbook1);
            librarian1.AddBook(library,novel1);
            librarian1.AddBook(library,researchPaper1);
            Console.WriteLine("List of books after add: ");
            library.ViewBooks();
            librarian1.EditBook(library,textbook1_edit);
            Console.WriteLine("List of the books after editing textbook1: ");
            library.ViewBooks();
            librarian1.RemoveBook(library,novel1);
            Console.WriteLine("List of the books after removing novel1: ");
            library.ViewBooks();
            // customer borrow, return book
            customer1.BorrowBook(library,comic1);
            customer1.BorrowBook(library,textbook1);
            customer1.BorrowBook(library,researchPaper1);
            Console.WriteLine("List of the books that customer1 borrowed (comic and textbook, researchPaper1 can not borrow): ");
            customer1.ViewBorrowedBook();
            customer1.ReturnBook(library,comic1);
            Console.WriteLine("List of the books that customer1 borrowed after returning comic1: ");
            customer1.ViewBorrowedBook();
            // print info, borrow, return book , print pages
            Console.WriteLine("Print info of comic1, novel1, textbook1, research paper 1: ");
            comic1.PrintInfo();
            Console.WriteLine();
            novel1.PrintInfo();
            Console.WriteLine();
            textbook1.PrintInfo();
            Console.WriteLine();
            researchPaper1.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("Run the function borrow and return of the book: ");
            comic1.BorrowBook(library,customer1);
            comic1.ReturnBook(library,customer1);
            Console.WriteLine("Run the function printPages: ");
            textbook1.PrintPages(1,15);
            researchPaper1.PrintPages(20,39);
        }
    }
}
