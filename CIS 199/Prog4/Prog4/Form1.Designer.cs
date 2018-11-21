namespace Prog4
{
    partial class Form1
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
            this.enterBookLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.publishLbl = new System.Windows.Forms.Label();
            this.copyrightYearLbl = new System.Windows.Forms.Label();
            this.callNumberLbl = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.copyrightYearTextBox = new System.Windows.Forms.TextBox();
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.selectBookLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterBookLbl
            // 
            this.enterBookLbl.AutoSize = true;
            this.enterBookLbl.Location = new System.Drawing.Point(12, 26);
            this.enterBookLbl.Name = "enterBookLbl";
            this.enterBookLbl.Size = new System.Drawing.Size(184, 13);
            this.enterBookLbl.TabIndex = 0;
            this.enterBookLbl.Text = "Enter Library Book Information Below:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(16, 72);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(30, 13);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Title:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(16, 111);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(41, 13);
            this.authorLbl.TabIndex = 2;
            this.authorLbl.Text = "Author:";
            // 
            // publishLbl
            // 
            this.publishLbl.AutoSize = true;
            this.publishLbl.Location = new System.Drawing.Point(16, 152);
            this.publishLbl.Name = "publishLbl";
            this.publishLbl.Size = new System.Drawing.Size(53, 13);
            this.publishLbl.TabIndex = 3;
            this.publishLbl.Text = "Publisher:";
            // 
            // copyrightYearLbl
            // 
            this.copyrightYearLbl.AutoSize = true;
            this.copyrightYearLbl.Location = new System.Drawing.Point(16, 192);
            this.copyrightYearLbl.Name = "copyrightYearLbl";
            this.copyrightYearLbl.Size = new System.Drawing.Size(82, 13);
            this.copyrightYearLbl.TabIndex = 4;
            this.copyrightYearLbl.Text = "Copyright Year: ";
            // 
            // callNumberLbl
            // 
            this.callNumberLbl.AutoSize = true;
            this.callNumberLbl.Location = new System.Drawing.Point(16, 232);
            this.callNumberLbl.Name = "callNumberLbl";
            this.callNumberLbl.Size = new System.Drawing.Size(67, 13);
            this.callNumberLbl.TabIndex = 5;
            this.callNumberLbl.Text = "Call Number:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(108, 69);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(147, 20);
            this.titleTextBox.TabIndex = 6;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(108, 111);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(147, 20);
            this.authorTextBox.TabIndex = 7;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(108, 152);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(147, 20);
            this.publisherTextBox.TabIndex = 8;
            // 
            // copyrightYearTextBox
            // 
            this.copyrightYearTextBox.Location = new System.Drawing.Point(108, 190);
            this.copyrightYearTextBox.Name = "copyrightYearTextBox";
            this.copyrightYearTextBox.Size = new System.Drawing.Size(147, 20);
            this.copyrightYearTextBox.TabIndex = 9;
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(108, 231);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(147, 20);
            this.callNumberTextBox.TabIndex = 10;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(132, 269);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(98, 23);
            this.addBookButton.TabIndex = 11;
            this.addBookButton.Text = "Add New Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.Location = new System.Drawing.Point(302, 69);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(266, 186);
            this.bookListBox.TabIndex = 12;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(583, 101);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 13;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(583, 152);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(75, 23);
            this.checkOutButton.TabIndex = 14;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(583, 206);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 15;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // selectBookLbl
            // 
            this.selectBookLbl.AutoSize = true;
            this.selectBookLbl.Location = new System.Drawing.Point(299, 26);
            this.selectBookLbl.Name = "selectBookLbl";
            this.selectBookLbl.Size = new System.Drawing.Size(68, 13);
            this.selectBookLbl.TabIndex = 16;
            this.selectBookLbl.Text = "Select Book:";
            // 
            // Form1
            // 
            this.AcceptButton = this.addBookButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 319);
            this.Controls.Add(this.selectBookLbl);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.bookListBox);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.callNumberTextBox);
            this.Controls.Add(this.copyrightYearTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.callNumberLbl);
            this.Controls.Add(this.copyrightYearLbl);
            this.Controls.Add(this.publishLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.enterBookLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterBookLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label publishLbl;
        private System.Windows.Forms.Label copyrightYearLbl;
        private System.Windows.Forms.Label callNumberLbl;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox copyrightYearTextBox;
        private System.Windows.Forms.TextBox callNumberTextBox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.ListBox bookListBox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label selectBookLbl;
    }
}

