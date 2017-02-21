namespace libraryCard
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.TextBox();
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
            this.button2.Location = new System.Drawing.Point(282, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(194, 49);
            this.fname.Margin = new System.Windows.Forms.Padding(4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(287, 29);
            this.fname.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Check-Out ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Condition";
            // 
            // condNew
            // 
            this.condNew.AutoSize = true;
            this.condNew.Location = new System.Drawing.Point(194, 116);
            this.condNew.Margin = new System.Windows.Forms.Padding(4);
            this.condNew.Name = "condNew";
            this.condNew.Size = new System.Drawing.Size(76, 29);
            this.condNew.TabIndex = 22;
            this.condNew.TabStop = true;
            this.condNew.Text = "New";
            this.condNew.UseVisualStyleBackColor = true;
            // 
            // condGood
            // 
            this.condGood.AutoSize = true;
            this.condGood.Location = new System.Drawing.Point(194, 151);
            this.condGood.Margin = new System.Windows.Forms.Padding(4);
            this.condGood.Name = "condGood";
            this.condGood.Size = new System.Drawing.Size(85, 29);
            this.condGood.TabIndex = 23;
            this.condGood.TabStop = true;
            this.condGood.Text = "Good";
            this.condGood.UseVisualStyleBackColor = true;
            // 
            // condFair
            // 
            this.condFair.AutoSize = true;
            this.condFair.Location = new System.Drawing.Point(194, 184);
            this.condFair.Margin = new System.Windows.Forms.Padding(4);
            this.condFair.Name = "condFair";
            this.condFair.Size = new System.Drawing.Size(70, 29);
            this.condFair.TabIndex = 24;
            this.condFair.TabStop = true;
            this.condFair.Text = "Fair";
            this.condFair.UseVisualStyleBackColor = true;
            // 
            // condPoor
            // 
            this.condPoor.AutoSize = true;
            this.condPoor.Location = new System.Drawing.Point(194, 221);
            this.condPoor.Margin = new System.Windows.Forms.Padding(4);
            this.condPoor.Name = "condPoor";
            this.condPoor.Size = new System.Drawing.Size(78, 29);
            this.condPoor.TabIndex = 25;
            this.condPoor.TabStop = true;
            this.condPoor.Text = "Poor";
            this.condPoor.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(545, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.condNew);
            this.Controls.Add(this.condGood);
            this.Controls.Add(this.condFair);
            this.Controls.Add(this.condPoor);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checking-In";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton condNew;
        private System.Windows.Forms.RadioButton condGood;
        private System.Windows.Forms.RadioButton condFair;
        private System.Windows.Forms.RadioButton condPoor;
    }
}