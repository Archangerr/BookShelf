using BookShelf.Entities;
using BookShelf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookShelf.DTO.BookDTO;

namespace BookShelf.Controller
{
    public partial class BooksControl : UserControl
    {
        private BookService bookService = new();
        private DataGridView bookGridView;
        private TextBox textBox1;
        private ComboBox comboAuthor;
        private List<Author> authors;
        private int selectedBookID = -1;
        private Button btnRemove;
        private Button btnEdit;


        private void InitializeComponent()
        {
            bookGridView = new DataGridView();
            textBox1 = new TextBox();
            comboAuthor = new ComboBox();
            btnEdit = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)bookGridView).BeginInit();
            SuspendLayout();
            // 
            // bookGridView
            // 
            bookGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookGridView.Location = new Point(32, 53);
            bookGridView.MultiSelect = false;
            bookGridView.Name = "bookGridView";
            bookGridView.ReadOnly = true;
            bookGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookGridView.Size = new Size(478, 102);
            bookGridView.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 1;
            // 
            // comboAuthor
            // 
            comboAuthor.FormattingEnabled = true;
            comboAuthor.Location = new Point(46, 205);
            comboAuthor.Name = "comboAuthor";
            comboAuthor.Size = new Size(197, 23);
            comboAuthor.TabIndex = 2;
            comboAuthor.SelectedIndexChanged += comboAuthor_SelectedIndexChanged;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(46, 240);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit Book";
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(168, 240);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Edit Book";
            btnRemove.Click += btnRemove_Click;
            // 
            // BooksControl
            // 
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(comboAuthor);
            Controls.Add(textBox1);
            Controls.Add(bookGridView);
            Name = "BooksControl";
            Size = new Size(547, 429);
            ((System.ComponentModel.ISupportInitialize)bookGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        public BooksControl(List<Author> sharedAuthors)
        {

            authors = sharedAuthors;
            authors.Add(new Author { Id = -1, Name = "Show All" }); // Dummy author for "Show All" option
            InitializeComponent();
            bookService.AddBook("Harry Potter and the Philosopher's Stone", authors.FirstOrDefault(a => a.Name == "J.K. Rowling"));
            bookService.AddBook("A Game of Thrones", authors.FirstOrDefault(a => a.Name == "George R.R. Martin"));
            bookService.AddBook("The Hobbit", authors.FirstOrDefault(a => a.Name == "J.R.R. Tolkien"));

            comboAuthor.Items.Insert(0, "Show All");
            comboAuthor.DataSource = authors;
            comboAuthor.DisplayMember = "Name";

            RefreshBooks();
        }

        private void RefreshBooks()
        {
            var bookDisplays = bookService.GetAllBooks()
                .Select(b => new BookDisplay
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorName = b.Author?.Name ?? ""
                }).ToList();

            bookGridView.DataSource = bookDisplays;
            bookGridView.ClearSelection();
        }

        private void RefreshBooks(Author selectedAuthor)
        {
            var books = bookService.GetAllBooks()
                .Where(b => b.Author?.Id == selectedAuthor.Id)
                .Select(b => new BookDisplay
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorName = b.Author?.Name ?? ""
                }).ToList();

            bookGridView.DataSource = books;
            bookGridView.ClearSelection();
        }


        private void DataGridViewBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = bookGridView.Rows[e.RowIndex];
                selectedBookID = (int)selectedRow.Cells["Id"].Value;
                string title = selectedRow.Cells["Title"].Value.ToString();
                string authorName = selectedRow.Cells["AuthorName"].Value.ToString();
                bookService.EditBook(selectedBookID, title, authors.FirstOrDefault(a => a.Name == authorName));
                RefreshBooks();
            }
        }

        private void DataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = bookGridView.Rows[e.RowIndex];
        }

        private void comboAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAuthor.SelectedItem is Author selectedAuthor)
            {
                if (selectedAuthor.Id == -1) // "Show All" option
                {
                    RefreshBooks();
                }
                else
                {
                    RefreshBooks(selectedAuthor);
                }
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (bookGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to edit.");
                return;
            }

            var selectedRow = bookGridView.SelectedRows[0];
            int bookId = (int)selectedRow.Cells["Id"].Value;
            string currentTitle = selectedRow.Cells["Title"].Value.ToString();
            string currentAuthorName = selectedRow.Cells["AuthorName"].Value.ToString();
            var currentAuthor = authors.FirstOrDefault(a => a.Name == currentAuthorName);

            var editForm = new EditBookForm(currentTitle, currentAuthor, authors);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                bookService.EditBook(bookId, editForm.BookTitle, editForm.SelectedAuthor);
                RefreshBooks();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (bookGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to Remove.");
                return;
            }

        }
    }
}