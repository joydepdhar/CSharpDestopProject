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
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

       

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnBookDetails_Click(object sender, EventArgs e)
        {
            bookDetails1.Show();
            issueBook1.Hide();
            checkStatus1.Hide();
            bookDetails1.BringToFront();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To LogOut?", "Exit Maessage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Have No Penalty.So,Your Balance Is O");
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            bookDetails1.Hide();
            issueBook1.Show();
            checkStatus1.Hide();
            issueBook1.BringToFront();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            bookDetails1.Hide();
            issueBook1.Hide();
            checkStatus1.Show();
            checkStatus1.BringToFront();
        }
    }
}
