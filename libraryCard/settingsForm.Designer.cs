namespace libraryCard
{
    partial class settingsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Defaults");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Empty");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Preference Settings", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.settingsTree = new System.Windows.Forms.TreeView();
            this.defaultsPanel = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxID_ISBN_sett = new System.Windows.Forms.ComboBox();
            this.comboBookVsDvd_sett = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.defaultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTree
            // 
            this.settingsTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsTree.Location = new System.Drawing.Point(0, 0);
            this.settingsTree.Name = "settingsTree";
            treeNode1.Name = "comboBoxDefaults";
            treeNode1.Text = "Defaults";
            treeNode2.Name = "Empty";
            treeNode2.Text = "Empty";
            treeNode3.Name = "preferenceTab";
            treeNode3.Text = "Preference Settings";
            this.settingsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.settingsTree.Size = new System.Drawing.Size(266, 649);
            this.settingsTree.TabIndex = 0;
            this.settingsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.settingsTree_AfterSelect);
            // 
            // defaultsPanel
            // 
            this.defaultsPanel.Controls.Add(this.cancelButton);
            this.defaultsPanel.Controls.Add(this.applyButton);
            this.defaultsPanel.Controls.Add(this.comboBookVsDvd_sett);
            this.defaultsPanel.Controls.Add(this.comboBoxID_ISBN_sett);
            this.defaultsPanel.Controls.Add(this.label2);
            this.defaultsPanel.Controls.Add(this.label1);
            this.defaultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultsPanel.Location = new System.Drawing.Point(266, 0);
            this.defaultsPanel.Name = "defaultsPanel";
            this.defaultsPanel.Size = new System.Drawing.Size(871, 649);
            this.defaultsPanel.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(266, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 649);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default choice in \"Add\" window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Default choice in \"Check-Out\" window:";
            // 
            // comboBoxID_ISBN_sett
            // 
            this.comboBoxID_ISBN_sett.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID_ISBN_sett.FormattingEnabled = true;
            this.comboBoxID_ISBN_sett.Items.AddRange(new object[] {
            "Book using ISBN",
            "Book using ID",
            "DVD using ID"});
            this.comboBoxID_ISBN_sett.Location = new System.Drawing.Point(427, 106);
            this.comboBoxID_ISBN_sett.Name = "comboBoxID_ISBN_sett";
            this.comboBoxID_ISBN_sett.Size = new System.Drawing.Size(284, 32);
            this.comboBoxID_ISBN_sett.TabIndex = 5;
            // 
            // comboBookVsDvd_sett
            // 
            this.comboBookVsDvd_sett.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBookVsDvd_sett.FormattingEnabled = true;
            this.comboBookVsDvd_sett.Items.AddRange(new object[] {
            "Book",
            "DVD"});
            this.comboBookVsDvd_sett.Location = new System.Drawing.Point(427, 46);
            this.comboBookVsDvd_sett.Name = "comboBookVsDvd_sett";
            this.comboBookVsDvd_sett.Size = new System.Drawing.Size(135, 32);
            this.comboBookVsDvd_sett.TabIndex = 4;
            // 
            // applyButton
            // 
            this.applyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.applyButton.Location = new System.Drawing.Point(289, 522);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(116, 41);
            this.applyButton.TabIndex = 23;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(442, 522);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 41);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // settingsForm
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1137, 649);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.defaultsPanel);
            this.Controls.Add(this.settingsTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.defaultsPanel.ResumeLayout(false);
            this.defaultsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView settingsTree;
        private System.Windows.Forms.Panel defaultsPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxID_ISBN_sett;
        private System.Windows.Forms.ComboBox comboBookVsDvd_sett;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
    }
}