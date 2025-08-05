using BookShelf.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShelf.Controller
{
    public partial class EditBookForm : Form
    {
        public string BookTitle { get; private set; }
        public Author SelectedAuthor { get; private set; }

        private List<Author> authors;

        private TextBox txtTitle;
        private ComboBox comboAuthors;
        private Button btnOk;

        public EditBookForm(string currentTitle, Author currentAuthor, List<Author> authors)
        {
            this.authors = authors;
            InitializeComponent();

            txtTitle.Text = currentTitle;
            comboAuthors.DataSource = authors;
            comboAuthors.DisplayMember = "Name";

            if (currentAuthor != null)
                comboAuthors.SelectedItem = authors.FirstOrDefault(a => a.Id == currentAuthor.Id);
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            BookTitle = txtTitle.Text;
            SelectedAuthor = comboAuthors.SelectedItem as Author;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
