namespace Library_Management_System
{
    partial class BookDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BookSearchbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BookSearch = new System.Windows.Forms.TextBox();
            this.BookGridViewHero = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridViewHero)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 735);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.BookSearchbtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BookSearch);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(113, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 112);
            this.panel2.TabIndex = 3;
            // 
            // BookSearchbtn
            // 
            this.BookSearchbtn.BackColor = System.Drawing.Color.Snow;
            this.BookSearchbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookSearchbtn.Location = new System.Drawing.Point(703, 72);
            this.BookSearchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.BookSearchbtn.Name = "BookSearchbtn";
            this.BookSearchbtn.Size = new System.Drawing.Size(116, 32);
            this.BookSearchbtn.TabIndex = 22;
            this.BookSearchbtn.Text = "Search";
            this.BookSearchbtn.UseVisualStyleBackColor = false;
            this.BookSearchbtn.Click += new System.EventHandler(this.BookSearchbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "BookDetails>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(441, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By BookID\r\n";
            // 
            // BookSearch
            // 
            this.BookSearch.Location = new System.Drawing.Point(444, 79);
            this.BookSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BookSearch.Name = "BookSearch";
            this.BookSearch.Size = new System.Drawing.Size(251, 22);
            this.BookSearch.TabIndex = 0;
            // 
            // BookGridViewHero
            // 
            this.BookGridViewHero.AllowUserToAddRows = false;
            this.BookGridViewHero.AllowUserToDeleteRows = false;
            this.BookGridViewHero.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BookGridViewHero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGridViewHero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.BookAuthor,
            this.BookType,
            this.BQuantity});
            this.BookGridViewHero.Location = new System.Drawing.Point(-8, -9);
            this.BookGridViewHero.Name = "BookGridViewHero";
            this.BookGridViewHero.ReadOnly = true;
            this.BookGridViewHero.RowHeadersWidth = 51;
            this.BookGridViewHero.RowTemplate.Height = 24;
            this.BookGridViewHero.Size = new System.Drawing.Size(875, 562);
            this.BookGridViewHero.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BookGridViewHero);
            this.panel3.Location = new System.Drawing.Point(120, 120);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 626);
            this.panel3.TabIndex = 4;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 125;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 125;
            // 
            // BookAuthor
            // 
            this.BookAuthor.DataPropertyName = "BookAuthor";
            this.BookAuthor.HeaderText = "Author";
            this.BookAuthor.MinimumWidth = 6;
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.ReadOnly = true;
            this.BookAuthor.Width = 125;
            // 
            // BookType
            // 
            this.BookType.DataPropertyName = "BookType";
            this.BookType.HeaderText = "Type";
            this.BookType.MinimumWidth = 6;
            this.BookType.Name = "BookType";
            this.BookType.ReadOnly = true;
            this.BookType.Width = 125;
            // 
            // BQuantity
            // 
            this.BQuantity.DataPropertyName = "BQuantity";
            this.BQuantity.HeaderText = "Quantity";
            this.BQuantity.MinimumWidth = 6;
            this.BQuantity.Name = "BQuantity";
            this.BQuantity.ReadOnly = true;
            this.BQuantity.Width = 125;
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookDetails";
            this.Size = new System.Drawing.Size(990, 735);
            this.Load += new System.EventHandler(this.BookDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridViewHero)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookSearch;
        private System.Windows.Forms.Button BookSearchbtn;
        private System.Windows.Forms.DataGridView BookGridViewHero;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BQuantity;
    }
}
