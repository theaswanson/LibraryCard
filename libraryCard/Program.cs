using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryCard
{
    class bookType
    {
        //variables

        private int bookID;
        private string ISBN;
        private string title;
        private string author;
        private string genre;
        private int pageCount;
        private string bookCondition;


        /* print functions */
        public void print()
        {
            //pull info from the "books" table, store in variables, then print information
        }


        /* lookup functions */
        public void bookFind()
        {
            //print book information from the "books" table, given bookID
        }


        /* set functions */

        public void setID(int ID)
        {
            bookID = ID;
        }
        public void setISBN(string isbn)
        {
            ISBN = isbn;
        }
        public void setTitle(string name)
        {
            title = name;
        }
        public void setAuthor(string name)
        {
            author = name;
        }
        public void setGenre(string name)
        {
            genre = name;
        }
        public void setPageCount(int num)
        {
            pageCount = num;
        }
        public void setCondition(string condition)
        {
            bookCondition = condition;
        }


        /* checkout functions */

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
        private int customerID;
        private string FName;
        private string LName;
        private string phone;
        private string address;
        private string birthdate;
        private bool bookStat;
        private string bookCheck;


        /* print functions */
        public void print()
        {
            //print customer information from the "customers" table, given customerID
        }

        /* set functions */

        public void setID(int ID)
        {
            customerID = ID;
        }
        public void setName(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }
        public void setPhone(string phoneNum)
        {
            phone = phoneNum;
        }
        public void setBirth(string date)
        {
            birthdate = date;
        }

    }

    public static class db_type
    {
        public static string db_hostname;
        public static string db_port;
        public static string db_username;
        public static string db_pw;
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
            //Application.Run(new Form1()); // start program with the menu
            Application.Run(new logInForm()); // start program the login form
        }
    }
}
