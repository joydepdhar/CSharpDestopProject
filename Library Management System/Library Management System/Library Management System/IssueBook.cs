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
    public partial class IssueBook : UserControl
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void lblBookID_Click(object sender, EventArgs e)
        {

        }

        private void lblBookName_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentId_Click(object sender, EventArgs e)
        {

        }

        private void lblReturnDate_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            DataAccess A = new DataAccess();
            string stId = studentID.Text;
            string stName = StudentName.Text;
            string BId = BookIDIssue.Text;
            string BName = BookName.Text;
            string Data1 = dateTimePicker1.Text;
            string Data2 = dateTimePicker2.Text;
            MessageBox.Show("Your book has been issued Please Contact Stuff to update");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.studentID.Clear();
            this.StudentName.Clear();   
            this.BookName.Clear();
            this.BookIDIssue.Clear();
            this.dateTimePicker1.Value = DateTime.Now; 
            this.dateTimePicker2.Value = DateTime.Now;
        }
    }
}
