namespace libraryCard
{
    partial class checkOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkOutForm));
            this.bookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBoxID_ISBN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookID
            // 
            this.bookID.Location = new System.Drawing.Point(202, 214);
            this.bookID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(285, 29);
            this.bookID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Book ID";
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(200, 135);
            this.customerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(286, 29);
            this.customerID.TabIndex = 3;
            this.customerID.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer ID";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(304, 296);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 41);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(149, 296);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 41);
            this.button4.TabIndex = 22;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBoxID_ISBN
            // 
            this.comboBoxID_ISBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID_ISBN.FormattingEnabled = true;
            this.comboBoxID_ISBN.Items.AddRange(new object[] {
            "Book using ISBN",
            "Book using ID",
            "DVD using ID"});
            this.comboBoxID_ISBN.Location = new System.Drawing.Point(203, 53);
            this.comboBoxID_ISBN.Name = "comboBoxID_ISBN";
            this.comboBoxID_ISBN.Size = new System.Drawing.Size(284, 32);
            this.comboBoxID_ISBN.TabIndex = 1;
            this.comboBoxID_ISBN.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_ISBN_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Check Out";
            // 
            // checkOutForm
            // 
            this.AcceptButton = this.button4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(568, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxID_ISBN);
            this.Controls.Add(this.bookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "checkOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checking Out";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBoxID_ISBN;
        private System.Windows.Forms.Label label3;
    }
}