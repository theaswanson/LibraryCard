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
    public partial class bookAddForm : Form
    {
        public bookAddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            // Get item condition from the currently selected radio button
            string condition = "";

            if (conditionNewRadioButton.Checked)
                condition = "New";
            else if (conditionGoodRadioButton.Checked)
                condition = "Good";
            else if (conditionFairRadioButton.Checked)
                condition = "Fair";
            else if (conditionPoorRadioButton.Checked)
                condition = "Poor";
            else
                condition = "";

            string connectionString = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
            string query = "";

            if (comboBookVsDvd.SelectedIndex == 0) //adding a book
                query = "INSERT INTO librarycard.books (title,author,ISBN,genre,pageCount,bookCondition) values('" + this.bookTitle.Text + "','" + this.author.Text + "','" + this.ISBN.Text + "','" + this.genre.Text + "','" + this.pageCount.Text + "','" + condition + "') ;";
            else if (comboBookVsDvd.SelectedIndex == 1) //adding a dvd
                query = "INSERT INTO librarycard.dvd (title,genre,year,dvdCondition) values('" + this.dvdTitle.Text + "','" + this.dvdGenre.Text + "','" + this.dvdYear.Text + "','" + condition + "') ;";
            
            MySqlConnection connectionDatabase = new MySqlConnection(connectionString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, connectionDatabase);
            MySqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = cmdDataBase.ExecuteReader();

                if (comboBookVsDvd.SelectedIndex == 0)
                {
                    MessageBox.Show("Book Saved: \n" + "Title: " + this.bookTitle.Text +
                "\nAuthor: " + this.author.Text +
                "\nISBN: " + this.ISBN.Text +
                "\nGenre: " + this.genre.Text +
                "\nPage Count: " + this.pageCount.Text);
                }
                else if (comboBookVsDvd.SelectedIndex == 1)
                {
                    MessageBox.Show("DVD Saved: \n" + "Title: " + this.dvdTitle.Text +
                "\nGenre: " + this.dvdGenre.Text +
                "\nYear: " + this.dvdYear.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void bookTitle_TextChanged(object sender, EventArgs e)
        {
            string title = bookTitle.Text;
        }

        private void bookAddForm_Load(object sender, EventArgs e)
        {
            foreach (Control gPanels in Controls.OfType<Panel>())
                gPanels.Hide();

            this.comboBookVsDvd.SelectedIndex = Properties.Settings.Default.addChoice;

            toolTip1.AutoPopDelay = 20000;
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
