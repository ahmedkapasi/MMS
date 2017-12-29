using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madrasah_Management_System
{
    public partial class RentCollection : Form
    {
        DataSet ds_prop_dtls;
        public RentCollection()
        {
            InitializeComponent();
            //printDocument("2");
            //return;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (cmb_properties.Items.Count == 0)
            {
                MessageBox.Show("No Properties To Collect Rent, Please make a Lease Entry.");
                return;
            }
            if (dp_from.Value > dp_to.Value)
            {
                MessageBox.Show("From Date can not be less than To Date");
                dp_from.Focus();
                return;
            }
            calculateTotalRent();
            dp_from.Value = DateTime.ParseExact(dp_from.Value.ToString("01/MMM/yyyy"), "dd/MMM/yyyy", CultureInfo.InvariantCulture);
            dp_to.Value = DateTime.ParseExact(dp_to.Value.AddMonths(1).ToString("01/MMM/yyyy"), "dd/MMM/yyyy", CultureInfo.InvariantCulture);
            dp_to.Value = dp_to.Value.AddDays(-1); //last day of the month
            string property = cmb_properties.SelectedValue.ToString();
            string from_dt = dp_from.Value.ToString("yyyy-MMM-dd");
            string to_dt = dp_to.Value.ToString("yyyy-MMM-dd");
            string amount = txt_tot_rent.Text;
            string date = dp_recvd_on.Value.ToString("yyyy-MMM-dd");
            string pay_method = cmb_pay_method.Text;
            string insrtCmd = string.Format(@"INSERT INTO RENT_DETAILS(LEASE_ID,RENT_FROM,RENT_TO,RECVD_ON,AMOUNT,PAY_METHOD)
            VALUES({0},'{1}','{2}','{3}',{4},'{5}')", property, from_dt, to_dt, date, amount,pay_method);
            string id_value;
            string retVal = common.updateTable(insrtCmd,out id_value);
            if (retVal == common.SUCCESS_MSG)
            {
               var dlg = MessageBox.Show("Record Saved Successfully, Do you want to print receipt now ?","Record Saved",MessageBoxButtons.YesNo);
               if (dlg == DialogResult.Yes) {
                   printDocument(id_value);
               }
               loadGridData();
            }
            else
            {
                MessageBox.Show(retVal);
            }
        }

        private void printDocument(string id_value)
        {
            var dt = common.getDataSet(@"SELECT PR.NAME 'stu_name',TN.NAME 'Tenant',RD.PAY_METHOD,
            FORMAT(RD.RECVD_ON,'dd-MMM-yyyy') 'Recvd On',RD.AMOUNT,
            FORMAT(RD.RENT_FROM,'dd-MMM-yyyy') 'Rent From',FORMAT(RD.RENT_TO,'dd-MMM-yyyy') 'Rent To'
            FROM LEASE_DETAILS LD INNER JOIN 
            PROPERTIES PR ON LD.PROPERTY = PR.ID 
            INNER JOIN tenants TN ON TN.ID = LD.TENANT
            INNER JOIN RENT_DETAILS RD ON RD.lease_id = LD.ID AND RD.ID =" + id_value).Tables[0];
            if (dt.Rows.Count <= 0)
            {
                return;
            }
            DataRow dr = dt.Rows[0];
            string property = dr["stu_name"].ToString();
            string tenant = dr["Tenant"].ToString();
            string period = string.Format("Rent For {0} To {1}",dr["Rent From"].ToString(),dr["Rent To"].ToString());
            string pay_method = dr["pay_method"].ToString();
            string trans_details = "";
            string todays_date = "Received On: " + dr["Recvd On"].ToString();
            string amount = dr["Amount"].ToString();
            string rcpt_no = "Receipt No.: " + id_value.PadLeft(5, '0');
            

            Dictionary<string, object> frmParams = new Dictionary<string, object>();
            Dictionary<string, string> rptParams = new Dictionary<string, string>();

            string rptHeading = ConfigurationManager.AppSettings["Institute_Name"].ToString();
            string rptSubHeading = ConfigurationManager.AppSettings["Jamaat_Name"].ToString();
            trans_details += string.Format("Received an amount of {0} as Monthly Rent by {1} from {2} for Flat/Shop {3}", amount,
                pay_method,tenant,property);
            rptParams.Add("Period", period);
            rptParams.Add("todays_date", todays_date);
            rptParams.Add("trans_details", trans_details);
            rptParams.Add("Report_Heading", rptHeading);
            rptParams.Add("Report_Sub_Heading", rptSubHeading);
            rptParams.Add("rcpt_no", rcpt_no);
            frmParams.Add("reportParams", rptParams);
            frmParams.Add("reportName", "Rent_Receipt.rdlc");
            Form objForm = new Report_Viewer(frmParams);
            common.showForm(objForm);
        }

        private void RentCollection_Load(object sender, EventArgs e)
        {
            cmb_pay_method.SelectedIndex = 0;
            dp_from.Value = DateTime.ParseExact(DateTime.Now.ToString("01/MMM/yyyy"), "dd/MMM/yyyy", CultureInfo.InvariantCulture);
            dp_to.Value = DateTime.ParseExact(DateTime.Now.AddMonths(1).ToString("01/MMM/yyyy"), "dd/MMM/yyyy", CultureInfo.InvariantCulture);
            dp_to.Value = dp_to.Value.AddDays(-1); //last day of the month
                
            loadData();
        }

        private void loadData()
        {
            string selCmd = string.Format(@"SELECT LD.ID ,PR.NAME,TN.NAME 'TENANT',LD.RENT_AMOUNT FROM LEASE_DETAILS LD INNER JOIN 
           PROPERTIES PR ON LD.PROPERTY = PR.ID INNER JOIN TENANTS TN ON TN.ID = LD.TENANT 
            WHERE '{0}' BETWEEN LD.LEASE_START AND LD.LEASE_END", DateTime.Now.ToString("yyyy-MMM-dd"));
            ds_prop_dtls = common.getDataSet(selCmd);
            if (ds_prop_dtls.Tables[0].Rows.Count > 0)
            {
                cmb_properties.DataSource = ds_prop_dtls.Tables[0];
            }
            loadGridData();

        }

        private void loadGridData()
        {
            string selCmd = @"SELECT LD.ID,PR.NAME 'stu_name',TN.NAME 'Tenant',FORMAT(RD.RENT_FROM,'dd-MMM-yyyy') 'Rent From',FORMAT(RD.RENT_TO,'dd-MMM-yyyy') 'Rent To'
                            FROM LEASE_DETAILS LD INNER JOIN 
                            PROPERTIES PR ON LD.PROPERTY = PR.ID 
                            INNER JOIN tenants TN ON TN.ID = LD.TENANT
                            INNER JOIN RENT_DETAILS RD ON RD.lease_id = LD.ID";
            var ds = common.getDataSet(selCmd);
            dg_rent_dtls.DataSource = ds.Tables[0];
            dg_rent_dtls.Columns[0].Visible = false;
        }

        private void cmb_properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmb_properties.SelectedValue.ToString();
            DataRow dr = ds_prop_dtls.Tables[0].Select("id='"+id+"'")[0];
            txt_tent_name.Text = dr["TENANT"].ToString();
            txt_tot_rent.Text = txt_mnth_rent.Text = dr["RENT_AMOUNT"].ToString();


        }

        private void dp_to_ValueChanged(object sender, EventArgs e)
        {
            calculateTotalRent();
        }

        private void calculateTotalRent() {
            
            if (dp_from.Value > dp_to.Value)
            {
                return;
            }
            if (txt_mnth_rent.Text == "") {
                return;
            }
            //DateTime from_date = dp_from_month.Value.AddMonths(1);
            long month_count = common.DateDiff(common.DateInterval.Month, dp_from.Value, dp_to.Value) + 1;
            txt_tot_rent.Text = (float.Parse(txt_mnth_rent.Text) * month_count).ToString();

        }
    }
}
