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
    public partial class CheckStatus : UserControl
    {
        private DataAccess Lb { get; set; }
        public CheckStatus()
        {
            InitializeComponent();
            this.Lb = new DataAccess();
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            string BookId = CheckID.Text;
            string BookName = CheckBook.Text;

            bool y = String.IsNullOrEmpty(CheckID.Text);
            bool x = String.IsNullOrEmpty(CheckBook.Text);
            if (y == false && x== false)
            {
                string BSearch = CheckID.Text;
                DataAccess B = new DataAccess();
                string SearchQuery = "Select * from BookInfo where BookID ='" + BSearch + "';";
                dataGridViewCheck.DataSource = B.ExecuteQueryTable(SearchQuery);
            }
            else
            {
                MessageBox.Show("Nothing to search");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.CheckID.Clear();
            this.CheckBook.Clear();
        }
    }
}
