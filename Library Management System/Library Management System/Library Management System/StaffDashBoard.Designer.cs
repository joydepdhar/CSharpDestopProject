namespace Library_Management_System
{
    partial class StaffDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashBoard));
            this.stuffBox = new System.Windows.Forms.MenuStrip();
            this.menuAddNewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.student_Details1 = new Library_Management_System.Student_Details();
            this.bookDetails1 = new Library_Management_System.BookDetails();
            this.add_New_Books1 = new Library_Management_System.Add_New_Books();
            this.add_New_Member1 = new Library_Management_System.Add_New_Member();
            this.stuffBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stuffBox
            // 
            this.stuffBox.BackColor = System.Drawing.Color.Snow;
            this.stuffBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stuffBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddNewMember,
            this.booksToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem1});
            this.stuffBox.Location = new System.Drawing.Point(0, 0);
            this.stuffBox.Name = "stuffBox";
            this.stuffBox.Size = new System.Drawing.Size(999, 104);
            this.stuffBox.TabIndex = 3;
            this.stuffBox.Text = "menuStrip1";
            // 
            // menuAddNewMember
            // 
            this.menuAddNewMember.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuAddNewMember.Image = ((System.Drawing.Image)(resources.GetObject("menuAddNewMember.Image")));
            this.menuAddNewMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAddNewMember.Name = "menuAddNewMember";
            this.menuAddNewMember.Size = new System.Drawing.Size(220, 100);
            this.menuAddNewMember.Text = "Add New Student";
            this.menuAddNewMember.Click += new System.EventHandler(this.menuAddNewMember_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.bookDetailsToolStripMenuItem});
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(155, 100);
            this.booksToolStripMenuItem.Text = "    Books   ";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBookToolStripMenuItem.Image")));
            this.addNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(252, 86);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // bookDetailsToolStripMenuItem
            // 
            this.bookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookDetailsToolStripMenuItem.Image")));
            this.bookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookDetailsToolStripMenuItem.Name = "bookDetailsToolStripMenuItem";
            this.bookDetailsToolStripMenuItem.Size = new System.Drawing.Size(252, 86);
            this.bookDetailsToolStripMenuItem.Text = "Book Details";
            this.bookDetailsToolStripMenuItem.Click += new System.EventHandler(this.bookDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBookDetailsToolStripMenuItem,
            this.menuEditBook});
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(157, 100);
            this.editToolStripMenuItem.Text = " Edit  ";
            // 
            // editBookDetailsToolStripMenuItem
            // 
            this.editBookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editBookDetailsToolStripMenuItem.Image")));
            this.editBookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editBookDetailsToolStripMenuItem.Name = "editBookDetailsToolStripMenuItem";
            this.editBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(283, 86);
            this.editBookDetailsToolStripMenuItem.Text = "Edit Student Details";
            this.editBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.editBookDetailsToolStripMenuItem_Click);
            // 
            // menuEditBook
            // 
            this.menuEditBook.Image = ((System.Drawing.Image)(resources.GetObject("menuEditBook.Image")));
            this.menuEditBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEditBook.Name = "menuEditBook";
            this.menuEditBook.Size = new System.Drawing.Size(283, 86);
            this.menuEditBook.Text = "Edit Book Details";
            this.menuEditBook.Click += new System.EventHandler(this.editBookDetailsToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 100);
            this.toolStripMenuItem1.Text = " Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.student_Details1);
            this.panel1.Controls.Add(this.bookDetails1);
            this.panel1.Controls.Add(this.add_New_Books1);
            this.panel1.Controls.Add(this.add_New_Member1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 666);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // student_Details1
            // 
            this.student_Details1.Location = new System.Drawing.Point(8, 2);
            this.student_Details1.Margin = new System.Windows.Forms.Padding(5);
            this.student_Details1.Name = "student_Details1";
            this.student_Details1.Size = new System.Drawing.Size(991, 706);
            this.student_Details1.TabIndex = 3;
            // 
            // bookDetails1
            // 
            this.bookDetails1.Location = new System.Drawing.Point(5, 0);
            this.bookDetails1.Margin = new System.Windows.Forms.Padding(5);
            this.bookDetails1.Name = "bookDetails1";
            this.bookDetails1.Size = new System.Drawing.Size(994, 675);
            this.bookDetails1.TabIndex = 2;
            // 
            // add_New_Books1
            // 
            this.add_New_Books1.Location = new System.Drawing.Point(3, 1);
            this.add_New_Books1.Margin = new System.Windows.Forms.Padding(5);
            this.add_New_Books1.Name = "add_New_Books1";
            this.add_New_Books1.Size = new System.Drawing.Size(996, 688);
            this.add_New_Books1.TabIndex = 1;
            // 
            // add_New_Member1
            // 
            this.add_New_Member1.Location = new System.Drawing.Point(1, 2);
            this.add_New_Member1.Margin = new System.Windows.Forms.Padding(5);
            this.add_New_Member1.Name = "add_New_Member1";
            this.add_New_Member1.Size = new System.Drawing.Size(1006, 687);
            this.add_New_Member1.TabIndex = 0;
            // 
            // StaffDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stuffBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffDashBoard";
            this.Size = new System.Drawing.Size(999, 770);
            this.Load += new System.EventHandler(this.StaffDashBoard_Load);
            this.stuffBox.ResumeLayout(false);
            this.stuffBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip stuffBox;
        private System.Windows.Forms.ToolStripMenuItem menuAddNewMember;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEditBook;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private Student_Details student_Details1;
        private BookDetails bookDetails1;
        private Add_New_Books add_New_Books1;
        private Add_New_Member add_New_Member1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
