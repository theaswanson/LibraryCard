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
        static string connecting_str = "datasource = " + db_type.db_hostname + ";port = " + db_type.db_port + "; Initial Catalog = 'librarycard'; username = " + db_type.db_username + "; password = " + db_type.db_pw;
        MySqlConnection connection = new MySqlConnection(connecting_str);
        //MySqlConnection connection = new MySqlConnection("datasource = teh.ddns.net;port = 3306; Initial Catalog = 'librarycard'; username = scrub; password=librarycard");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        

        string table_, field_;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.searchTable.SelectedIndex = 0; //selects first option by default
            this.searchSelection.SelectedIndex = 1; //selects first option by default
            searchData(); //search first table initially

            
            DataGridViewColumn bookID = dataGridView1.Columns[0];
            DataGridViewColumn ISBN = dataGridView1.Columns[1];
            DataGridViewColumn Title = dataGridView1.Columns[2];
            DataGridViewColumn Author = dataGridView1.Columns[3];
            DataGridViewColumn genre = dataGridView1.Columns[4];
            DataGridViewColumn pageCount = dataGridView1.Columns[5];
            DataGridViewColumn condition = dataGridView1.Columns[6];

            bookID.Width = 45;
            ISBN.Width = 110;
            Title.Width = 350;
            Author.Width = 130;
            genre.Width = 80;
            pageCount.Width = 50;
            condition.Width = 57;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void searchData()
        {
            //Used on our search page, Allows user to search database with their specifications

            switch (this.searchTable.Text) //converts English table options to database names
            {
                case "Books":
                    table_ = "books";
                    break;
                case "Customers":
                    table_ = "customers";
                    break;
                case "Checkout":
                    table_ = "checkout";
                    break;
                case "":
                    table_ = "errorInTableSwitch";
                    break;
            }

            switch (this.searchSelection.Text) //converts English field options to database names
            {
                //Books
                case "Book ID":
                    field_ = "bookID";
                    break;
                case "Title":
                    field_ = "title";
                    break;
                case "Author":
                    field_ = "author";
                    break;
                case "Genre":
                    field_ = "genre";
                    break;
                case "ISBN":
                    field_ = "isbn";
                    break;

                //Customers
                case "Customer ID":
                    field_ = "customerID";
                    break;
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
                case "Birthdate":
                    field_ = "birthdate";
                    break;

                //Checkout
                /*case "Check-out date":
                    field_ = "outDate";
                    break;
                case "Check-in date":
                    field_ = "inDate";
                    break;*/
                case "Checkout ID":
                    field_ = "checkoutID";
                    break;
                case "Book Status":
                    field_ = "bookStatus";
                    break;
                case "":
                    table_ = "errorInFieldSwitch";
                    break;
            }

            if (table_ == "customers" && this.searchText.Text == "")
            {
                //don't search
            }
            else
            {
                string[] badChars = { ";", "'" };
                foreach (string x in badChars) //check for unallowed characters
                {
                    if (this.searchText.Text.Contains(x)) //if search contains bad character
                    {
                        this.searchText.Text = ""; //set search text to blank
                    }
                }

                string query;

                if (table_ == "checkout")
                {
                    if (field_ == "checkoutID")
                    {
                        query = "SELECT * FROM " + table_ + " WHERE " + field_ + " LIKE '%" + this.searchText.Text + "%'";
                    }
                    if (field_ == "LName")
                    {
                        query = "SELECT * FROM checkout,customers,books WHERE customers.customerID IN (SELECT customerID FROM customers WHERE LName = \"" + this.searchText.Text + "\" AND customerID = checkout.customerID AND books.bookID = checkout.bookID)";
                    }
                    else
                    {
                        query = "SELECT * FROM " + table_ + " WHERE " + field_ + " LIKE '%" + this.searchText.Text + "%'";
                    }

                }
                else
                {
                    query = "SELECT * FROM " + table_ + " WHERE " + field_ + " LIKE '%" + this.searchText.Text + "%'";
                }
                
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                //Outputs Table
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

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

        private void searchTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchSelection.Items.Clear(); //clears field selections that may exist in different tables

            if (this.searchTable.Text == "Books") //if books table is selected
            {
                //present book fields

                searchSelection.Items.Add("Book ID");
                searchSelection.Items.Add("Title");
                searchSelection.Items.Add("Author");
                searchSelection.Items.Add("Genre");
                searchSelection.Items.Add("ISBN");

                this.searchSelection.SelectedIndex = 1; //selects first option by default
            }
            else if (this.searchTable.Text == "Customers") //if checkout table is selected
            {
                //present checkout fields

                searchSelection.Items.Add("Customer ID");
                searchSelection.Items.Add("First Name");
                searchSelection.Items.Add("Last Name");
                searchSelection.Items.Add("Phone");
                searchSelection.Items.Add("Address");
                searchSelection.Items.Add("Birthdate");

                this.searchSelection.SelectedIndex = 2; //selects first option by default
            }
            else if (this.searchTable.Text == "Checkout") //if checkout table is selected
            {
                //present checkout fields

                searchSelection.Items.Add("Checkout ID");
                searchSelection.Items.Add("Customer ID");
                searchSelection.Items.Add("Last Name");
                searchSelection.Items.Add("Book ID");
                //searchSelection.Items.Add("Check-out date");
                //searchSelection.Items.Add("Check-in date");
                searchSelection.Items.Add("Book Status");

                this.searchSelection.SelectedIndex = 0; //selects first option by default
            }

            
        }

        private void searchSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

