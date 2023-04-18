namespace UniversityTuition
{
    partial class MainForm
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
            this.listRecentPayments = new System.Windows.Forms.ListBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listRecentPayments
            // 
            this.listRecentPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.listRecentPayments.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listRecentPayments.ForeColor = System.Drawing.Color.White;
            this.listRecentPayments.FormattingEnabled = true;
            this.listRecentPayments.ItemHeight = 24;
            this.listRecentPayments.Location = new System.Drawing.Point(12, 60);
            this.listRecentPayments.Name = "listRecentPayments";
            this.listRecentPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listRecentPayments.Size = new System.Drawing.Size(615, 388);
            this.listRecentPayments.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPay.Font = new System.Drawing.Font("Dana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(633, 335);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(189, 91);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "پرداخت شهریه";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSearchID
            // 
            this.btnSearchID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearchID.Font = new System.Drawing.Font("Dana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearchID.ForeColor = System.Drawing.Color.White;
            this.btnSearchID.Location = new System.Drawing.Point(633, 238);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(189, 91);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.Text = "جستجو کد دانشجویی";
            this.btnSearchID.UseVisualStyleBackColor = false;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "گزارش آخرین پرداخت ها";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(834, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.listRecentPayments);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.ListBox listRecentPayments;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Label label1;
    }
}