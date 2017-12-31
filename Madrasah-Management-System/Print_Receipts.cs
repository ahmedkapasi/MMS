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
    public partial class Print_Receipts : Form
    {
        public Print_Receipts()
        {
            InitializeComponent();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            int rcpt = int.Parse(txt_rcpt_no.Text.ToString().Trim());
            if (cmb_type.Text == "Rent")
            {
                Print_Documents.printRentReceipt(rcpt.ToString());
            }
            else {
                if (cmb_type.Text == "Fees") {
                    Print_Documents.printFeesReceipt(rcpt.ToString());
                }
            }
        }

        

        private void Print_Receipts_Load(object sender, EventArgs e)
        {
            cmb_type.SelectedIndex = 0;
        }
    }
}
