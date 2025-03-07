namespace Loan_Management_MIni_Application
{
    partial class frm_Borrower
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
            this.lbl_borr_name = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_borrname = new System.Windows.Forms.TextBox();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_borrAdd = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_borr_name
            // 
            this.lbl_borr_name.AutoSize = true;
            this.lbl_borr_name.Location = new System.Drawing.Point(71, 105);
            this.lbl_borr_name.Name = "lbl_borr_name";
            this.lbl_borr_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_borr_name.TabIndex = 0;
            this.lbl_borr_name.Text = "NAME :";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(40, 131);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(75, 13);
            this.lbl_birthdate.TabIndex = 1;
            this.lbl_birthdate.Text = "BIRTHDATE :";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(80, 157);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(35, 13);
            this.lbl_age.TabIndex = 2;
            this.lbl_age.Text = "AGE :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(71, 179);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(45, 13);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "EMAIL :";
            // 
            // txt_borrname
            // 
            this.txt_borrname.Location = new System.Drawing.Point(122, 98);
            this.txt_borrname.Name = "txt_borrname";
            this.txt_borrname.Size = new System.Drawing.Size(142, 20);
            this.txt_borrname.TabIndex = 4;
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_birthdate.Location = new System.Drawing.Point(122, 124);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(142, 20);
            this.dtp_birthdate.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(122, 176);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(142, 20);
            this.txt_email.TabIndex = 7;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(122, 150);
            this.txt_age.Name = "txt_age";
            this.txt_age.ReadOnly = true;
            this.txt_age.Size = new System.Drawing.Size(142, 20);
            this.txt_age.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Borrowers ";
            // 
            // btn_borrAdd
            // 
            this.btn_borrAdd.Location = new System.Drawing.Point(300, 108);
            this.btn_borrAdd.Name = "btn_borrAdd";
            this.btn_borrAdd.Size = new System.Drawing.Size(108, 22);
            this.btn_borrAdd.TabIndex = 10;
            this.btn_borrAdd.Text = "ADD BORROWER";
            this.btn_borrAdd.UseVisualStyleBackColor = true;
            this.btn_borrAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(300, 136);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(108, 22);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "EDIT BORROWER";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(300, 164);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 22);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "DELETE BORROWER";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(43, 239);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(263, 20);
            this.txt_search.TabIndex = 14;
            this.txt_search.Text = "Search Borrower";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(321, 239);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 20);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // frm_Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_borrAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.txt_borrname);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.lbl_borr_name);
            this.Name = "frm_Borrower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_borr_name;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_borrname;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_borrAdd;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
    }
}