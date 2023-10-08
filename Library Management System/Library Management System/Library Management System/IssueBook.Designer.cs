namespace Library_Management_System
{
    partial class IssueBook
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookIDIssue = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.studentID = new System.Windows.Forms.TextBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnProceed);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.BookName);
            this.panel1.Controls.Add(this.BookIDIssue);
            this.panel1.Controls.Add(this.StudentName);
            this.panel1.Controls.Add(this.studentID);
            this.panel1.Controls.Add(this.lblReturnDate);
            this.panel1.Controls.Add(this.lblIssueDate);
            this.panel1.Controls.Add(this.lblBookName);
            this.panel1.Controls.Add(this.lblBookID);
            this.panel1.Controls.Add(this.lblStudentName);
            this.panel1.Controls.Add(this.lblStudentId);
            this.panel1.Location = new System.Drawing.Point(51, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 601);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(257, 421);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(281, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(257, 360);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProceed.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnProceed.Location = new System.Drawing.Point(303, 500);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(4);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(124, 54);
            this.btnProceed.TabIndex = 6;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnClear.Location = new System.Drawing.Point(435, 500);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 54);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(257, 287);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(281, 22);
            this.BookName.TabIndex = 1;
            // 
            // BookIDIssue
            // 
            this.BookIDIssue.Location = new System.Drawing.Point(257, 218);
            this.BookIDIssue.Name = "BookIDIssue";
            this.BookIDIssue.Size = new System.Drawing.Size(281, 22);
            this.BookIDIssue.TabIndex = 1;
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(257, 156);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(281, 22);
            this.StudentName.TabIndex = 1;
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(257, 84);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(281, 22);
            this.studentID.TabIndex = 1;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblReturnDate.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(82, 420);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(131, 23);
            this.lblReturnDate.TabIndex = 0;
            this.lblReturnDate.Text = "ReturnDate";
            this.lblReturnDate.Click += new System.EventHandler(this.lblReturnDate_Click);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblIssueDate.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(103, 359);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(110, 23);
            this.lblIssueDate.TabIndex = 0;
            this.lblIssueDate.Text = "IssueDate";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblBookName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(92, 287);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(121, 23);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "BookName";
            this.lblBookName.Click += new System.EventHandler(this.lblBookName_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblBookID.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(126, 218);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(87, 23);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "BookID";
            this.lblBookID.Click += new System.EventHandler(this.lblBookID_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblStudentName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(63, 156);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(150, 23);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "StudentName";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblStudentId.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(100, 84);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(113, 23);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "StudentId";
            this.lblStudentId.Click += new System.EventHandler(this.lblStudentId_Click);
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Controls.Add(this.panel1);
            this.Name = "IssueBook";
            this.Size = new System.Drawing.Size(813, 710);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox BookIDIssue;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
