
using LibrarySystem;

Library library = new Library();

Book book1 = new Book("kacia adamiani?", "ilia chavchavadze", 1859);
Book book2 = new Book("mtvaris motaceba", "konstantine gamsakhurdia", 1936);

library.AddBook(book1);
library.AddBook(book2);

//library.PrintLibrary();

string searchTitle = "kacia adamiani?";
List<Book> foundBooks = library.FindBook(searchTitle);

if (foundBooks.Count > 0)
{
    Console.WriteLine($"'{searchTitle}' napovnia shemdegi :");
    foreach (Book book in foundBooks)
    {
        Console.WriteLine($"book: {book.Title}, Author: {book.Author}, Year: {book.Year}");
    }
}
else
{
    Console.WriteLine($"'{searchTitle}' not found.");
}

library.RemoveBook(book1);

library.PrintLibrary();
        