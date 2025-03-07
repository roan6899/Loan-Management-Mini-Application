namespace Loan_Management_MIni_Application
{
    partial class frm_Loan
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
            this.lbl_loan = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_lnBorrower = new System.Windows.Forms.Label();
            this.lbl_lnAmount = new System.Windows.Forms.Label();
            this.lbl_lnTerm = new System.Windows.Forms.Label();
            this.lbl_lnInterest = new System.Windows.Forms.Label();
            this.lbl_lnTotal = new System.Windows.Forms.Label();
            this.txt_lnAmount = new System.Windows.Forms.TextBox();
            this.txt_lnTerm = new System.Windows.Forms.TextBox();
            this.txt_lnInterest = new System.Windows.Forms.TextBox();
            this.txt_lnTotal = new System.Windows.Forms.TextBox();
            this.btn_addLn = new System.Windows.Forms.Button();
            this.btn_editLn = new System.Windows.Forms.Button();
            this.btn_deleteLn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_loan
            // 
            this.lbl_loan.AutoSize = true;
            this.lbl_loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loan.Location = new System.Drawing.Point(198, 56);
            this.lbl_loan.Name = "lbl_loan";
            this.lbl_loan.Size = new System.Drawing.Size(82, 29);
            this.lbl_loan.TabIndex = 0;
            this.lbl_loan.Text = "LOAN";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lbl_lnBorrower
            // 
            this.lbl_lnBorrower.AutoSize = true;
            this.lbl_lnBorrower.Location = new System.Drawing.Point(64, 107);
            this.lbl_lnBorrower.Name = "lbl_lnBorrower";
            this.lbl_lnBorrower.Size = new System.Drawing.Size(55, 13);
            this.lbl_lnBorrower.TabIndex = 2;
            this.lbl_lnBorrower.Text = "Borrower :";
            // 
            // lbl_lnAmount
            // 
            this.lbl_lnAmount.AutoSize = true;
            this.lbl_lnAmount.Location = new System.Drawing.Point(43, 134);
            this.lbl_lnAmount.Name = "lbl_lnAmount";
            this.lbl_lnAmount.Size = new System.Drawing.Size(76, 13);
            this.lbl_lnAmount.TabIndex = 3;
            this.lbl_lnAmount.Text = "Loan Amount :";
            this.lbl_lnAmount.Click += new System.EventHandler(this.lbl_lnAmount_Click);
            // 
            // lbl_lnTerm
            // 
            this.lbl_lnTerm.AutoSize = true;
            this.lbl_lnTerm.Location = new System.Drawing.Point(55, 160);
            this.lbl_lnTerm.Name = "lbl_lnTerm";
            this.lbl_lnTerm.Size = new System.Drawing.Size(64, 13);
            this.lbl_lnTerm.TabIndex = 4;
            this.lbl_lnTerm.Text = "Loan Term :";
            // 
            // lbl_lnInterest
            // 
            this.lbl_lnInterest.AutoSize = true;
            this.lbl_lnInterest.Location = new System.Drawing.Point(44, 186);
            this.lbl_lnInterest.Name = "lbl_lnInterest";
            this.lbl_lnInterest.Size = new System.Drawing.Size(75, 13);
            this.lbl_lnInterest.TabIndex = 5;
            this.lbl_lnInterest.Text = "Loan Interest :";
            this.lbl_lnInterest.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_lnTotal
            // 
            this.lbl_lnTotal.AutoSize = true;
            this.lbl_lnTotal.Location = new System.Drawing.Point(55, 212);
            this.lbl_lnTotal.Name = "lbl_lnTotal";
            this.lbl_lnTotal.Size = new System.Drawing.Size(64, 13);
            this.lbl_lnTotal.TabIndex = 6;
            this.lbl_lnTotal.Text = "Total Loan :";
            // 
            // txt_lnAmount
            // 
            this.txt_lnAmount.Location = new System.Drawing.Point(125, 131);
            this.txt_lnAmount.Name = "txt_lnAmount";
            this.txt_lnAmount.Size = new System.Drawing.Size(107, 20);
            this.txt_lnAmount.TabIndex = 7;
            // 
            // txt_lnTerm
            // 
            this.txt_lnTerm.Location = new System.Drawing.Point(125, 157);
            this.txt_lnTerm.Name = "txt_lnTerm";
            this.txt_lnTerm.Size = new System.Drawing.Size(107, 20);
            this.txt_lnTerm.TabIndex = 8;
            this.txt_lnTerm.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_lnInterest
            // 
            this.txt_lnInterest.Location = new System.Drawing.Point(125, 183);
            this.txt_lnInterest.Name = "txt_lnInterest";
            this.txt_lnInterest.Size = new System.Drawing.Size(107, 20);
            this.txt_lnInterest.TabIndex = 9;
            // 
            // txt_lnTotal
            // 
            this.txt_lnTotal.Location = new System.Drawing.Point(125, 209);
            this.txt_lnTotal.Name = "txt_lnTotal";
            this.txt_lnTotal.ReadOnly = true;
            this.txt_lnTotal.Size = new System.Drawing.Size(107, 20);
            this.txt_lnTotal.TabIndex = 10;
            // 
            // btn_addLn
            // 
            this.btn_addLn.Location = new System.Drawing.Point(336, 126);
            this.btn_addLn.Name = "btn_addLn";
            this.btn_addLn.Size = new System.Drawing.Size(75, 23);
            this.btn_addLn.TabIndex = 11;
            this.btn_addLn.Text = "ADD LOAN";
            this.btn_addLn.UseVisualStyleBackColor = true;
            // 
            // btn_editLn
            // 
            this.btn_editLn.Location = new System.Drawing.Point(336, 155);
            this.btn_editLn.Name = "btn_editLn";
            this.btn_editLn.Size = new System.Drawing.Size(75, 23);
            this.btn_editLn.TabIndex = 12;
            this.btn_editLn.Text = "EDIT LOAN";
            this.btn_editLn.UseVisualStyleBackColor = true;
            // 
            // btn_deleteLn
            // 
            this.btn_deleteLn.Location = new System.Drawing.Point(336, 184);
            this.btn_deleteLn.Name = "btn_deleteLn";
            this.btn_deleteLn.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteLn.TabIndex = 13;
            this.btn_deleteLn.Text = "DELETE LOAN";
            this.btn_deleteLn.UseVisualStyleBackColor = true;
            this.btn_deleteLn.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.btn_deleteLn);
            this.Controls.Add(this.btn_editLn);
            this.Controls.Add(this.btn_addLn);
            this.Controls.Add(this.txt_lnTotal);
            this.Controls.Add(this.txt_lnInterest);
            this.Controls.Add(this.txt_lnTerm);
            this.Controls.Add(this.txt_lnAmount);
            this.Controls.Add(this.lbl_lnTotal);
            this.Controls.Add(this.lbl_lnInterest);
            this.Controls.Add(this.lbl_lnTerm);
            this.Controls.Add(this.lbl_lnAmount);
            this.Controls.Add(this.lbl_lnBorrower);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_loan);
            this.Name = "frm_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_loan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_lnBorrower;
        private System.Windows.Forms.Label lbl_lnAmount;
        private System.Windows.Forms.Label lbl_lnTerm;
        private System.Windows.Forms.Label lbl_lnInterest;
        private System.Windows.Forms.Label lbl_lnTotal;
        private System.Windows.Forms.TextBox txt_lnAmount;
        private System.Windows.Forms.TextBox txt_lnTerm;
        private System.Windows.Forms.TextBox txt_lnInterest;
        private System.Windows.Forms.TextBox txt_lnTotal;
        private System.Windows.Forms.Button btn_addLn;
        private System.Windows.Forms.Button btn_editLn;
        private System.Windows.Forms.Button btn_deleteLn;
    }
}