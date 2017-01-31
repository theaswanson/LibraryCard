using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 addBook = new Form2();
            addBook.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 addCustomer = new Form3();
            addCustomer.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addBook = new Form2();
            addBook.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 addCustomer = new Form3();
            addCustomer.Show();
        }

        class bookType
        {
            private string ISBN;
            private string ID;
            private string title;
            private string author;
            private bool inStock;
            private string genre;
            private string condition;

            public void getBookInfo()
            {

            }
            public void bookFind()
            {

            }
            public void checkOut()
            {

            }
            public void checkIn()
            {

            }
        }

        class customerType
        {
            private string name;
            private string address;
            private int phoneNum;
            private bool bookStat;
            private string bookCheck;

            public void getInfo()
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

