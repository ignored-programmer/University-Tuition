namespace UniversityTuition
{
    partial class SearchForm
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
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.btnSearchForm = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputSearch
            // 
            this.inputSearch.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputSearch.Location = new System.Drawing.Point(158, 47);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(208, 31);
            this.inputSearch.TabIndex = 0;
            this.inputSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearchForm
            // 
            this.btnSearchForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearchForm.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearchForm.ForeColor = System.Drawing.Color.White;
            this.btnSearchForm.Location = new System.Drawing.Point(77, 47);
            this.btnSearchForm.Name = "btnSearchForm";
            this.btnSearchForm.Size = new System.Drawing.Size(75, 31);
            this.btnSearchForm.TabIndex = 1;
            this.btnSearchForm.Text = "جستجو";
            this.btnSearchForm.UseVisualStyleBackColor = false;
            this.btnSearchForm.Click += new System.EventHandler(this.btnSearchForm_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCopy.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCopy.Location = new System.Drawing.Point(102, 204);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(239, 41);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "کپی کد در صفحه پرداخت";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Dana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(158, 107);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStudentID.Size = new System.Drawing.Size(0, 24);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(442, 257);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSearchForm);
            this.Controls.Add(this.inputSearch);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button btnSearchForm;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblStudentID;
    }
}