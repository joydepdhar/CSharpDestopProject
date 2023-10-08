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
    public partial class Add_New_Books : UserControl
    {
        public Add_New_Books()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Close The Application?", "Exit Maessage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.BookId.Text) || String.IsNullOrEmpty(this.BookName.Text) ||
                String.IsNullOrEmpty(this.BookAuthor.Text) || String.IsNullOrEmpty(this.BookPub.Text) ||
                String.IsNullOrEmpty(this.BookQuantity.Text)||
                String.IsNullOrEmpty(this.BookType.Text)
                )
            {
                return false;
            }
            else
                return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool x = this.IsValidToSaveData();
            if (x == true)
            {
                DataAccess A = new DataAccess();
                string BID = BookId.Text;
                string BName = BookName.Text;
                string BAuthor = BookAuthor.Text;
                string BType = BookType.Text;
                string BPulication = BookPub.Text;
                string BQuantity = BookQuantity.Text;
                string Query = "insert into BookInfo(BookID,BookName,BookAuthor,BookType,bookPub, BQuantity) Values('" + BID + "','" + BName + "','" + BAuthor + "','" + BType + "','" + BPulication + "','" + BQuantity + "');";
                A.ExecuteDMLQuery(Query);
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
                string BID = BookId.Text;
                string BName = BookName.Text;
                string BAuthor = BookAuthor.Text;
                string BType = BookType.Text;
                string BPulication = BookPub.Text;
                string BQuantity = BookQuantity.Text;
                string Query = "UPDATE BookInfo Set BookName='" + BName + "',BookAuthor='" + BAuthor + "',BookType='" + BType + "',BookPub='" + BPulication + "',BQuantity='" + BQuantity + "' where BookID='" + BID + "'";
                A.ExecuteDMLQuery(Query);
                MessageBox.Show("Data Update");
            }
            else
            {

                MessageBox.Show("Please Fill ALl Boxes");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool x = this.IsValidToSaveData();
            if (x == true)
            {
                DataAccess A = new DataAccess();
                string BID = BookId.Text;
                string BName = BookName.Text;
                string BAuthor = BookAuthor.Text;
                string BType = BookType.Text;
                string BPulication = BookPub.Text;
                string BQuantity = BookQuantity.Text;
                string Query = "DELETE FROM BookInfo WHERE BookID='" + BID + "'";
                A.ExecuteDMLQuery(Query);
                MessageBox.Show("Data Delete");
            }
            else
            {
                MessageBox.Show("Please Fill ALl Boxes");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            BookId.Clear();
            BookName.Clear();
            BookAuthor.Clear();
            BookType.Clear();
            BookPub.Clear();
            BookQuantity.Clear();

        }
    }
}
