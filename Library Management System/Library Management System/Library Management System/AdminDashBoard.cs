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
    public partial class AdminDashBoard : UserControl
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Student_Details studentDetails = new Student_Details();
            this.Controls.Add(studentDetails);
            studentDetails.Show();
            this.pictureBox1.Visible = false;*/
            addNewStaff1.Hide();
            add_New_Books1.Hide();
            staffDetails1.Hide();
            bookDetails1.Hide();
            student_Details1.Show();
            add_New_Member1.Hide();
            student_Details1.BringToFront();



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Close The Application?", "Exit Maessage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AddNewStudent_Click(object sender, EventArgs e)
        {
            /* Add_New_Member add_New_Member = new Add_New_Member();
             this.panel1.Controls.Add(add_New_Member);
             add_New_Member.Show();
             this.pictureBox1.Visible = false;*/
            addNewStaff1.Hide();
            add_New_Books1.Hide();
            staffDetails1.Hide();
            bookDetails1.Hide();
            student_Details1.Hide();
            add_New_Member1.Show();
            add_New_Member1.BringToFront();

            

        }

        private void addNewStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*AddNewStaff addNewStaff = new AddNewStaff();
            this.panel1.Controls.Add(addNewStaff);
            addNewStaff.Show();
            this.pictureBox1.Visible = false;*/
            addNewStaff1.Show();
            add_New_Books1.Hide();
            staffDetails1.Hide();
            bookDetails1.Hide();
            student_Details1.Hide();
            add_New_Member1.Hide();
            addNewStaff1.BringToFront();



        }

        private void stuffDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*StaffDetails staffDetails = new StaffDetails();
            this.panel1.Controls.Add(staffDetails);
            staffDetails.Show();
            this.pictureBox1.Visible = false;*/
            addNewStaff1.Hide();
            add_New_Books1.Hide();
            staffDetails1.Show();
            bookDetails1.Hide();
            student_Details1.Hide();
            add_New_Member1.Hide();
            staffDetails1.BringToFront();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Add_New_Books add_New_Books = new Add_New_Books();
            this.panel1.Controls.Add(add_New_Books);
            add_New_Books.Show();
            this.pictureBox1.Visible = false;*/
            addNewStaff1.Hide();
            add_New_Books1.Show();
            staffDetails1.Hide();
            bookDetails1.Hide();
            student_Details1.Hide();
            add_New_Member1.Hide();
            add_New_Books1.BringToFront();

        }

        private void bookDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /* BookDetails bookDetails = new BookDetails();
             this.panel1.Controls.Add(bookDetails);
             bookDetails.Show();
             this.pictureBox1.Visible = false;*/
            
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {

            addNewStaff1.Hide();
            add_New_Books1.Hide();
            staffDetails1.Hide();
            student_Details1.Hide();
            student_Details1.Hide();
            add_New_Member1.Hide();
            this.pictureBox1.Visible = true;
            

        }

        private void bookDetailsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            addNewStaff1.Hide();
            add_New_Books1.Hide();
            staffDetails1.Hide();
            bookDetails1.Show();
            student_Details1.Hide();
            add_New_Member1.Hide();
            bookDetails1.BringToFront();
        }

        private void menuAddNew_Click(object sender, EventArgs e)
        {

        }
    }
      
}