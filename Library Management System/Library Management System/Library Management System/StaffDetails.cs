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
    public partial class StaffDetails : UserControl
       
    {
        private DataAccess Lb { get; set; }
        private AdminDashBoard Ad { get; set; }
        public StaffDetails()
        {
            InitializeComponent();
            this.Lb = new DataAccess();
        }
        private void PopulateGridView(string sql = "Select STuffID, SName,SAGE,SContact from StuffPerson;")
        {
            var ds = this.Lb.ExecuteQuery(sql);
            this.DataGridViewStuff.AutoGenerateColumns = false;
            this.DataGridViewStuff.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Close The Application?", "Exit Maessage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard();
            adminDashBoard.Show();
            this.Hide();
            
            
        }

        private void btnStaffDetails_Click(object sender, EventArgs e)
        {
            //
            //ataAccess B = new DataAccess();
            //ring Query = "Select STuffID, SName,SAGE,SContact from StuffPerson;";
            //string table = ;
            //dataViewTableHero.Rows.Clear();
            //ataGridViewStuff.DataSource = B.ExecuteQueryTable(Query);
            this.PopulateGridView();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                bool x = String.IsNullOrEmpty(StaffSearch.Text);
                if (x == true)
                {
                    string LId = StaffSearch.Text;
                    DataAccess B = new DataAccess();
                    string Query = "Select STuffID, SName,SAGE,SContact from StuffPerson where STuffID='" + LId + "';";
                    DataGridViewStuff.DataSource = B.ExecuteQueryTable(Query);
                }
                else
                {
                    MessageBox.Show("Nothing to Search");
                }
            }
            catch(Exception ex)
            { MessageBox.Show("Error" +ex.Message); }
            
        }
    }
}
