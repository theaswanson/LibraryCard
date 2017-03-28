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
    public partial class bookEditForm : Form
    {
        string field_, edit_;

        public bookEditForm()
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
                isbnBox.Show();
            else if (comboBox1.SelectedIndex == 1)
                titleBox.Show();
            else if (comboBox1.SelectedIndex == 2)
                authorBox.Show();
            else if (comboBox1.SelectedIndex == 3)
                genreBox.Show();
            else if (comboBox1.SelectedIndex == 4)
                pageBox.Show();
            else if (comboBox1.SelectedIndex == 5)
                conditionBox.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (Control lbl in Controls.OfType<GroupBox>())
                lbl.Hide();
        }

        private void fNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                switch (this.comboBox1.Text) //converts English table options to database names
                {
                    //Books
                    case "Title":
                        field_ = "title";
                        edit_ = titleNum.Text;
                        break;
                    case "Author":
                        field_ = "author";
                        edit_ = author.Text;
                        break;
                    case "Genre":
                        field_ = "genre";
                        edit_ = genre.Text;
                        break;
                    case "ISBN":
                        field_ = "isbn";
                        edit_ = isbn.Text;
                        break;
                    case "Page Count":
                        field_ = "pageCount";
                        edit_ = page.Text;
                        break;
                    case "Condition":
                        field_ = "bookCondition";
                        if (condNew.Checked)
                            edit_ = "New";
                        else if (condGood.Checked)
                            edit_ = "Good";
                        else if (condFair.Checked)
                            edit_ = "Fair";
                        else if (condPoor.Checked)
                            edit_ = "Poor";
                        else
                            edit_ = "";
                        break;
                    case "":
                        field_ = "errorInFieldSwitch";
                        break;
                }

                string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
                string Query = "USE librarycard; UPDATE books SET " + field_ + "=\"" + edit_ + "\" WHERE bookID=" + this.id.Text + " ;";
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
                    MessageBox.Show("Book edited.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter a book ID.");
            }
            
        }
    }
}
