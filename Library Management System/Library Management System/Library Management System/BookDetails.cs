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
    public partial class BookDetails : UserControl
    {
        private DataAccess Lb { get; set; }
        public BookDetails()
        {
            InitializeComponent();
            this.Lb = new DataAccess();
        }
        private void PopulateGridView(string sql = "Select * from BookInfo;")
        {
            var ds = this.Lb.ExecuteQuery(sql);
            this.BookGridViewHero.AutoGenerateColumns = false;
            this.BookGridViewHero.DataSource = ds.Tables[0];
        }
        private void BookDetails_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataAccess B = new DataAccess();
            //string Query = "Select * from BookInfo;";
            //string table = ;
            //dataViewTableHero.Rows.Clear();
            //BookGridViewHero.DataSource = B.ExecuteQueryTable(Query);
            this.PopulateGridView();
        }

        private void BookSearchbtn_Click(object sender, EventArgs e)
        {
            try 
            {
                bool y = String.IsNullOrEmpty(BookSearch.Text);
                if (y == false)
                {
                    string BSearch = BookSearch.Text;
                    DataAccess B = new DataAccess();
                    string SearchQuery = "Select * from BookInfo where BookID ='" + BSearch + "';";
                    BookGridViewHero.DataSource = B.ExecuteQueryTable(SearchQuery);
                }
                else
                {
                    MessageBox.Show("Nothing to search");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
