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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void condGood_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void condPoor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void getData_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(bookTitle);0
            /*MessageBox.Show("Title: " + this.bookTitle.Text +
                "\nAuthor: " + this.author.Text +
                "\nISBN: " + this.ISBN.Text +
                "\nGenre: " + this.genre.Text +
                "\nYear Published: " + this.year.Text +
                "\nPage Count: " + this.pageCount.Text);*/


            //checks to see condition of book from 4 bool options
            string cond_ = "";

            if (condNew.Checked == true)
                cond_ = "New";

            else if (condGood.Checked == true)
                cond_ = "Good";

            else if (condFair.Checked == true)
                cond_ = "Fair";

            else if (condPoor.Checked == true)
                cond_ = "Poor";

            else
                cond_ = "";


            string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
     //     string constring = "datasource=teh.ddns.net;port=3306;username=scrub;password=librarycard";
            string Query = "INSERT INTO librarycard.books (title,author,ISBN,genre,pageCount,bookCondition) values('" + this.bookTitle.Text + "','" + this.author.Text + "','" + this.ISBN.Text + "','" + this.genre.Text + "','" + this.pageCount.Text + "','" + cond_ + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Book Saved: \n" + "Title: " + this.bookTitle.Text +
                "\nAuthor: " + this.author.Text +
                "\nISBN: " + this.ISBN.Text +
                "\nGenre: " + this.genre.Text +
                "\nPage Count: " + this.pageCount.Text);
            //    while (myReader.Read())
            //    {
            //    }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void condFair_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bookTitle_TextChanged(object sender, EventArgs e)
        {
            string title = bookTitle.Text;
        }

        private void year_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void condNew_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void author_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void genre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pageCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
