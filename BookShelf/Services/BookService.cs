using BookShelf.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShelf.Services
{
    public class BookService
    {
        private List<Book> books = new();
        private int bookIdCounter = 1;

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public void AddBook(string title, Author author)
        {
            var book = new Book
            {
                Id = bookIdCounter++,
                Title = title,
                Author = author
            };
            books.Add(book);
            author.Books.Add(book);
        }

        public void EditBook(int id, string title, Author author)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                book.Title = title;
                book.Author = author;
            }
        }

        public void RemoveBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
                book.Author?.Books.Remove(book);
            }
        }
    }
}
