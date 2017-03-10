namespace libraryCard
{
    partial class bookEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookEditForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleNum = new System.Windows.Forms.TextBox();
            this.titleNumLabel = new System.Windows.Forms.Label();
            this.isbnBox = new System.Windows.Forms.GroupBox();
            this.authorBox = new System.Windows.Forms.GroupBox();
            this.titleBox = new System.Windows.Forms.GroupBox();
            this.genreBox = new System.Windows.Forms.GroupBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.pageBox = new System.Windows.Forms.GroupBox();
            this.page = new System.Windows.Forms.TextBox();
            this.pageLabel = new System.Windows.Forms.Label();
            this.conditionBox = new System.Windows.Forms.GroupBox();
            this.condition = new System.Windows.Forms.TextBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.isbnBox.SuspendLayout();
            this.authorBox.SuspendLayout();
            this.titleBox.SuspendLayout();
            this.genreBox.SuspendLayout();
            this.pageBox.SuspendLayout();
            this.conditionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(127, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 22);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(94, 20);
            this.id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(143, 20);
            this.id.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Book ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "What to Edit:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ISBN",
            "Title",
            "Author",
            "Genre",
            "Page Count",
            "Condition"});
            this.comboBox1.Location = new System.Drawing.Point(95, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(14, 24);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(32, 13);
            this.isbnLabel.TabIndex = 20;
            this.isbnLabel.Text = "ISBN";
            this.isbnLabel.Click += new System.EventHandler(this.fNameLabel_Click);
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(79, 23);
            this.isbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(113, 20);
            this.isbn.TabIndex = 21;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(79, 23);
            this.author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(113, 20);
            this.author.TabIndex = 23;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(14, 24);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 22;
            this.authorLabel.Text = "Author";
            // 
            // titleNum
            // 
            this.titleNum.Location = new System.Drawing.Point(79, 23);
            this.titleNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleNum.Name = "titleNum";
            this.titleNum.Size = new System.Drawing.Size(113, 20);
            this.titleNum.TabIndex = 24;
            // 
            // titleNumLabel
            // 
            this.titleNumLabel.AutoSize = true;
            this.titleNumLabel.Location = new System.Drawing.Point(14, 24);
            this.titleNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleNumLabel.Name = "titleNumLabel";
            this.titleNumLabel.Size = new System.Drawing.Size(27, 13);
            this.titleNumLabel.TabIndex = 25;
            this.titleNumLabel.Text = "Title";
            // 
            // isbnBox
            // 
            this.isbnBox.Controls.Add(this.isbn);
            this.isbnBox.Controls.Add(this.isbnLabel);
            this.isbnBox.Location = new System.Drawing.Point(21, 74);
            this.isbnBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isbnBox.Size = new System.Drawing.Size(213, 58);
            this.isbnBox.TabIndex = 56;
            this.isbnBox.TabStop = false;
            // 
            // authorBox
            // 
            this.authorBox.Controls.Add(this.authorLabel);
            this.authorBox.Controls.Add(this.author);
            this.authorBox.Location = new System.Drawing.Point(21, 74);
            this.authorBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorBox.Name = "authorBox";
            this.authorBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorBox.Size = new System.Drawing.Size(213, 58);
            this.authorBox.TabIndex = 57;
            this.authorBox.TabStop = false;
            // 
            // titleBox
            // 
            this.titleBox.Controls.Add(this.titleNumLabel);
            this.titleBox.Controls.Add(this.titleNum);
            this.titleBox.Location = new System.Drawing.Point(21, 74);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleBox.Size = new System.Drawing.Size(213, 58);
            this.titleBox.TabIndex = 58;
            this.titleBox.TabStop = false;
            // 
            // genreBox
            // 
            this.genreBox.Controls.Add(this.genre);
            this.genreBox.Controls.Add(this.genreLabel);
            this.genreBox.Location = new System.Drawing.Point(21, 74);
            this.genreBox.Margin = new System.Windows.Forms.Padding(2);
            this.genreBox.Name = "genreBox";
            this.genreBox.Padding = new System.Windows.Forms.Padding(2);
            this.genreBox.Size = new System.Drawing.Size(213, 58);
            this.genreBox.TabIndex = 59;
            this.genreBox.TabStop = false;
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(79, 23);
            this.genre.Margin = new System.Windows.Forms.Padding(4);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(113, 20);
            this.genre.TabIndex = 21;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(14, 24);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 20;
            this.genreLabel.Text = "Genre";
            this.genreLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // pageBox
            // 
            this.pageBox.Controls.Add(this.page);
            this.pageBox.Controls.Add(this.pageLabel);
            this.pageBox.Location = new System.Drawing.Point(21, 74);
            this.pageBox.Margin = new System.Windows.Forms.Padding(2);
            this.pageBox.Name = "pageBox";
            this.pageBox.Padding = new System.Windows.Forms.Padding(2);
            this.pageBox.Size = new System.Drawing.Size(213, 58);
            this.pageBox.TabIndex = 57;
            this.pageBox.TabStop = false;
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(79, 23);
            this.page.Margin = new System.Windows.Forms.Padding(4);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(113, 20);
            this.page.TabIndex = 21;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(14, 24);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(63, 13);
            this.pageLabel.TabIndex = 20;
            this.pageLabel.Text = "Page Count";
            // 
            // conditionBox
            // 
            this.conditionBox.Controls.Add(this.condition);
            this.conditionBox.Controls.Add(this.conditionLabel);
            this.conditionBox.Location = new System.Drawing.Point(21, 74);
            this.conditionBox.Margin = new System.Windows.Forms.Padding(2);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Padding = new System.Windows.Forms.Padding(2);
            this.conditionBox.Size = new System.Drawing.Size(213, 58);
            this.conditionBox.TabIndex = 57;
            this.conditionBox.TabStop = false;
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(79, 23);
            this.condition.Margin = new System.Windows.Forms.Padding(4);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(113, 20);
            this.condition.TabIndex = 21;
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(14, 24);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(51, 13);
            this.conditionLabel.TabIndex = 20;
            this.conditionLabel.Text = "Condition";
            // 
            // bookEditForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(254, 283);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.pageBox);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.conditionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "bookEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Book";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.isbnBox.ResumeLayout(false);
            this.isbnBox.PerformLayout();
            this.authorBox.ResumeLayout(false);
            this.authorBox.PerformLayout();
            this.titleBox.ResumeLayout(false);
            this.titleBox.PerformLayout();
            this.genreBox.ResumeLayout(false);
            this.genreBox.PerformLayout();
            this.pageBox.ResumeLayout(false);
            this.pageBox.PerformLayout();
            this.conditionBox.ResumeLayout(false);
            this.conditionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox titleNum;
        private System.Windows.Forms.Label titleNumLabel;
        private System.Windows.Forms.GroupBox isbnBox;
        private System.Windows.Forms.GroupBox authorBox;
        private System.Windows.Forms.GroupBox titleBox;
        private System.Windows.Forms.GroupBox genreBox;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.GroupBox pageBox;
        private System.Windows.Forms.TextBox page;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.GroupBox conditionBox;
        private System.Windows.Forms.TextBox condition;
        private System.Windows.Forms.Label conditionLabel;
    }
}