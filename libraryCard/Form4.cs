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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fNameLabel.Hide();
            fName.Hide();
            lNameLabel.Hide();
            lName.Hide();
            phoneNumLabel.Hide();
            phoneNum.Hide();
            stAdLab.Hide();
            stAd.Hide();
            cityLab.Hide();
            city.Hide();
            stateLab.Hide();
            state.Hide();
            zipLab.Hide();
            zip.Hide();
            dateBirthLab.Hide();
            mLab.Hide();
            month.Hide();
            dLab.Hide();
            day.Hide();
            yLab.Hide();
            year.Hide();
            slash1Lab.Hide();
            slash2Lab.Hide();

            if (comboBox1.SelectedIndex == 0)
            {
                fNameLabel.Show();
                fName.Show();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                lNameLabel.Show();
                lName.Show();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                phoneNumLabel.Show();
                phoneNum.Show();
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                stAdLab.Show();
                stAd.Show();
                cityLab.Show();
                city.Show();
                stateLab.Show();
                state.Show();
                zipLab.Show();
                zip.Show();
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                dateBirthLab.Show();
                mLab.Show();
                month.Show();
                dLab.Show();
                day.Show();
                yLab.Show();
                year.Show();
                slash1Lab.Show();
                slash2Lab.Show();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            fNameLabel.Hide();
            fName.Hide();
            lNameLabel.Hide();
            lName.Hide();
            phoneNumLabel.Hide();
            phoneNum.Hide();
            stAdLab.Hide();
            stAd.Hide();
            cityLab.Hide();
            city.Hide();
            stateLab.Hide();
            state.Hide();
            zipLab.Hide();
            zip.Hide();
            dateBirthLab.Hide();
            mLab.Hide();
            month.Hide();
            dLab.Hide();
            day.Hide();
            yLab.Hide();
            year.Hide();
            slash1Lab.Hide();
            slash2Lab.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
