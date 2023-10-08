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
    public partial class AddNewStaff : UserControl
    {
        public AddNewStaff()
        {
            InitializeComponent();
        }

        private void Staff_Details_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Close The Application?", "Exit Maessage",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.StuffID.Text) || String.IsNullOrEmpty(this.StuffName.Text) ||
                String.IsNullOrEmpty(this.StuffAge.Text) || String.IsNullOrEmpty(this.StuffContact.Text) ||
                String.IsNullOrEmpty(this.StuffPassword.Text) 
                )
            {
                return false;
            }
            else
                return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool x = this.IsValidToSaveData();
            if (x == true)
            {
                DataAccess A = new DataAccess();
                string Roll = "Stuff";
                string sID = StuffID.Text;
                string sName = StuffName.Text;
                string sAge = StuffAge.Text;
                string sContact = StuffContact.Text;
                string SPassword = StuffPassword.Text;
                string Query = "insert into StuffPerson(STuffID, SName, SAGE,SContact,SPassword) Values('" + sID + "','" + sName + "','" + sAge + "','" + sContact + "','" + SPassword + "');";
                A.ExecuteDMLQuery(Query);
                string SubQuery = "insert into AdminPerson(ID,Password,Roll) Values('" + sID + "','" + SPassword + "','" + Roll + "');";
                A.ExecuteDMLQuery(SubQuery);
                MessageBox.Show("Data save");
            }
            else
            {
                MessageBox.Show("Please Fill ALl Boxes");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool x = this.IsValidToSaveData();
            if (x == true)
            {
                DataAccess A = new DataAccess();
                string StId = StuffID.Text;
                string sName = StuffName.Text;
                string sAge = StuffAge.Text;
                string sContact = StuffContact.Text;
                string SPassword = StuffPassword.Text;
                string Query = "Update StuffPerson SET SName='" + sName + "',SAGE='" + sAge + "', SContact='" + sContact + "' , SPassword='" + SPassword + "' where STuffID='" + StId + "';";
                A.ExecuteDMLQuery(Query);
                MessageBox.Show("Data update");
            }
            else
            {
                MessageBox.Show("Please Fill ALl Boxes");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                bool x = this.IsValidToSaveData();
                if (x == true)
                {
                    DataAccess A = new DataAccess();
                    string StId = StuffID.Text;
                    string sName = StuffName.Text;
                    string sAge = StuffAge.Text;
                    string sContact = StuffContact.Text;
                    string SPassword = StuffPassword.Text;
                    string Query = "DELETE FROM StuffPerson WHERE STuffID=='" + StId + "'";
                    //A.ExecuteQuery(Query);
                    A.ExecuteDMLQuery(Query);
                    string SubQuery = "DELETE FROM AdminPerson WHERE STuffID=='" + StId + "'";
                    A.ExecuteDMLQuery(SubQuery);
                    MessageBox.Show("Data Delete");
                }
                else
                {
                    MessageBox.Show("Please Fill ALl Boxes");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error Occured"+exc.Message);
            }
        }

        private void StaffClear_Click(object sender, EventArgs e)
        {
                this.StuffID.Clear();
                this.StuffName.Clear();
                this.StuffAge.Clear();
                this.StuffContact.Clear();
                this.StuffPassword.Clear();
            
        }
    }
}
