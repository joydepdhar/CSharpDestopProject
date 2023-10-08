using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class StaffDashBoard : UserControl
    {
        public StaffDashBoard()
        {
            InitializeComponent();
        }

        private void editBookDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_New_Books1.Show();
            bookDetails1.Hide();
            student_Details1.Hide();
            add_New_Member1.Hide();
            add_New_Books1.BringToFront();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Close The Application?", "Exit Maessage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuAddNewMember_Click(object sender, EventArgs e)
        {
           
            add_New_Books1.Hide();           
            bookDetails1.Hide();
            student_Details1.Hide();
            add_New_Member1.Show();
            add_New_Member1.BringToFront();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            add_New_Books1.Show();
            bookDetails1.Hide();
            student_Details1.Hide();
            add_New_Member1.Hide();
            add_New_Books1.BringToFront();
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            add_New_Books1.Hide();
            bookDetails1.Show();
            student_Details1.Hide();
            add_New_Member1.Hide();
            bookDetails1.BringToFront();
        }

        private void editBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_New_Books1.Hide();
            bookDetails1.Hide();
            student_Details1.Hide();
            add_New_Member1.Show();
            add_New_Member1.BringToFront();
        }
       
private void StaffDashBoard_Load(object sender, EventArgs e)
        {
            add_New_Books1.Hide();
            bookDetails1.Hide();
            student_Details1.Hide();
            add_New_Member1.Hide();
            bookDetails1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
