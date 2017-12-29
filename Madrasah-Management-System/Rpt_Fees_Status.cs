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
    public partial class Rpt_Fees_Status : Form
    {
        public Rpt_Fees_Status()
        {
            InitializeComponent();
        }

        private void Rpt_Fees_Status_Load(object sender, EventArgs e)
        {
            fillStandardsCombo();
            cmb_standard.SelectedIndex = 0;
        }

        private void fillStandardsCombo()
        {
            DataSet ds = common.getDataSet("SELECT 0 ID,'All' NAME,-100 SEQUENCE UNION SELECT ID,NAME,SEQUENCE FROM STANDARDS ORDER BY SEQUENCE");
            cmb_standard.DataSource = ds.Tables[0];

            string selCmd = @"SELECT YEAR FROM(SELECT DISTINCT YEAR(FEES_FROM) 'YEAR' FROM FEES_DETAILS WHERE FEES_FROM IS NOT NULL
            UNION SELECT DISTINCT YEAR(FEES_TO) 'YEAR' FROM FEES_DETAILS WHERE FEES_TO IS NOT NULL) A ORDER BY YEAR";
            ds = common.getDataSet(selCmd);
            cmb_year.DataSource = ds.Tables[0];
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string from_month = "01-JUNE-"+cmb_year.SelectedValue.ToString();
             string year = cmb_year.SelectedValue.ToString();
            string next_year = (int.Parse(cmb_year.SelectedValue.ToString())+1).ToString();
            string to_month = "31-MAY-"+(next_year).ToString();
            string standard = cmb_standard.SelectedValue.ToString() == "0" ? "1=1" : "ST.STANDARD = "+cmb_standard.SelectedValue.ToString();
            string selCmd = string.Format(@"SELECT MAX(ST.NAME) STU_NAME,MAX(ST.MHR_NO) MHR_NO,MAX(ST.ITS_ID) ITS_ID,
            FORMAT(MIN(FD.FEES_FROM),'dd-MMM-yyyy') 'FROM',MAX(SD.NAME) STANDARD ,FORMAT(MAX(FD.FEES_TO),'dd-MMM-yyyy') 'TO', 
            MAX(FD.MONTHLY_FEES) MONTHLY_FEES  FROM STUDENTS ST 
            INNER JOIN FEES_DETAILS FD ON ST.ID = FD.STUDENT
            INNER JOIN STANDARDS SD ON SD.ID = ST.STANDARD
            WHERE FD.FEES_FROM >= '{0}' AND FD.FEES_TO <= '{1}' AND {2}
            GROUP BY FD.STUDENT", from_month,to_month,standard);
            Dictionary<int, string> months = new Dictionary<int, string>();

            var dt_fees = common.getDataSet(selCmd).Tables[0];
            if (dt_fees.Rows.Count <= 0) {
                MessageBox.Show("No Records Found");
                return;
            }
            addMonthCols(dt_fees,months);
            foreach (DataRow dr in dt_fees.Rows) {
                DateTime dt_from =  common.parseDate(dr["from"].ToString());
                DateTime dt_to = common.parseDate(dr["to"].ToString());
                
                while (dt_from <= dt_to) {
                    int mnth = dt_from.Month;
                    string mnt_name = months[mnth];
                   dr[mnt_name] = dr["monthly_fees"];
                   dt_from = dt_from.AddMonths(1);
                }
                if (chk_defaulters.Checked) {
                   
                    DateTime till_dt = DateTime.Now.AddMonths(-1);
                    DateTime to_dt = common.parseDate("31-May-" + next_year);
                    DateTime from_dt = common.parseDate("01-Jun-" + year);
                    if (till_dt > to_dt) { // if current date is greater than academic year
                        till_dt = to_dt;
                    }

                    while (from_dt <= till_dt)
                    {
                        int mnth = from_dt.Month;
                        string mnt_name = months[mnth];
                        if (dr[mnt_name].ToString() == "") {
                            dr["isDefaulter"] = "1";
                        }
                        from_dt = from_dt.AddMonths(1);
                    }
                }
            }

            if (chk_defaulters.Checked) { 
                //string year = cmb_year.SelectedValue.ToString();
                //DateTime from_dt = common.parseDate("01-Jun-" + year);
                dt_fees.DefaultView.RowFilter = "isDefaulter = '1'";
                dt_fees = dt_fees.DefaultView.ToTable();
            }
            Dictionary<string, object> frmParams = new Dictionary<string, object>();
            Dictionary<string, string> rptParams = new Dictionary<string, string>();
            string period = "For Academic Year " + year + " - " + next_year;
           
            string rptHeading = ConfigurationManager.AppSettings["Institute_Name"].ToString();
            string rptSubHeading = ConfigurationManager.AppSettings["Jamaat_Name"].ToString();
            rptParams.Add("Period", period);
          
            rptParams.Add("Report_Heading", rptHeading);
            rptParams.Add("Report_Sub_Heading", rptSubHeading);

            
            frmParams.Add("reportDataSrc", dt_fees);
            frmParams.Add("reportParams", rptParams);
            frmParams.Add("reportName", "fees_status.rdlc");
            Form objForm = new Report_Viewer(frmParams);
            common.showForm(objForm);
            
        }

        private void addMonthCols(DataTable dt, Dictionary<int, string> months)
        {
            DateTime from = common.parseDate("01-Jun-2017");

            for (int i = 1; i <= 12; i++) {
                string month_name = from.ToString("MMM");
                int month = from.Month;
                months.Add(month, month_name);
                dt.Columns.Add(month_name);
                from = from.AddMonths(1);
            }
            dt.Columns.Add("isDefaulter");
        }
    }
}
