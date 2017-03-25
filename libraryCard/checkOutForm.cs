using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace libraryCard
{
    public partial class checkOutForm : Form
    {
        public checkOutForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBoxID_ISBN.SelectedIndex == 0) //Book using ISBN
            {

            }
            else if (comboBoxID_ISBN.SelectedIndex == 1) //Book using ID
            {
                string outDate = DateTime.Now.ToString("yyyyMMddHHmmss");
                string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
                string Query = "INSERT INTO librarycard.checkout (customerID,bookID,outDate) values('" + this.customerID.Text + "','" + this.bookID.Text + "','" + outDate + "') ;";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Book checked out.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBoxID_ISBN.SelectedIndex == 2) //DVD using ID
            {

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            foreach (Control gBoxes in Controls.OfType<GroupBox>())
                gBoxes.Hide();

            this.comboBoxID_ISBN.SelectedIndex = Properties.Settings.Default.checkOutChoice;
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxID_ISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control gBoxes in Controls.OfType<GroupBox>())
                gBoxes.Hide();

            if (comboBoxID_ISBN.SelectedIndex == 0)
                bookIsbnBox.Show();
            else if (comboBoxID_ISBN.SelectedIndex == 1)
                bookIdBox.Show();
            else if (comboBoxID_ISBN.SelectedIndex == 2)
                dvdIdBox.Show();

        }

        private void bookIdBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
