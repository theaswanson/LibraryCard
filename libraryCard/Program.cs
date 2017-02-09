using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryCard
{
    class bookType
    {
        private string bookID;
        private string ISBN;
        private string title;
        private string author;
        private string genre;
        private string pageCount;
        private string bookCondition;

        public void getBookInfo()
        {
            //pull info from the "books" table, store in variables, then print information
        }
        public void bookFind()
        {
            //print book information from the "books" table, given bookID
        }
        public void checkOut()
        {
            //generate checkoutID
            //get customerID, bookID, outDate, bookCondition
            //set bookStatus to "on time"
        }
        public void checkIn()
        {
            //get checkoutID
            //set inDate to current time
            //set bookStatus to "checked in"
        }
    }

    class customerType
    {
        private string customerID;
        private string FName;
        private string LName;
        private string phone;
        private string address;
        private string birthdate;
        private bool bookStat;
        private string bookCheck;

        public void getInfo()
        {
            //print customer information from the "customers" table, given customerID
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
