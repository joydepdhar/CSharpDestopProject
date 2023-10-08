namespace Library_Management_System
{
    partial class CheckStatus
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
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.CheckBook = new System.Windows.Forms.TextBox();
            this.CheckID = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.dataGridViewCheck = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dataGridViewCheck);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 529);
            this.panel1.TabIndex = 0;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProceed.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnProceed.Location = new System.Drawing.Point(387, 10);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(4);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(124, 54);
            this.btnProceed.TabIndex = 12;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnClear.Location = new System.Drawing.Point(549, 12);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 54);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CheckBook
            // 
            this.CheckBook.Location = new System.Drawing.Point(113, 44);
            this.CheckBook.Name = "CheckBook";
            this.CheckBook.Size = new System.Drawing.Size(216, 22);
            this.CheckBook.TabIndex = 9;
            // 
            // CheckID
            // 
            this.CheckID.Location = new System.Drawing.Point(113, 3);
            this.CheckID.Name = "CheckID";
            this.CheckID.Size = new System.Drawing.Size(216, 22);
            this.CheckID.TabIndex = 10;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblBookName.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(5, 44);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(102, 20);
            this.lblBookName.TabIndex = 7;
            this.lblBookName.Text = "BookName";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblBookID.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(33, 5);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(74, 20);
            this.lblBookID.TabIndex = 8;
            this.lblBookID.Text = "BookID";
            // 
            // dataGridViewCheck
            // 
            this.dataGridViewCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheck.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCheck.Name = "dataGridViewCheck";
            this.dataGridViewCheck.RowHeadersWidth = 51;
            this.dataGridViewCheck.RowTemplate.Height = 24;
            this.dataGridViewCheck.Size = new System.Drawing.Size(744, 523);
            this.dataGridViewCheck.TabIndex = 0;
            // 
            // CheckStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.CheckBook);
            this.Controls.Add(this.CheckID);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.panel1);
            this.Name = "CheckStatus";
            this.Size = new System.Drawing.Size(750, 601);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox CheckBook;
        private System.Windows.Forms.TextBox CheckID;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.DataGridView dataGridViewCheck;
    }
}
