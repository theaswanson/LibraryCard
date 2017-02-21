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
    public partial class logInForm : Form
    {
        public logInForm()
        {
            InitializeComponent();
            textBox4.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Missing fields.");

            else if (int.TryParse(textBox2.Text, out n))
            {
                string connect = "datasource=" + textBox1.Text + ";port=" + textBox2.Text + ";username=" + textBox3.Text + ";password=" + textBox4.Text;
                MySqlConnection conDataBase = new MySqlConnection(connect);

                    try
                {
                    conDataBase.Open();

                    db_type.db_hostname = textBox1.Text;
                    db_type.db_port = textBox2.Text;
                    db_type.db_username = textBox3.Text;
                    db_type.db_pw = textBox4.Text;

                    Form1 menu = new Form1();
                    menu.Show();
                    this.Hide();
                }

                catch (Exception ex)
                {
                    string passCheck = ex.Message.ToString();
                    passCheck = passCheck.Substring(0, 23) + passCheck.Substring(passCheck.Length - 21, 21);
                    if (passCheck == "Access denied for user (using password: YES)")
                        MessageBox.Show("Wrong username or password.");
                    else
                        MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Wrong port.");

        }

        private void logInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
