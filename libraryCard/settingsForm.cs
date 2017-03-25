using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryCard
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //   if (comboBookVsDvd.SelectedIndex == 0)
            //       addBookPanel.Show();
            //   else if (comboBookVsDvd.SelectedIndex == 1)
            //       addDvdPanel.Show();

            foreach (Control gPanels in Controls.OfType<Panel>())
                gPanels.Hide();

            switch (settingsTree.SelectedNode.Name)
            {
                case "comboBoxDefaults":
                    defaultsPanel.Show();
                    break;
                case "Empty":
                    break;
            }
        }
        private void settingsForm_Load(object sender, EventArgs e)
        {
            settingsTree.ExpandAll();
            this.comboBookVsDvd_sett.SelectedIndex = Properties.Settings.Default.addChoice;
            this.comboBoxID_ISBN_sett.SelectedIndex = Properties.Settings.Default.checkOutChoice;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.addChoice = comboBookVsDvd_sett.SelectedIndex;
            Properties.Settings.Default.checkOutChoice = comboBoxID_ISBN_sett.SelectedIndex;
            MessageBox.Show("Settings Saved");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
