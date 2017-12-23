using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madrasah_Management_System
{
    public partial class Income_Exp_Trans : Form
    {
        public Income_Exp_Trans()
        {
            InitializeComponent();
        }

        private void btn_srch_student_Click(object sender, EventArgs e)
        {
            common.showForm(new StudentSearch());
        }

        private void Income_Exp_Trans_Load(object sender, EventArgs e)
        {
            cmb_type.SelectedIndex = 0;
        }
        private void fillIncExpHeads() {
            string type = cmb_type.Text;
            var ds = common.getDataSet("SELECT * FROM INC_EXP_HEADS WHERE TYPE = '" + type + "'");
            cmb_heads.DataSource = ds.Tables[0];
            cmb_heads.SelectedIndex = 0;
            if (type == "Expense")
            {
                lbl_rcvd_from.Text = "Paid To";
                lbl_rcvd_dt.Text = "Paid On";
            }
            else {
                lbl_rcvd_from.Text = "Recvd. From";
                lbl_rcvd_dt.Text = "Recvd. On";
            }

        }
        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillIncExpHeads();
        }

        private void checkForNumbers(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_desc.Text.Trim() == string.Empty) {
                MessageBox.Show("Please Enter " + lbl_rcvd_from.Text);
                return;
            }

            if (txt_amount.Text.Trim() == string.Empty || float.Parse(txt_amount.Text) <= 0 )
            {
                MessageBox.Show("Invalid Amount");
                return;
            }


            string incExpHd = cmb_heads.SelectedValue.ToString();
            string description = lbl_rcvd_from.Text + " " + txt_desc.Text.Trim();
            string rcvdDate = dp_rcvd_dt.Value.ToString("yyyy-MMMM-dd");
            string amount = txt_amount.Text;
            string insrtCmd = string.Format(@"INSERT INTO INC_EXP_TRANS(DESCRIPTION,INC_EXP_HEAD,AMOUNT,TRANS_DATE)
            VALUES('{0}',{1},{2},'{3}')",description,incExpHd,amount,rcvdDate);
            string retVal = common.updateTable(insrtCmd);
            if(retVal == common.SUCCESS_MSG){
                MessageBox.Show("Record Saved Successfully");
            }else{
                MessageBox.Show(retVal);
            }
        }   
    }
}
