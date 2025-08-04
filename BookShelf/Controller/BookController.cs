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
        private ComboBox comboBox1;
        private List<Author> authors;
        private int selectedBookID = -1;

        private void InitializeComponent()
        {
            bookGridView = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bookGridView).BeginInit();
            SuspendLayout();
            // 
            // bookGridView
            // 
            bookGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookGridView.Location = new Point(32, 53);
            bookGridView.Name = "bookGridView";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(46, 205);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 23);
            comboBox1.TabIndex = 2;
            // 
            // BooksControl
            // 
            Controls.Add(comboBox1);
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
            InitializeComponent();
            bookService.AddBook("Harry Potter and the Philosopher's Stone", authors.FirstOrDefault(a => a.Name == "J.K. Rowling"));
            bookService.AddBook("A Game of Thrones", authors.FirstOrDefault(a => a.Name == "George R.R. Martin"));
            bookService.AddBook("The Hobbit", authors.FirstOrDefault(a => a.Name == "J.R.R. Tolkien"));
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




    }
}