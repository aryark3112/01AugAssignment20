﻿using System.Collections.Generic;
using System;
namespace _01AugustAssignment20
{

    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("All Books in the Library:");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
        }

        public void SearchBookById(int bookId)
        {
            var book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("Book not found with the given ID.");
            }
        }

        public void SearchBookByTitle(string title)
        {
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("Book not found with the given title.");
            }
        }
    }
}
