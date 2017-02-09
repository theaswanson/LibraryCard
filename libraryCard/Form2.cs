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
            //Console.WriteLine(bookTitle);
            MessageBox.Show("Title: " + this.bookTitle.Text +
                "\nAuthor: " + this.author.Text +
                "\nISBN: " + this.ISBN.Text +
                "\nGenre: " + this.genre.Text +
                "\nYear Published: " + this.year.Text +
                "\nPage Count: " + this.pageCount.Text);
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
