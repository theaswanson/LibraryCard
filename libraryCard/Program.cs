using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryCard
{
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

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
