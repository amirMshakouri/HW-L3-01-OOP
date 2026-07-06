using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task1
{
    internal class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("the book has been added successfully");
        }
        public void BarrowBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    if (book.IsAvailable)
                    {
                        book.IsAvailable = false;
                        Console.WriteLine("the book borrowed successfully:");
                    }
                    else
                    {
                        Console.WriteLine("the book has been borrowed by somebody else");
                    }
                    return;
                }

            }
            Console.WriteLine("book not found");

        }
        public void ReturnBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    book.IsAvailable = true;

                    Console.WriteLine("the book has returned successfully");
                    return;
                }

            }
            Console.WriteLine("book not found");
        }
        public void ShowBooks()
        {
            Console.WriteLine("book list :");
            foreach (Book book in books)
            {
                Console.WriteLine($"Title : {book.Title}");
                Console.WriteLine($"Author : {book.Author}");
                Console.WriteLine($"ISBN : {book.ISBN}");
                Console.WriteLine($"Status : {(book.IsAvailable ? "Available" : "is borrowed")}");

            }

        }
    }
}
