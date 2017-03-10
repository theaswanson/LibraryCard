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
    public partial class checkInForm : Form
    {
        public checkInForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load_1(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string inDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
            string Query = "USE librarycard; UPDATE checkout SET " + "inDate" + "=\"" + inDate + "\" WHERE checkoutID=" + this.idField.Text + " ; UPDATE checkout SET bookStatus=\"complete\" WHERE checkoutID=" + this.idField.Text + " ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Book checked in.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*
            string inDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
            string query = "UPDATE checkout SET inDate='',bookCondition=''  WHERE checkoutID=;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Book checked in successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
        
    }
}
