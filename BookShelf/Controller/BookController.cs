using BookShelf.Entities;
using BookShelf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShelf.Controller
{
    public partial class BooksControl : UserControl
    {
        private BookService bookService = new();
        private List<Author> authors;

       

        public BooksControl(List<Author> sharedAuthors)
        {
            
            authors = sharedAuthors;
            
        }
    }
}
