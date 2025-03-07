using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loan_Management_MIni_Application
{
    public partial class frm_LoanApp: Form
    {
        public frm_LoanApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Borrower newForm = new frm_Borrower();
            this.Hide(); // hide frm_LoanApp
            newForm.Show(); // show frm_Borrower
            this.Show(); //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Loan newForm = new frm_Loan();
            this.Hide(); // hide frm_LoanApp
            newForm.Show(); // show frm_Borrower
            this.Show(); //
        }
    }
}
