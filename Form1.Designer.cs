namespace Loan_Management_MIni_Application
{
    partial class frm_LoanApp
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
            this.btn_borrower = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.btn_loan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_borrower
            // 
            this.btn_borrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrower.Location = new System.Drawing.Point(76, 150);
            this.btn_borrower.Name = "btn_borrower";
            this.btn_borrower.Size = new System.Drawing.Size(121, 34);
            this.btn_borrower.TabIndex = 1;
            this.btn_borrower.Text = "BORROWER";
            this.btn_borrower.UseVisualStyleBackColor = true;
            this.btn_borrower.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_title
            // 
            this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(12, 56);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(255, 70);
            this.txt_title.TabIndex = 2;
            this.txt_title.Text = "Loan Management Mini Application";
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_loan
            // 
            this.btn_loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loan.Location = new System.Drawing.Point(76, 201);
            this.btn_loan.Name = "btn_loan";
            this.btn_loan.Size = new System.Drawing.Size(121, 34);
            this.btn_loan.TabIndex = 3;
            this.btn_loan.Text = "LOAN";
            this.btn_loan.UseVisualStyleBackColor = true;
            this.btn_loan.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_LoanApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 293);
            this.Controls.Add(this.btn_loan);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_borrower);
            this.Name = "frm_LoanApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrower;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Button btn_loan;
    }
}

