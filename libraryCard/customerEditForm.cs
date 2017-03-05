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
    public partial class customerEditForm : Form
    {
        string field_, edit_;

        public customerEditForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control lbl in Controls.OfType<GroupBox>())
                lbl.Hide();

            if (comboBox1.SelectedIndex == 0)
                fNameBox.Show();
            else if (comboBox1.SelectedIndex == 1)
                lNameBox.Show();
            else if (comboBox1.SelectedIndex == 2)
                phoneBox.Show();
            else if (comboBox1.SelectedIndex == 3)
                addressBox.Show();
            else if (comboBox1.SelectedIndex == 4)
                DateOfBirthBox.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (Control lbl in Controls.OfType<GroupBox>())
                lbl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                switch (this.comboBox1.Text) //converts English table options to database names
                {
                    case "First Name":
                        field_ = "FName";
                        edit_ = fName.Text;
                        break;
                    case "Last Name":
                        field_ = "LName";
                        edit_ = lName.Text;
                        break;
                    case "Phone":
                        field_ = "phone";
                        edit_ = phoneNum.Text;
                        break;
                    case "Address":
                        field_ = "address";
                        edit_ = this.stAd.Text + " " + this.city.Text + ", " + this.state.Text + " " + this.zip.Text;
                        break;
                    case "Date of Birth":
                        field_ = "birthdate";
                        edit_ = this.month.Text + "/" + this.day.Text + "/" + this.year.Text;
                        break;
                    case "":
                        field_ = "errorInFieldSwitch";
                        break;
                }

                string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
                string Query = "USE librarycard; UPDATE customers SET " + field_ + "=\"" + edit_ + "\" WHERE customerID=" + this.id.Text + " ;";
                //              UPDATE customers SET     FName     ='     text                   '  WHERE customerID=    1;
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                /*
                int affected = cmdDataBase.ExecuteNonQuery();
                if (affected == 0)
                {
                    MessageBox.Show("No rows affected.");
                }
                else
                {
                    MessageBox.Show("Customer edited.");
                }
                */

                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    //MySqlCommand comm;
                    MessageBox.Show("Customer edited.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter a customer ID.");
            }
            
        }
    }
}
