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
    public partial class Income_Exp_Trans : Form
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
            var ds = common.getDataSet("SELECT * FROM INC_EXP_HEADS WHERE TYPE = '" + type + "'");
            cmb_heads.DataSource = ds.Tables[0];
            cmb_heads.SelectedIndex = 0;
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
            string description = txt_desc.Text.Trim();
            string rcvdDate = dp_rcvd_dt.Value.ToString("yyyy-MMMM-dd");
            string amount = txt_amount.Text;
            string pay_method = cmb_pay_method.Text;
            string studentID = "0";
            if (studentDtls != null)
            {
                studentID = studentDtls["id"].ToString();
            }
            string insrtCmd = string.Format(@"INSERT INTO INC_EXP_TRANS(DESCRIPTION,INC_EXP_HEAD,AMOUNT,TRANS_DATE,STUDENT,PAY_METHOD)
            VALUES('{0}',{1},{2},'{3}',{4},'{5}')", description, incExpHd, amount, rcvdDate, studentID, pay_method);
            string id_value;
            string retVal = common.updateTable(insrtCmd, out id_value);

            if (retVal == common.SUCCESS_MSG)
            {
                DialogResult dlg = MessageBox.Show("Record Saved Successfully, Do you want to print it now?", "Record Saved", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    printDocument(id_value);
                }
            }
            else
            {
                MessageBox.Show(retVal);
            }


        }

        private void printDocument(string id_value)
        {
            var dt = common.getDataSet(@"SELECT TR.*,FORMAT(TR.TRANS_DATE,'dd-MMM-yyyy') TR_DATE,EX.NAME,EX.TYPE FROM INC_EXP_TRANS TR,INC_EXP_HEADS EX WHERE TR.INC_EXP_HEAD=EX.ID 
            AND TR.ID = " + id_value).Tables[0];
            if (dt.Rows.Count <= 0)
            {
                return;
            }
            DataRow dr = dt.Rows[0];
            string desc = dr["description"].ToString();
            string amount = dr["amount"].ToString();
            string period = dr["tr_date"].ToString();
            string pay_method = dr["pay_method"].ToString();
            string type = dr["type"].ToString();
            string inc_exp_name = dr["name"].ToString();
            string trans_details = "";
            string rcpt_no = "";
            if (type == "Income")
            {
                period = "Received On " + period;
                desc = "Received From " + desc;
                trans_details = "Received ";
                rcpt_no = "Receipt No.: " + id_value.PadLeft(5, '0');
            }
            else
            {
                period = "Paid On " + period;
                desc = "Paid To " + desc;
                trans_details = "Paid ";
                rcpt_no = "Voucher No.: " + id_value.PadLeft(5, '0');

            }

            Dictionary<string, object> frmParams = new Dictionary<string, object>();
            Dictionary<string, string> rptParams = new Dictionary<string, string>();
            
            string rptHeading = ConfigurationManager.AppSettings["Institute_Name"].ToString();
            string rptSubHeading = ConfigurationManager.AppSettings["Jamaat_Name"].ToString();
            trans_details += string.Format("an amount of {0} as {1} by {2}", amount,
               inc_exp_name,pay_method);
            rptParams.Add("Period", period);
            rptParams.Add("Name", desc);
            rptParams.Add("trans_details", trans_details);
            rptParams.Add("Report_Heading", rptHeading);
            rptParams.Add("Report_Sub_Heading", rptSubHeading);
            rptParams.Add("rcpt_no", rcpt_no);
            frmParams.Add("reportParams", rptParams);
            frmParams.Add("reportName", "inc_exp_voucher.rdlc");
            Form objForm = new Report_Viewer(frmParams);
            common.showForm(objForm);

        }
    }
}
