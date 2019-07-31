namespace Book_Manager
{
    partial class frmStatistics
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistics));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRead = new System.Windows.Forms.Label();
            this.lblThisYear = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalUnread = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Books Read";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRead
            // 
            this.lblTotalRead.BackColor = System.Drawing.Color.Black;
            this.lblTotalRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRead.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblTotalRead.Location = new System.Drawing.Point(15, 72);
            this.lblTotalRead.Name = "lblTotalRead";
            this.lblTotalRead.Size = new System.Drawing.Size(123, 50);
            this.lblTotalRead.TabIndex = 1;
            this.lblTotalRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThisYear
            // 
            this.lblThisYear.BackColor = System.Drawing.Color.Black;
            this.lblThisYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisYear.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblThisYear.Location = new System.Drawing.Point(172, 72);
            this.lblThisYear.Name = "lblThisYear";
            this.lblThisYear.Size = new System.Drawing.Size(123, 50);
            this.lblThisYear.TabIndex = 3;
            this.lblThisYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Books This Year";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalUnread
            // 
            this.lblTotalUnread.BackColor = System.Drawing.Color.Black;
            this.lblTotalUnread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalUnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUnread.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblTotalUnread.Location = new System.Drawing.Point(328, 72);
            this.lblTotalUnread.Name = "lblTotalUnread";
            this.lblTotalUnread.Size = new System.Drawing.Size(123, 50);
            this.lblTotalUnread.TabIndex = 5;
            this.lblTotalUnread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "Left To Read";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(505, 142);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 177);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalUnread);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblThisYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalRead);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reading Stats";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRead;
        private System.Windows.Forms.Label lblThisYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalUnread;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
    }
}