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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 checkIn = new Form5();
            checkIn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 removeCustomer = new Form4();
            removeCustomer.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 checkOut = new Form6();
            checkOut.Show();
        }
    }
}

