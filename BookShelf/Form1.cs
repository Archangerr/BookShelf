using BookShelf.Controller;
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

            BooksControl booksControl = new BooksControl(authors);
            booksControl.Dock = DockStyle.Fill;

            TabPage tabBooks = new TabPage("Books");
            tabBooks.Controls.Add(booksControl);

            tabControl1.TabPages.Add(tabBooks);

            //var authorsControl = new AuthorsControl(authors);
            //authorsControl.Dock = DockStyle.Fill;

            var tabAuthors = new TabPage("Authors");
            //tabAuthors.Controls.Add(authorsControl);

            tabControl1.TabPages.Add(tabAuthors);

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
                    AuthorName = b.Author?.Name,

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author? author = new Author();
            author.Name = AddAuthorTxt.Text;
            if (string.IsNullOrWhiteSpace(author.Name))
            {
                MessageBox.Show("Please enter a valid author name.");
                return;
            }
            authors.Add(author);
            RefreshAuthors();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = tabControl1.SelectedTab;

            if (selectedTab.Text == "Authors")
            {
                tabControl1.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }
    }
}
