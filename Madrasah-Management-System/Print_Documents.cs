using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madrasah_Management_System
{
    class Print_Documents
    {
        static string rptHeading = ConfigurationManager.AppSettings["Institute_Name"].ToString();
        static string rptSubHeading = ConfigurationManager.AppSettings["Jamaat_Name"].ToString();
        
        public static void printIncExpReceipt(string id_value)
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

            
            trans_details += string.Format("an amount of {0} as {1} by {2}", amount,
               inc_exp_name, pay_method);
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

        public static void printRentReceipt(string id_value)
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
                MessageBox.Show("No Records Found");
                return;
            }
            DataRow dr = dt.Rows[0];
            string property = dr["stu_name"].ToString();
            string tenant = dr["Tenant"].ToString();
            string period = string.Format("Rent For {0} To {1}", dr["Rent From"].ToString(), dr["Rent To"].ToString());
            string pay_method = dr["pay_method"].ToString();
            string trans_details = "";
            string todays_date = "Received On: " + dr["Recvd On"].ToString();
            string amount = dr["Amount"].ToString();
            string rcpt_no = "Receipt No.: " + id_value.PadLeft(5, '0');


            Dictionary<string, object> frmParams = new Dictionary<string, object>();
            Dictionary<string, string> rptParams = new Dictionary<string, string>();

            
            trans_details += string.Format("Received an amount of {0} as Monthly Rent by {1} from {2} for Flat/Shop {3}", amount,
                pay_method, tenant, property);
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

        public static void printFeesReceipt(string id_value)
        {
            string selCmd = string.Format(@"SELECT ST.NAME,ST.MHR_NO,STD.NAME 'STANDARD',FORMAT(FEES_FROM,'{0}') 'FEES_FROM', 
            FORMAT(FEES_TO,'{0}') 'FEES_TO',FORMAT(RECVD_ON,'dd-MMM-yyyy') 'RECVD_ON',TOTAL_PAID,PAYMENT_METHOD  
            FROM FEES_DETAILS FD,STUDENTS ST,STANDARDS STD 
            WHERE FD.ID ={1} AND FD.STUDENT = ST.ID AND STD.ID=ST.STANDARD", "MMM-yyyy", id_value);
            var dt = common.getDataSet(selCmd).Tables[0];
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No Records Found");
                return;
            }
            var dr = dt.Rows[0];
            Dictionary<string, object> frmParams = new Dictionary<string, object>();
            Dictionary<string, string> rptParams = new Dictionary<string, string>();
            string period = "Paid For " + dr["FEES_FROM"] + " To " + dr["FEES_TO"];
            string mhr_no = dr["mhr_no"].ToString();
            string name = dr["name"].ToString();
            string standard = dr["standard"].ToString();
            string fees_amount = dr["total_paid"].ToString();
            string pay_method = dr["payment_method"].ToString();
            string recvd_on = dr["recvd_on"].ToString();
            string fees_details = string.Format("Received an amount of {0} on {1} by {2}", fees_amount, recvd_on, pay_method);
            string rcpt_no = "Receipt No.: " + id_value.PadLeft(5, '0');
            rptParams.Add("Period", period);
            rptParams.Add("MHR_No", mhr_no);
            rptParams.Add("Name", name);
            rptParams.Add("Fees_details", fees_details);
            rptParams.Add("Rcpt_No", rcpt_no);
            rptParams.Add("Report_Heading", rptHeading);
            rptParams.Add("Report_Sub_Heading", rptSubHeading);

            rptParams.Add("Standard", standard);
            frmParams.Add("reportParams", rptParams);
            frmParams.Add("reportName", "fee_receipt.rdlc");
            Form objForm = new Report_Viewer(frmParams);
            common.showForm(objForm);
        }
    }
}
