namespace libraryCard
{
    partial class bookAddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookAddForm));
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
            this.pageCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBookVsDvd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addBookPanel = new System.Windows.Forms.Panel();
            this.addDvdPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dvdTitle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dvdGenre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dvdYear = new System.Windows.Forms.TextBox();
            this.addBookPanel.SuspendLayout();
            this.addDvdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(158, 21);
            this.bookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(380, 29);
            this.bookTitle.TabIndex = 3;
            this.bookTitle.TextChanged += new System.EventHandler(this.bookTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author(s)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(158, 66);
            this.author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(380, 29);
            this.author.TabIndex = 4;
            this.author.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(158, 110);
            this.ISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(380, 29);
            this.ISBN.TabIndex = 5;
            this.ISBN.TextChanged += new System.EventHandler(this.ISBN_TextChanged);
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(161, 499);
            this.getData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(105, 41);
            this.getData.TabIndex = 12;
            this.getData.Text = "Add";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(306, 499);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(158, 154);
            this.genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(380, 29);
            this.genre.TabIndex = 6;
            this.genre.TextChanged += new System.EventHandler(this.genre_TextChanged);
            // 
            // condPoor
            // 
            this.condPoor.AutoSize = true;
            this.condPoor.Location = new System.Drawing.Point(191, 437);
            this.condPoor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condPoor.Name = "condPoor";
            this.condPoor.Size = new System.Drawing.Size(78, 29);
            this.condPoor.TabIndex = 11;
            this.condPoor.TabStop = true;
            this.condPoor.Text = "Poor";
            this.condPoor.UseVisualStyleBackColor = true;
            this.condPoor.CheckedChanged += new System.EventHandler(this.condPoor_CheckedChanged);
            // 
            // condFair
            // 
            this.condFair.AutoSize = true;
            this.condFair.Location = new System.Drawing.Point(191, 402);
            this.condFair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condFair.Name = "condFair";
            this.condFair.Size = new System.Drawing.Size(70, 29);
            this.condFair.TabIndex = 10;
            this.condFair.TabStop = true;
            this.condFair.Text = "Fair";
            this.condFair.UseVisualStyleBackColor = true;
            this.condFair.CheckedChanged += new System.EventHandler(this.condFair_CheckedChanged);
            // 
            // condGood
            // 
            this.condGood.AutoSize = true;
            this.condGood.Location = new System.Drawing.Point(191, 367);
            this.condGood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condGood.Name = "condGood";
            this.condGood.Size = new System.Drawing.Size(85, 29);
            this.condGood.TabIndex = 9;
            this.condGood.TabStop = true;
            this.condGood.Text = "Good";
            this.condGood.UseVisualStyleBackColor = true;
            this.condGood.CheckedChanged += new System.EventHandler(this.condGood_CheckedChanged);
            // 
            // condNew
            // 
            this.condNew.AutoSize = true;
            this.condNew.Location = new System.Drawing.Point(191, 332);
            this.condNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condNew.Name = "condNew";
            this.condNew.Size = new System.Drawing.Size(76, 29);
            this.condNew.TabIndex = 8;
            this.condNew.TabStop = true;
            this.condNew.Text = "New";
            this.condNew.UseVisualStyleBackColor = true;
            this.condNew.CheckedChanged += new System.EventHandler(this.condNew_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Condition";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pageCount
            // 
            this.pageCount.Location = new System.Drawing.Point(158, 199);
            this.pageCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(380, 29);
            this.pageCount.TabIndex = 7;
            this.pageCount.TextChanged += new System.EventHandler(this.pageCount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Page Count";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "?";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // comboBookVsDvd
            // 
            this.comboBookVsDvd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBookVsDvd.FormattingEnabled = true;
            this.comboBookVsDvd.Items.AddRange(new object[] {
            "Book",
            "DVD"});
            this.comboBookVsDvd.Location = new System.Drawing.Point(170, 27);
            this.comboBookVsDvd.Name = "comboBookVsDvd";
            this.comboBookVsDvd.Size = new System.Drawing.Size(135, 32);
            this.comboBookVsDvd.TabIndex = 1;
            this.comboBookVsDvd.SelectedIndexChanged += new System.EventHandler(this.comboBookVsDvd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Add";
            // 
            // addBookPanel
            // 
            this.addBookPanel.Controls.Add(this.label6);
            this.addBookPanel.Controls.Add(this.label1);
            this.addBookPanel.Controls.Add(this.pageCount);
            this.addBookPanel.Controls.Add(this.bookTitle);
            this.addBookPanel.Controls.Add(this.label7);
            this.addBookPanel.Controls.Add(this.label2);
            this.addBookPanel.Controls.Add(this.author);
            this.addBookPanel.Controls.Add(this.label3);
            this.addBookPanel.Controls.Add(this.ISBN);
            this.addBookPanel.Controls.Add(this.label4);
            this.addBookPanel.Controls.Add(this.genre);
            this.addBookPanel.Location = new System.Drawing.Point(12, 72);
            this.addBookPanel.Name = "addBookPanel";
            this.addBookPanel.Size = new System.Drawing.Size(551, 253);
            this.addBookPanel.TabIndex = 2;
            // 
            // addDvdPanel
            // 
            this.addDvdPanel.Controls.Add(this.label17);
            this.addDvdPanel.Controls.Add(this.dvdTitle);
            this.addDvdPanel.Controls.Add(this.label19);
            this.addDvdPanel.Controls.Add(this.dvdGenre);
            this.addDvdPanel.Controls.Add(this.label20);
            this.addDvdPanel.Controls.Add(this.dvdYear);
            this.addDvdPanel.Location = new System.Drawing.Point(12, 72);
            this.addDvdPanel.Name = "addDvdPanel";
            this.addDvdPanel.Size = new System.Drawing.Size(551, 253);
            this.addDvdPanel.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 29);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "DVD Title";
            // 
            // dvdTitle
            // 
            this.dvdTitle.Location = new System.Drawing.Point(158, 21);
            this.dvdTitle.Margin = new System.Windows.Forms.Padding(4);
            this.dvdTitle.Name = "dvdTitle";
            this.dvdTitle.Size = new System.Drawing.Size(380, 29);
            this.dvdTitle.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 73);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "Genre";
            // 
            // dvdGenre
            // 
            this.dvdGenre.Location = new System.Drawing.Point(158, 66);
            this.dvdGenre.Margin = new System.Windows.Forms.Padding(4);
            this.dvdGenre.Name = "dvdGenre";
            this.dvdGenre.Size = new System.Drawing.Size(380, 29);
            this.dvdGenre.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 117);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 25);
            this.label20.TabIndex = 4;
            this.label20.Text = "Year";
            // 
            // dvdYear
            // 
            this.dvdYear.Location = new System.Drawing.Point(158, 110);
            this.dvdYear.Margin = new System.Windows.Forms.Padding(4);
            this.dvdYear.Name = "dvdYear";
            this.dvdYear.Size = new System.Drawing.Size(380, 29);
            this.dvdYear.TabIndex = 5;
            // 
            // bookAddForm
            // 
            this.AcceptButton = this.getData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(576, 574);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.condNew);
            this.Controls.Add(this.condGood);
            this.Controls.Add(this.condFair);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.condPoor);
            this.Controls.Add(this.comboBookVsDvd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.addBookPanel);
            this.Controls.Add(this.addDvdPanel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "bookAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.bookAddForm_Load);
            this.addBookPanel.ResumeLayout(false);
            this.addBookPanel.PerformLayout();
            this.addDvdPanel.ResumeLayout(false);
            this.addDvdPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox pageCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBookVsDvd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel addBookPanel;
        private System.Windows.Forms.Panel addDvdPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox dvdTitle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox dvdGenre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox dvdYear;
    }
}