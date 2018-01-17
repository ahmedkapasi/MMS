using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madrasah_Management_System
{
    public partial class Print_Receipts : base_form
    {
        public Print_Receipts()
        {
            InitializeComponent();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            
            int rcpt;
            if (int.TryParse(txt_rcpt_no.Text.ToString().Trim(), out rcpt) == false) {
                MessageBox.Show("Invalid Receipt No.");
                return;
            }
            switch (cmb_type.Text.Trim())
            {
                case "Fees" :
                    Print_Documents.printFeesReceipt(rcpt.ToString());
                    break;
                case "Rent":
                    Print_Documents.printRentReceipt(rcpt.ToString());
                    break;
                case "Inc/Exp":
                    Print_Documents.printIncExpReceipt(rcpt.ToString());
                    break;

            }
        }

        private void Print_Receipts_Load(object sender, EventArgs e)
        {
            cmb_type.SelectedIndex = 0;
        }
    }
}
