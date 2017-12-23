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
using Microsoft.VisualBasic;
namespace Madrasah_Management_System
{
    public partial class FeeCollection : Form
    {
        public FeeCollection()
        {
            InitializeComponent();

        }
        private string _studentID;
        private string _feesAmount;
        private DataSet _dsFeesData;
        private DataRow studentRow;
        public FeeCollection(DataRow studentRow)
        {
            InitializeComponent();

            try
            {

                this.studentRow = studentRow;
                txt_stu_name.Text = studentRow["name"].ToString();
                txt_mhr_no.Text = studentRow["mhr_no"].ToString();
                txt_stu_std.Text = studentRow["standard"].ToString();
                txt_mnth_fees.Text = studentRow["fees"].ToString();
                txt_its_id.Text = studentRow["its_id"].ToString();
                _studentID = studentRow["id"].ToString();
                _feesAmount = studentRow["fees"].ToString();
                cmb_pay_method.SelectedIndex = 0;
                var incTypes = common.getDataSet("SELECT ID,NAME 'Fees Type','0.00' Amount FROM INC_EXP_HEADS WHERE TYPE='Income' AND SUB_TYPE=1");
                //exp_heads_grid.DataSource = incTypes.Tables[0];
                //exp_heads_grid.Columns[0].Visible = false;
                //exp_heads_grid.Columns[1].Width = 150;
                //exp_heads_grid.Columns[2].Width = 200;
                //exp_heads_grid.Columns[1].ReadOnly = true;
                //_dsFeesData = common.getDataSet("SELECT * FROM STANDARDS_FEES");
                //var d = new DataGridViewTextBoxCell();
                //exp_heads_grid.Columns[2].CellTemplate = new DataGridViewTextBoxCell();

                //cmb_inc_type.DataSource = incType.Tables[0];
                //string dfltType = incType.Tables[0].Select("sub_type=1")[0]["ID"].ToString();
                //cmb_inc_type.SelectedValue = int.Parse(dfltType);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        Form objForm;


        private void button2_Click(object sender, EventArgs e)
        {

            objForm = new StudentSearch();
            common.showForm(objForm);
            this.Close();
        }

        private void FeeCollection_Load(object sender, EventArgs e)
        {

        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            //string fees = txt_fees.Text.Trim();
            float fltFees;
            //if (fees == string.Empty || float.TryParse(fees, out fltFees) == false)
            //{
            //    MessageBox.Show("Please Enter Valid Amount for Fees");
            //    return;
            //}
            if (calculateFees() == false)
            {
                return;
            }
            string from_month = dp_from_month.Value.ToString("dd-MMM-yyyy");
            string to_month = dp_to_month.Value.ToString("dd-MMM-yyyy");
            string pay_method = cmb_pay_method.Text;
            string incm_type = "(SELECT ID FROM INC_EXP_HEADS WHERE SUB_TYPE = 1)";//cmb_inc_type.SelectedValue.ToString();
            string fees_paid = "0";// txt_fees.Text;
            string comments = txt_comments.Text.Trim();
            string insertCmd = "";
            if (checkIfDuplicate() == true)
            {
                DialogResult dlg = MessageBox.Show("Record already exists, do you still want to create a new record", "Record Exists", MessageBoxButtons.YesNo);
                if (dlg == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            if (comments == string.Empty)
            {
                comments = string.Format("Received amount {0} against income head {1}", fees_paid, "Monthly Fees");
            }
            insertCmd = string.Format(@"INSERT INTO FEES_DETAILS(STUDENT,FEES_FROM,FEES_TO,PAYMENT_METHOD,INCOME_HEAD,FEES_AMOUNT,FEES_PAID,COMMENTS) 
            VALUES({0},'{1}','{2}','{3}',{4},{5},{6},'{7}')", _studentID, from_month, to_month, pay_method, incm_type, _feesAmount, fees_paid, comments);
            string returnVal = common.updateTable(insertCmd);
            if (returnVal == common.SUCCESS_MSG)
            {
                DialogResult dlg = MessageBox.Show("Record Saved Successfully. Do you want to print Fees Receipt now?", "Saved Successfully", MessageBoxButtons.YesNo);
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    showFeesReceipt();
                }
            }
            else
            {
                MessageBox.Show(returnVal);
            }
        }

        private void showFeesReceipt()
        {
            Dictionary<string, object> frmParams = new Dictionary<string, object>();
            Dictionary<string, string> rptParams = new Dictionary<string, string>();
            string period = "For Month " + dp_from_month.Value.ToString("MMMM-yyyy");
            string mhr_no = studentRow["mhr_no"].ToString();
            string name = studentRow["name"].ToString();
            string standard = studentRow["standard"].ToString();
            string rptHeading = ConfigurationManager.AppSettings["Institute_Name"].ToString();
            string fees_details = string.Format("Received an amount of {0} on {1} by {2}", 0,
                DateTime.Now.ToString("dd-MMM-yyyy"), cmb_pay_method.Text);
            rptParams.Add("Period", period);
            rptParams.Add("MHR_No", mhr_no);
            rptParams.Add("Name", name);
            rptParams.Add("Fees_details", fees_details);
            rptParams.Add("Report_Heading", rptHeading);
            rptParams.Add("Standard", standard);
            frmParams.Add("reportParams", rptParams);
            frmParams.Add("reportName", "fee_receipt.rdlc");
            Form objForm = new Report_Viewer(frmParams);
            common.showForm(objForm);
        }

        private bool checkIfDuplicate()
        {
            //string incmHd = cmb_inc_type.SelectedValue.ToString();
            string year = dp_from_month.Value.Year.ToString();
            string month = dp_from_month.Value.Month.ToString();
            string selCmd = string.Format(@"SELECT * FROM FEES_DETAILS WHERE STUDENT = {0} AND
            MONTH(FEES_FOR)={1} AND YEAR(FEES_FOR)={2}", _studentID, month, year);
            var ds = common.getDataSet(selCmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool calculateFees()
        {
            if (dp_from_month.Value > dp_to_month.Value)
            {
                MessageBox.Show("From Date should be less than To Date");
                return false;
            }
            long month_count = common.DateDiff(common.DateInterval.Month, dp_from_month.Value, dp_to_month.Value);
            _feesAmount = txt_mnth_fees.Text = (float.Parse(studentRow["fees"].ToString()) * month_count).ToString();

            return true;
        }

        private void dp_to_month_ValueChanged(object sender, EventArgs e)
        {
            calculateFees();
        }

        private void checkForNumbers(object sender,KeyPressEventArgs e) {

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

        private void chk_mnth_fees_CheckedChanged(object sender, EventArgs e)
        {
            txt_mnth_fees.Enabled = chk_mnth_fees.Checked;
        }

        private void chk_exm_fees_CheckedChanged(object sender, EventArgs e)
        {
            txt_exm_fees.Enabled = chk_exm_fees.Checked;
        }

        private void chk_anl_fees_CheckedChanged(object sender, EventArgs e)
        {
            txt_exm_fees.Enabled = chk_exm_fees.Checked;
        }

        
    }
}