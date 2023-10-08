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
    
    public partial class Student_Details : UserControl
    {
        private DataAccess Lb { get; set; }
        public Student_Details()
        {
            InitializeComponent();
            this.Lb = new DataAccess();
        }
        private void PopulateGridView(string sql = "Select ID, Name, Program , Semester from Student;")
        {
            var ds = this.Lb.ExecuteQuery(sql);
            this.dataViewTableHero.AutoGenerateColumns = false;
            this.dataViewTableHero.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.PopulateGridView();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Close The Application?", "Exit Maessage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnStSearch_Click(object sender, EventArgs e)
        {
            try 
            {
                bool x = String.IsNullOrEmpty(studentSearchBar.Text);
                if (x == false)
                {
                    string stId = studentSearchBar.Text;
                    string stName = studentSearchBar.Text;
                    DataAccess B = new DataAccess();
                    string Query = "Select ID, Name, Program , Semester from Student where ID='" + stId + "';";
                    dataViewTableHero.DataSource = B.ExecuteQueryTable(Query);
                }
                else
                {
                    MessageBox.Show("Nothing to Search");
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            
        }
    }
}
