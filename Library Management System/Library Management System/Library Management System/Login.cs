using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      

        private void txtId_MouseEnter(object sender, EventArgs e)
        {
            if (txtId.Text == "Enter Your ID")
            {
                txtId.Clear();
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string iD = txtId.Text;
            string Pass = txtPassword.Text;
            string sql = "select * from AdminPerson where Id = '" + txtId.Text + "' and Password = '" + this.txtPassword.Text + "';";
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-0R9GCN4;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login Valid");
                string name = ds.Tables[0].Rows[0][2].ToString();

                if (ds.Tables[0].Rows[0][2].ToString() == "admin")
                {
                    AdminDashBoard adminDashBoard = new AdminDashBoard();
                    this.panel2.Controls.Add(adminDashBoard);
                    adminDashBoard.Show();
                    this.panel1.Visible = false;
                    this.panel3.Visible = false;
                    this.panel4.Visible = false;
                    this.pictureBox4.Visible = false;
                    this.btnClose.Visible = false;
                    this.label4.Visible = false;
                    this.btnlogIn.Visible = false;
                    this.btnForgetPassword.Visible = false;

                }
                else if (ds.Tables[0].Rows[0][2].ToString() == "Student")
                {
                    StudentDashBoard studentDashBoard = new StudentDashBoard();
                    //this.panel2.Controls.Add(studentDashBoard);
                    studentDashBoard.Show();
                    this.panel1.Visible = false;
                    this.panel3.Visible = false;
                    this.panel4.Visible = false;
                    this.pictureBox4.Visible = false;
                    this.btnClose.Visible = false;
                    this.label4.Visible = false;
                    this.btnlogIn.Visible = false;
                    this.btnForgetPassword.Visible = false;

                    this.pictureBox1.Visible = true;

                }
                else if (ds.Tables[0].Rows[0][2].ToString() == "Stuff")
                {
                    StaffDashBoard staffDashBoard = new StaffDashBoard();
                    this.panel2.Controls.Add(staffDashBoard);
                    staffDashBoard.Show();
                    this.panel1.Visible = false;
                    this.panel3.Visible = false;
                    this.panel4.Visible = false;
                    this.pictureBox4.Visible = false;
                    this.btnClose.Visible = false;
                    this.label4.Visible = false;
                    this.btnlogIn.Visible = false;
                    this.btnForgetPassword.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Error LogIn Failed");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Close The Application?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact With IT Department Or Sent an Email To admin@admin.gmail.com");
        }
    }
}
