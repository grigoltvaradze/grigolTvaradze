using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarySystem
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        public int Count => books.Count;
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public List<Book> FindBook(string title)
        {
            List<Book> foundBooks = new List<Book>();

            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    foundBooks.Add(book);
                }
            }

            return foundBooks;
        }
        public void PrintLibrary()
        {
            Console.WriteLine("Library:");
            foreach (Book book in books)
            {
                Console.WriteLine($"Book: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }
    }
}