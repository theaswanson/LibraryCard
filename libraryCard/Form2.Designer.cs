namespace libraryCard
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.getData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.TextBox();
            this.condPoor = new System.Windows.Forms.RadioButton();
            this.condFair = new System.Windows.Forms.RadioButton();
            this.condGood = new System.Windows.Forms.RadioButton();
            this.condNew = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.pageCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(143, 68);
            this.bookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(398, 29);
            this.bookTitle.TabIndex = 1;
            this.bookTitle.TextChanged += new System.EventHandler(this.bookTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author(s)";
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(143, 135);
            this.author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(398, 29);
            this.author.TabIndex = 2;
            this.author.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(143, 199);
            this.ISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(398, 29);
            this.ISBN.TabIndex = 3;
            this.ISBN.TextChanged += new System.EventHandler(this.ISBN_TextChanged);
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(161, 642);
            this.getData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(105, 41);
            this.getData.TabIndex = 11;
            this.getData.Text = "Add";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(306, 642);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(143, 266);
            this.genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(398, 29);
            this.genre.TabIndex = 4;
            this.genre.TextChanged += new System.EventHandler(this.genre_TextChanged);
            // 
            // condPoor
            // 
            this.condPoor.AutoSize = true;
            this.condPoor.Location = new System.Drawing.Point(189, 572);
            this.condPoor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condPoor.Name = "condPoor";
            this.condPoor.Size = new System.Drawing.Size(78, 29);
            this.condPoor.TabIndex = 10;
            this.condPoor.TabStop = true;
            this.condPoor.Text = "Poor";
            this.condPoor.UseVisualStyleBackColor = true;
            this.condPoor.CheckedChanged += new System.EventHandler(this.condPoor_CheckedChanged);
            // 
            // condFair
            // 
            this.condFair.AutoSize = true;
            this.condFair.Location = new System.Drawing.Point(189, 535);
            this.condFair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condFair.Name = "condFair";
            this.condFair.Size = new System.Drawing.Size(70, 29);
            this.condFair.TabIndex = 9;
            this.condFair.TabStop = true;
            this.condFair.Text = "Fair";
            this.condFair.UseVisualStyleBackColor = true;
            this.condFair.CheckedChanged += new System.EventHandler(this.condFair_CheckedChanged);
            // 
            // condGood
            // 
            this.condGood.AutoSize = true;
            this.condGood.Location = new System.Drawing.Point(189, 502);
            this.condGood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condGood.Name = "condGood";
            this.condGood.Size = new System.Drawing.Size(85, 29);
            this.condGood.TabIndex = 8;
            this.condGood.TabStop = true;
            this.condGood.Text = "Good";
            this.condGood.UseVisualStyleBackColor = true;
            this.condGood.CheckedChanged += new System.EventHandler(this.condGood_CheckedChanged);
            // 
            // condNew
            // 
            this.condNew.AutoSize = true;
            this.condNew.Location = new System.Drawing.Point(189, 467);
            this.condNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condNew.Name = "condNew";
            this.condNew.Size = new System.Drawing.Size(76, 29);
            this.condNew.TabIndex = 7;
            this.condNew.TabStop = true;
            this.condNew.Text = "New";
            this.condNew.UseVisualStyleBackColor = true;
            this.condNew.CheckedChanged += new System.EventHandler(this.condNew_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 471);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Condition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Publication Year";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(216, 332);
            this.year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(325, 29);
            this.year.TabIndex = 5;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged_1);
            // 
            // pageCount
            // 
            this.pageCount.Location = new System.Drawing.Point(216, 399);
            this.pageCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(325, 29);
            this.pageCount.TabIndex = 6;
            this.pageCount.TextChanged += new System.EventHandler(this.pageCount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Page Count";
            // 
            // Form2
            // 
            this.AcceptButton = this.getData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(576, 716);
            this.Controls.Add(this.pageCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.condNew);
            this.Controls.Add(this.condGood);
            this.Controls.Add(this.condFair);
            this.Controls.Add(this.condPoor);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Adding";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.RadioButton condPoor;
        private System.Windows.Forms.RadioButton condFair;
        private System.Windows.Forms.RadioButton condGood;
        private System.Windows.Forms.RadioButton condNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox pageCount;
        private System.Windows.Forms.Label label7;
    }
}