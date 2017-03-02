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
    public partial class Form4 : Form
    {
        string field_, edit_;

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                fNameLabel.Show();
                editField.Show();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            fNameLabel.Hide();
            editField.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.comboBox1.Text) //converts English table options to database names
            {
                case "First Name":
                    field_ = "FName";
                    break;
                case "Last Name":
                    field_ = "LName";
                    break;
                case "Phone":
                    field_ = "phone";
                    break;
                case "Address":
                    field_ = "address";
                    break;
                case "Date of Birth":
                    field_ = "birthdate";
                    break;
                case "":
                    field_ = "errorInFieldSwitch";
                    break;
            }

            string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
            string Query = "USE librarycard UPDATE customers SET " + field_ + "=\"" + this.editField.Text + "\" WHERE customerID=" + this.id.Text + ";";
            //              UPDATE customers SET     FName     ='     text                   '  WHERE customerID=    1;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            MessageBox.Show("After query");

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Customer edited ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
