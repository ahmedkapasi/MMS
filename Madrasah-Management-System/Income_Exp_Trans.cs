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
    public partial class Income_Exp_Trans : base_form
    {
        public Income_Exp_Trans()
        {
            InitializeComponent();
            //printDocument("13");
            //return;
        }

        DataRow studentDtls;

        public Income_Exp_Trans(DataRow _studentDtls)
        {
            InitializeComponent();
            studentDtls = _studentDtls;
            txt_desc.Text = studentDtls["name"].ToString();
            txt_desc.Enabled = false; //should not change the name if transaction is against student.
        }


        private void btn_srch_student_Click(object sender, EventArgs e)
        {
            var objForm = new StudentSearch();
            common.showForm(objForm);
            this.Close();
        }

        private void Income_Exp_Trans_Load(object sender, EventArgs e)
        {
            cmb_type.SelectedIndex = 0;
            cmb_pay_method.SelectedIndex = 0;
        }
        private void fillIncExpHeads()
        {
            string type = cmb_type.Text;
            string selCmd = "SELECT * FROM INC_EXP_HEADS WHERE TYPE = '" + type + "' AND ISNULL(SUB_TYPE,0) = 0";
            
            if (type == "Expense")
            {
                lbl_rcvd_from.Text = "Paid To";
                lbl_rcvd_dt.Text = "Paid On";
            }
            else
            {
                lbl_rcvd_from.Text = "Recvd. From";
                lbl_rcvd_dt.Text = "Recvd. On";
            }
            var dt = common.getDataSet(selCmd).Tables[0];
            cmb_heads.DataSource = dt;
            cmb_heads.SelectedIndex = 0;
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
            if (txt_desc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter " + lbl_rcvd_from.Text);
                return;
            }
            float amt;
            if (float.TryParse(txt_amount.Text, out amt) == false) {
                MessageBox.Show("Invalid Amount");
                txt_amount.Focus();
                return;
            }
            if (float.Parse(txt_amount.Text) <= 0)
            {
                MessageBox.Show("Invalid Amount");
                txt_amount.Focus();
                return;
            }

            string incExpHd = cmb_heads.SelectedValue.ToString();
            string incExpHdName = cmb_heads.Text;
            string description = txt_desc.Text.Trim();
            string rcvdDate = dp_rcvd_dt.Value.ToString("yyyy-MMMM-dd");
            string amount = txt_amount.Text;
            string pay_method = cmb_pay_method.Text;
            string studentID = "0";
            string comments = txt_comments.Text.Trim();
            if (studentDtls != null)
            {
                studentID = studentDtls["id"].ToString();
            }
            if (comments == string.Empty)
            {
                string type = cmb_type.Text == "Income" ? "Received" : "Paid";
                comments = string.Format("{0} amount {1} against income head {2}",type, amount, incExpHdName);
            }
            string insrtCmd = string.Format(@"INSERT INTO INC_EXP_TRANS(DESCRIPTION,INC_EXP_HEAD,AMOUNT,TRANS_DATE,STUDENT,PAY_METHOD,COMMENTS)
            VALUES('{0}',{1},{2},'{3}',{4},'{5}','{6}')", description, incExpHd, amount, rcvdDate, studentID, pay_method,comments);
            string id_value;
            string retVal = common.updateTable(insrtCmd, out id_value);

            if (retVal == common.SUCCESS_MSG)
            {
                DialogResult dlg = MessageBox.Show("Record Saved Successfully, Do you want to print it now?", "Record Saved", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                   Print_Documents.printIncExpReceipt(id_value);
                }
            }
            else
            {
                MessageBox.Show(retVal);
            }


        }

        
    }
}
