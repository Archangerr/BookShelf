using BookShelf.Entities;
using BookShelf.Services;
using System.Collections.Generic;
using System.Windows.Forms;
using static BookShelf.DTO.BookDTO;

namespace BookShelf
{
    public partial class Form1 : Form
    {
        private BookService bookService = new();
        private List<Author> authors = new();
        private int selectedBookId = -1;

        public Form1()
        {
            InitializeComponent();
            InitializeAuthors();
            RefreshAuthors();
            RefreshBooks();
        }

        private void InitializeAuthors()
        {
            authors.Add(new Author { Id = 1, Name = "J.K. Rowling" });
            authors.Add(new Author { Id = 2, Name = "George R.R. Martin" });
            authors.Add(new Author { Id = 3, Name = "J.R.R. Tolkien" });
        }

        private void RefreshAuthors()
        {
            comboAuthors.DataSource = null;
            comboAuthors.DataSource = authors;
            comboAuthors.DisplayMember = "Name";
        }
        private void RefreshBooks()
        {
            var bookDisplays = bookService.GetAllBooks()
                .Select(b => new BookDisplay
                {
                     Id = b.Id,
                    Title = b.Title,
                    AuthorName = b.Author?.Name, // Just show the name
                
                }).ToList();

            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = bookDisplays;
        }

        //private void comboAuthors_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    RefreshAuthors();
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text;
            Author? author = comboAuthors.SelectedItem as Author;

            if (string.IsNullOrWhiteSpace(title) || author == null)
            {
                MessageBox.Show("Please enter a valid title and select an author.");
                return;
            }
            bookService.AddBook(title, author);
            RefreshBooks();
            //ClearInputs();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textTitle_TextChanged(object sender, EventArgs e)
        {

        }



        


    }
}
