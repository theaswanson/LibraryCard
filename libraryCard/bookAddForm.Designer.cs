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
            this.conditionPoorRadioButton = new System.Windows.Forms.RadioButton();
            this.conditionFairRadioButton = new System.Windows.Forms.RadioButton();
            this.conditionGoodRadioButton = new System.Windows.Forms.RadioButton();
            this.conditionNewRadioButton = new System.Windows.Forms.RadioButton();
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
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(86, 11);
            this.bookTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(209, 20);
            this.bookTitle.TabIndex = 3;
            this.bookTitle.TextChanged += new System.EventHandler(this.bookTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author(s)";
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(86, 36);
            this.author.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(209, 20);
            this.author.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(86, 60);
            this.ISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(209, 20);
            this.ISBN.TabIndex = 5;
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(88, 270);
            this.getData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(57, 22);
            this.getData.TabIndex = 12;
            this.getData.Text = "Add";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(167, 270);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 22);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(86, 83);
            this.genre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(209, 20);
            this.genre.TabIndex = 6;
            // 
            // conditionPoorRadioButton
            // 
            this.conditionPoorRadioButton.AutoSize = true;
            this.conditionPoorRadioButton.Location = new System.Drawing.Point(104, 237);
            this.conditionPoorRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conditionPoorRadioButton.Name = "conditionPoorRadioButton";
            this.conditionPoorRadioButton.Size = new System.Drawing.Size(47, 17);
            this.conditionPoorRadioButton.TabIndex = 11;
            this.conditionPoorRadioButton.TabStop = true;
            this.conditionPoorRadioButton.Text = "Poor";
            this.conditionPoorRadioButton.UseVisualStyleBackColor = true;
            // 
            // conditionFairRadioButton
            // 
            this.conditionFairRadioButton.AutoSize = true;
            this.conditionFairRadioButton.Location = new System.Drawing.Point(104, 218);
            this.conditionFairRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conditionFairRadioButton.Name = "conditionFairRadioButton";
            this.conditionFairRadioButton.Size = new System.Drawing.Size(42, 17);
            this.conditionFairRadioButton.TabIndex = 10;
            this.conditionFairRadioButton.TabStop = true;
            this.conditionFairRadioButton.Text = "Fair";
            this.conditionFairRadioButton.UseVisualStyleBackColor = true;
            // 
            // conditionGoodRadioButton
            // 
            this.conditionGoodRadioButton.AutoSize = true;
            this.conditionGoodRadioButton.Location = new System.Drawing.Point(104, 199);
            this.conditionGoodRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conditionGoodRadioButton.Name = "conditionGoodRadioButton";
            this.conditionGoodRadioButton.Size = new System.Drawing.Size(51, 17);
            this.conditionGoodRadioButton.TabIndex = 9;
            this.conditionGoodRadioButton.TabStop = true;
            this.conditionGoodRadioButton.Text = "Good";
            this.conditionGoodRadioButton.UseVisualStyleBackColor = true;
            // 
            // conditionNewRadioButton
            // 
            this.conditionNewRadioButton.AutoSize = true;
            this.conditionNewRadioButton.Location = new System.Drawing.Point(104, 180);
            this.conditionNewRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conditionNewRadioButton.Name = "conditionNewRadioButton";
            this.conditionNewRadioButton.Size = new System.Drawing.Size(47, 17);
            this.conditionNewRadioButton.TabIndex = 8;
            this.conditionNewRadioButton.TabStop = true;
            this.conditionNewRadioButton.Text = "New";
            this.conditionNewRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Condition";
            // 
            // pageCount
            // 
            this.pageCount.Location = new System.Drawing.Point(86, 108);
            this.pageCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(209, 20);
            this.pageCount.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Page Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
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
            this.comboBookVsDvd.Location = new System.Drawing.Point(93, 15);
            this.comboBookVsDvd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBookVsDvd.Name = "comboBookVsDvd";
            this.comboBookVsDvd.Size = new System.Drawing.Size(75, 21);
            this.comboBookVsDvd.TabIndex = 1;
            this.comboBookVsDvd.SelectedIndexChanged += new System.EventHandler(this.comboBookVsDvd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
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
            this.addBookPanel.Location = new System.Drawing.Point(7, 39);
            this.addBookPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBookPanel.Name = "addBookPanel";
            this.addBookPanel.Size = new System.Drawing.Size(301, 137);
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
            this.addDvdPanel.Location = new System.Drawing.Point(7, 39);
            this.addDvdPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addDvdPanel.Name = "addDvdPanel";
            this.addDvdPanel.Size = new System.Drawing.Size(301, 137);
            this.addDvdPanel.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 16);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "DVD Title";
            // 
            // dvdTitle
            // 
            this.dvdTitle.Location = new System.Drawing.Point(86, 11);
            this.dvdTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvdTitle.Name = "dvdTitle";
            this.dvdTitle.Size = new System.Drawing.Size(209, 20);
            this.dvdTitle.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 40);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Genre";
            // 
            // dvdGenre
            // 
            this.dvdGenre.Location = new System.Drawing.Point(86, 36);
            this.dvdGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvdGenre.Name = "dvdGenre";
            this.dvdGenre.Size = new System.Drawing.Size(209, 20);
            this.dvdGenre.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 63);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Year";
            // 
            // dvdYear
            // 
            this.dvdYear.Location = new System.Drawing.Point(86, 60);
            this.dvdYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvdYear.Name = "dvdYear";
            this.dvdYear.Size = new System.Drawing.Size(209, 20);
            this.dvdYear.TabIndex = 5;
            // 
            // bookAddForm
            // 
            this.AcceptButton = this.getData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(314, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.conditionNewRadioButton);
            this.Controls.Add(this.conditionGoodRadioButton);
            this.Controls.Add(this.conditionFairRadioButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.conditionPoorRadioButton);
            this.Controls.Add(this.comboBookVsDvd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.addBookPanel);
            this.Controls.Add(this.addDvdPanel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.RadioButton conditionPoorRadioButton;
        private System.Windows.Forms.RadioButton conditionFairRadioButton;
        private System.Windows.Forms.RadioButton conditionGoodRadioButton;
        private System.Windows.Forms.RadioButton conditionNewRadioButton;
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