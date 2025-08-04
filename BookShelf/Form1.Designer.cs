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
            AddAuthorTxt = new TextBox();
            AddAuthorTxtBox = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button2 = new Button();
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
            dataGridViewBooks.Location = new Point(12, 239);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(776, 85);
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
            // AddAuthorTxt
            // 
            AddAuthorTxt.Location = new Point(536, 149);
            AddAuthorTxt.Name = "AddAuthorTxt";
            AddAuthorTxt.Size = new Size(129, 23);
            AddAuthorTxt.TabIndex = 4;
            AddAuthorTxt.TextChanged += textBox1_TextChanged;
            // 
            // AddAuthorTxtBox
            // 
            AddAuthorTxtBox.AutoSize = true;
            AddAuthorTxtBox.Location = new Point(599, 131);
            AddAuthorTxtBox.Name = "AddAuthorTxtBox";
            AddAuthorTxtBox.Size = new Size(66, 15);
            AddAuthorTxtBox.TabIndex = 5;
            AddAuthorTxtBox.Text = "AddAuthor";
            // 
            // button1
            // 
            button1.Location = new Point(590, 178);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(790, 433);
            tabControl1.TabIndex = 7;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(677, 61);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(782, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(664, 30);
            button2.Name = "button2";
            button2.Size = new Size(73, 50);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AddAuthorTxtBox);
            Controls.Add(AddAuthorTxt);
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
        private TextBox AddAuthorTxt;
        private Label AddAuthorTxtBox;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button2;
    }
}
