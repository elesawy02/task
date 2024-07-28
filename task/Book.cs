using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{

    public delegate string BookDelegate(Book book);
    public delegate DateTime PublicationDateDelegate(Book book);


    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }


        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    public static class Bookfunctions
    {
        public static string GetTitle(Book b)
        {
            throw new NotImplementedException();
        }
        public static string GetAuthors(Book b)
        {
            throw new NotImplementedException();
        }
        public static string GetPrice(Book b)
        {
            throw new NotImplementedException();
        }

        public static string GetISBN(Book b)
        {
            throw new NotImplementedException();
        }
        public static DateTime GetPublicationDate(Book b)
        {
            throw new NotImplementedException();
        }

    }
    public static class BookProcessor
    {
        public static void ProcessBooks(List<Book> books, BookDelegate bookDelegate)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }
        }

        public static void ProcessBooks(List<Book> books, PublicationDateDelegate dateDelegate)
        {
            foreach (var book in books)
            {
                Console.WriteLine(dateDelegate(book));
            }
        }
    }

    public static class BookProcessorWithFunc
    {
        public static void ProcessBooks<T>(List<Book> books, Func<Book, T> func)
        {
            foreach (var book in books)
            {
                Console.WriteLine(func(book));
            }
        }
    }


    public class Libraryengine
    {
        public static void ProcessBooks(List<Book> blist, fptr)
        {
            foreach( Book B in blist)
            {
                Console.WriteLine(fptr(B));
            }

        }
    }
}




