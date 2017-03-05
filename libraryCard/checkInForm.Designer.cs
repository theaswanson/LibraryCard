namespace libraryCard
{
    partial class checkInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkInForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.condNew = new System.Windows.Forms.RadioButton();
            this.condGood = new System.Windows.Forms.RadioButton();
            this.condFair = new System.Windows.Forms.RadioButton();
            this.condPoor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(154, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 22);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 22);
            this.button1.TabIndex = 26;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(106, 27);
            this.idField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(158, 20);
            this.idField.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Check-Out ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Condition";
            // 
            // condNew
            // 
            this.condNew.AutoSize = true;
            this.condNew.Location = new System.Drawing.Point(105, 61);
            this.condNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.condNew.Name = "condNew";
            this.condNew.Size = new System.Drawing.Size(47, 17);
            this.condNew.TabIndex = 22;
            this.condNew.TabStop = true;
            this.condNew.Text = "New";
            this.condNew.UseVisualStyleBackColor = true;
            // 
            // condGood
            // 
            this.condGood.AutoSize = true;
            this.condGood.Location = new System.Drawing.Point(105, 80);
            this.condGood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.condGood.Name = "condGood";
            this.condGood.Size = new System.Drawing.Size(51, 17);
            this.condGood.TabIndex = 23;
            this.condGood.TabStop = true;
            this.condGood.Text = "Good";
            this.condGood.UseVisualStyleBackColor = true;
            // 
            // condFair
            // 
            this.condFair.AutoSize = true;
            this.condFair.Location = new System.Drawing.Point(105, 98);
            this.condFair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.condFair.Name = "condFair";
            this.condFair.Size = new System.Drawing.Size(42, 17);
            this.condFair.TabIndex = 24;
            this.condFair.TabStop = true;
            this.condFair.Text = "Fair";
            this.condFair.UseVisualStyleBackColor = true;
            // 
            // condPoor
            // 
            this.condPoor.AutoSize = true;
            this.condPoor.Location = new System.Drawing.Point(105, 117);
            this.condPoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.condPoor.Name = "condPoor";
            this.condPoor.Size = new System.Drawing.Size(47, 17);
            this.condPoor.TabIndex = 25;
            this.condPoor.TabStop = true;
            this.condPoor.Text = "Poor";
            this.condPoor.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(297, 202);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.condNew);
            this.Controls.Add(this.condGood);
            this.Controls.Add(this.condFair);
            this.Controls.Add(this.condPoor);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checking-In";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form5_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton condNew;
        private System.Windows.Forms.RadioButton condGood;
        private System.Windows.Forms.RadioButton condFair;
        private System.Windows.Forms.RadioButton condPoor;
    }
}