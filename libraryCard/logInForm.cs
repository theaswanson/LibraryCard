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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = "datasource=" + textBox1.Text + ";port=" + textBox2.Text + ";username=" + textBox3.Text + ";password=" + textBox4.Text;
            MySqlConnection conDataBase = new MySqlConnection(connect);

                try
                {
                    conDataBase.Open();
                Form1 menu = new Form1();
                if (Application.OpenForms[menu.Name] == null)
                    menu.Show();
                else
                    Application.OpenForms[menu.Name].Focus();
            }

                catch (Exception ex)
                {
                   // if (ex == "")
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
