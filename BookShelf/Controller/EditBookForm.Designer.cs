namespace BookShelf.Controller
{
    partial class EditBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            comboAuthors = new ComboBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 139);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 0;
            // 
            // comboAuthors
            // 
            comboAuthors.Location = new Point(116, 81);
            comboAuthors.Name = "comboAuthors";
            comboAuthors.Size = new Size(121, 23);
            comboAuthors.TabIndex = 1;
            comboAuthors.SelectedIndexChanged += comboAuthors_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(162, 110);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Click += BtnOk_Click;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 410);
            Controls.Add(txtTitle);
            Controls.Add(comboAuthors);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditBookForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}