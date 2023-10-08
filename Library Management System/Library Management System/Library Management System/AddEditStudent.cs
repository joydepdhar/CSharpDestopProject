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
    public partial class Add_New_Member : UserControl
    {
        public Add_New_Member()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.studentID.Text) || String.IsNullOrEmpty(this.studentName.Text) ||
                String.IsNullOrEmpty(this.studentProgram.Text) || String.IsNullOrEmpty(this.studentSemester.Text) ||
                String.IsNullOrEmpty(this.studentContact.Text))
            {
                return false;
            }
            else
                return true;
        }
        private void btnUpdate(object sender, EventArgs e)
        {
            bool x = this.IsValidToSaveData();
            if (x == true)
            {
                DataAccess A = new DataAccess();
                string sID = studentID.Text;
                string sName = studentName.Text;
                string sProgram = studentProgram.Text;
                string semsester = studentSemester.Text;
                string contract = studentContact.Text;
                string Query = "Update Student SET Name='" + sName + "', Program='" + sProgram + "', Semester='" + semsester + "' , Password='" + contract + "' where ID='" + sID + "';";
                A.ExecuteDMLQuery(Query);
                MessageBox.Show(" Student Data Update");
            }
            else
            {
                MessageBox.Show("Please fill the  All Boxes");
            }

        }
        
        private void btnSave(object sender, EventArgs e)
        {
            bool x = this.IsValidToSaveData();
            if (x == true)
            {
                DataAccess A = new DataAccess();
                string Roll = "Student";
                string sID = studentID.Text;
                string sName = studentName.Text;
                string sProgram = studentProgram.Text;
                string semsester = studentSemester.Text;
                string contract = studentContact.Text;
                string Query = "insert into Student(Id, Name, Program,Semester,Password) Values('" + sID + "','" + sName + "','" + sProgram + "','" + semsester + "','" + contract + "');";
                A.ExecuteDMLQuery(Query);
                string SubQuery = "insert into AdminPerson(ID,Password,Roll) Values('" + sID + "','" + contract + "','" + Roll + "');";
                A.ExecuteDMLQuery(SubQuery);
                MessageBox.Show(" New Member Added");
            }
            else
            {
                MessageBox.Show("Please fill the  All Boxes");
            }
        }

        private void btnDelete(object sender, EventArgs e)
        {

            try
            {
                bool x = this.IsValidToSaveData();
                if (x == true)
                {
                    DataAccess A = new DataAccess();
                    string sID = studentID.Text;
                    string sName = studentName.Text;
                    string sProgram = studentProgram.Text;
                    string semsester = studentSemester.Text;
                    string contract = studentContact.Text;
                    string Query = "DELETE FROM Student WHERE ID ='" + sID + "'";
                    A.ExecuteDMLQuery(Query);
                    string subQuery = "DELETE FROM AdminPerson WHERE ID='" + sID + "'";
                    A.ExecuteDMLQuery(subQuery);
                    MessageBox.Show(" Data Delete");
                }
                else
                {
                    MessageBox.Show("Please fill the  All Boxes");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error found" + " " + exc.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            studentID.Clear();
            studentName.Clear();
            studentProgram.Clear();
            studentSemester.Clear();
            studentContact.Clear();
        }
    }
}
