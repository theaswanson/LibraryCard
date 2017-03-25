﻿using System;
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
    public partial class bookAddForm : Form
    {
        public bookAddForm()
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
            //checks to see condition of book from 4 bool options
            string cond_ = "";

            if (condNew.Checked)
                cond_ = "New";
            else if (condGood.Checked)
                cond_ = "Good";
            else if (condFair.Checked)
                cond_ = "Fair";
            else if (condPoor.Checked)
                cond_ = "Poor";
            else
                cond_ = "";

            string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;

            //Console.WriteLine(bookTitle);0
            /*MessageBox.Show("Title: " + this.bookTitle.Text +
                "\nAuthor: " + this.author.Text +
                "\nISBN: " + this.ISBN.Text +
                "\nGenre: " + this.genre.Text +
                "\nYear Published: " + this.year.Text +
                "\nPage Count: " + this.pageCount.Text);*/

            string Query = "";

            if (comboBookVsDvd.SelectedIndex == 0) //adding a book
            {
                Query = "INSERT INTO librarycard.books (title,author,ISBN,genre,pageCount,bookCondition) values('" + this.bookTitle.Text + "','" + this.author.Text + "','" + this.ISBN.Text + "','" + this.genre.Text + "','" + this.pageCount.Text + "','" + cond_ + "') ;";
            }

            else if (comboBookVsDvd.SelectedIndex == 1) //adding a dvd
            {
                Query = "INSERT INTO librarycard.dvd (title,genre,year,dvdCondition) values('" + this.dvdTitle.Text + "','" + this.dvdGenre.Text + "','" + this.dvdYear.Text + "','" + cond_ + "') ;";
            }

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                if (comboBookVsDvd.SelectedIndex == 0)
                {
                    MessageBox.Show("Book Saved: \n" + "Title: " + this.bookTitle.Text +
                "\nAuthor: " + this.author.Text +
                "\nISBN: " + this.ISBN.Text +
                "\nGenre: " + this.genre.Text +
                "\nPage Count: " + this.pageCount.Text);
                    //    while (myReader.Read())
                    //    {                         pointless code
                    //    }
                }

                else if (comboBookVsDvd.SelectedIndex == 1)
                {
                    MessageBox.Show("DVD Saved: \n" + "Title: " + this.dvdTitle.Text +
                "\nGenre: " + this.dvdGenre.Text +
                "\nYear: " + this.dvdYear.Text);
                    //    while (myReader.Read())
                    //    {                         pointless code
                    //    }
                }
            }
            catch (Exception ex)
            {
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

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void bookAddForm_Load(object sender, EventArgs e)
        {
            foreach (Control gPanels in Controls.OfType<Panel>())
                gPanels.Hide();

            this.comboBookVsDvd.SelectedIndex = Properties.Settings.Default.addChoice;

            toolTip1.AutoPopDelay = 20000;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBookVsDvd_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control gPanels in Controls.OfType<Panel>())
                gPanels.Hide();

            if (comboBookVsDvd.SelectedIndex == 0)
                addBookPanel.Show();
            else if (comboBookVsDvd.SelectedIndex == 1)
                addDvdPanel.Show();
        }
    }
}
