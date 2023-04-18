namespace UniversityTuition
{
    partial class PayForm
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
            this.inputAmountForm = new System.Windows.Forms.TextBox();
            this.inputStudentID = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStudentIDPay = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPayForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputAmountForm
            // 
            this.inputAmountForm.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputAmountForm.Location = new System.Drawing.Point(200, 67);
            this.inputAmountForm.Name = "inputAmountForm";
            this.inputAmountForm.Size = new System.Drawing.Size(190, 31);
            this.inputAmountForm.TabIndex = 0;
            // 
            // inputStudentID
            // 
            this.inputStudentID.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputStudentID.Location = new System.Drawing.Point(200, 125);
            this.inputStudentID.Name = "inputStudentID";
            this.inputStudentID.Size = new System.Drawing.Size(190, 31);
            this.inputStudentID.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(454, 70);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAmount.Size = new System.Drawing.Size(36, 24);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "مبلغ";
            // 
            // lblStudentIDPay
            // 
            this.lblStudentIDPay.AutoSize = true;
            this.lblStudentIDPay.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStudentIDPay.ForeColor = System.Drawing.Color.White;
            this.lblStudentIDPay.Location = new System.Drawing.Point(396, 128);
            this.lblStudentIDPay.Name = "lblStudentIDPay";
            this.lblStudentIDPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStudentIDPay.Size = new System.Drawing.Size(94, 24);
            this.lblStudentIDPay.TabIndex = 3;
            this.lblStudentIDPay.Text = "کد دانشجویی";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(21, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(173, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "جستجو کد دانشجویی";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPayForm
            // 
            this.btnPayForm.BackColor = System.Drawing.Color.Crimson;
            this.btnPayForm.Font = new System.Drawing.Font("Dana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPayForm.ForeColor = System.Drawing.Color.White;
            this.btnPayForm.Location = new System.Drawing.Point(228, 192);
            this.btnPayForm.Name = "btnPayForm";
            this.btnPayForm.Size = new System.Drawing.Size(133, 42);
            this.btnPayForm.TabIndex = 5;
            this.btnPayForm.Text = "پرداخت";
            this.btnPayForm.UseVisualStyleBackColor = false;
            this.btnPayForm.Click += new System.EventHandler(this.btnPayForm_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(507, 301);
            this.Controls.Add(this.btnPayForm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStudentIDPay);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.inputStudentID);
            this.Controls.Add(this.inputAmountForm);
            this.Name = "PayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PayForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputAmountForm;
        public  System.Windows.Forms.TextBox inputStudentID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStudentIDPay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPayForm;
    }
}