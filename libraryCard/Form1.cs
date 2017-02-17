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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = teh.ddns.net;port = 3306; Initial Catalog = 'librarycard'; username = scrub; password=librarycard");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.searchSelection.SelectedIndex = 0;
            searchData();
        }

        public void searchData()
        {
            //Used on our search page, Allows user to search database with their specifications
            
            string query = "SELECT * FROM books WHERE " + this.searchSelection.Text + " LIKE '%" + this.searchText.Text + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            //Outputs Table
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Function for going to Form 3, which is reading in a customer to the database
            Form3 addCustomer = new Form3();
            if (Application.OpenForms[addCustomer.Name] == null)
                addCustomer.Show();
            else
                Application.OpenForms[addCustomer.Name].Focus();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            //Function for going to Form 2, which is reading in a book to the database
            Form2 addBook = new Form2();
            if (Application.OpenForms[addBook.Name] == null)
                addBook.Show();
            else
                Application.OpenForms[addBook.Name].Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Function for going to Form 4, which is used to remove a customer
            Form4 removeCustomer = new Form4();
            if (Application.OpenForms[removeCustomer.Name] == null)
                removeCustomer.Show();
            else
                Application.OpenForms[removeCustomer.Name].Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Function for going to Form 5, which is used to remove a book
            Form5 checkIn = new Form5();
            if (Application.OpenForms[checkIn.Name] == null)
                checkIn.Show();
            else
                Application.OpenForms[checkIn.Name].Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Function for going to Form 6, which is used to Check-Out a book to a customer
            Form6 checkOut = new Form6();
            if (Application.OpenForms[checkOut.Name] == null)
                checkOut.Show();
            else
                Application.OpenForms[checkOut.Name].Focus();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Function for going to Form 2, which is reading in a book to the database| from drop down menu
            Form2 addBook = new Form2();
            if (Application.OpenForms[addBook.Name] == null)
                addBook.Show();
            else
                Application.OpenForms[addBook.Name].Focus();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Function for going to Form 3, which is reading in a customer to the database| from drop down menu
            Form3 addCustomer = new Form3();
            if (Application.OpenForms[addCustomer.Name] == null)
                addCustomer.Show();
            else
                Application.OpenForms[addCustomer.Name].Focus();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Exits the program| from drop down menu
            Application.Exit();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Function for going to Form 6, which is used to Check-Out a book to a customer| from drop down menu
            Form6 checkOut = new Form6();
            if (Application.OpenForms[checkOut.Name] == null)
                checkOut.Show();
            else
                Application.OpenForms[checkOut.Name].Focus();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Function for going to Form 6, which is used to Check-In a book from a customer| from drop down menu
            Form5 checkIn = new Form5();
            if (Application.OpenForms[checkIn.Name] == null)
                checkIn.Show();
            else
                Application.OpenForms[checkIn.Name].Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void searchSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

