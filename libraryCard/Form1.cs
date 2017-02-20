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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.searchSelection.SelectedIndex = 0;
            searchData();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void searchData()
        {
            string query = "SELECT * FROM books WHERE " + this.searchSelection.Text + " LIKE '%" + this.searchText.Text + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 addCustomer = new Form3();
            if (Application.OpenForms[addCustomer.Name] == null)
                addCustomer.Show();
            else
                Application.OpenForms[addCustomer.Name].Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(db_type.db_hostname);
            Form2 addBook = new Form2();
            if (Application.OpenForms[addBook.Name] == null)
                addBook.Show();
            else
                Application.OpenForms[addBook.Name].Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 removeCustomer = new Form4();
            if (Application.OpenForms[removeCustomer.Name] == null)
                removeCustomer.Show();
            else
                Application.OpenForms[removeCustomer.Name].Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 checkIn = new Form5();
            if (Application.OpenForms[checkIn.Name] == null)
                checkIn.Show();
            else
                Application.OpenForms[checkIn.Name].Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
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
            Form2 addBook = new Form2();
            if (Application.OpenForms[addBook.Name] == null)
                addBook.Show();
            else
                Application.OpenForms[addBook.Name].Focus();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            Application.Exit();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 checkOut = new Form6();
            if (Application.OpenForms[checkOut.Name] == null)
                checkOut.Show();
            else
                Application.OpenForms[checkOut.Name].Focus();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

