namespace BookShelf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboAuthors = new ComboBox();
            dataGridViewBooks = new DataGridView();
            textTitle = new TextBox();
            btnAdd = new Button();
            authorBindingSource = new BindingSource(components);
            booksBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboAuthors
            // 
            comboAuthors.AccessibleRole = AccessibleRole.OutlineButton;
            comboAuthors.Location = new Point(47, 139);
            comboAuthors.Name = "comboAuthors";
            comboAuthors.Size = new Size(121, 23);
            comboAuthors.TabIndex = 3;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(12, 12);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(776, 58);
            dataGridViewBooks.TabIndex = 1;
            dataGridViewBooks.CellContentClick += dataGridViewBooks_CellContentClick;
            // 
            // textTitle
            // 
            textTitle.Location = new Point(47, 168);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(121, 23);
            textTitle.TabIndex = 2;
            textTitle.TextChanged += textTitle_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(127, 207);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(41, 26);
            btnAdd.TabIndex = 0;
            btnAdd.Click += btnAdd_Click;
            // 
            // authorBindingSource
            // 
            authorBindingSource.DataSource = typeof(Entities.Author);
            // 
            // booksBindingSource
            // 
            booksBindingSource.DataMember = "Books";
            booksBindingSource.DataSource = authorBindingSource;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(textTitle);
            Controls.Add(dataGridViewBooks);
            Controls.Add(comboAuthors);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboAuthors;
        private DataGridView dataGridViewBooks;
        private TextBox textTitle;
        private Button btnAdd;
        private BindingSource authorBindingSource;
        private BindingSource booksBindingSource;
    }
}
