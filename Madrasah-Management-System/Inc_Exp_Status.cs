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
    public partial class Inc_Exp_Status : Form
    {
        public Inc_Exp_Status()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string from_date = dp_from.Value.ToString("dd-MMM-yyyy");
            string to_date = dp_to.Value.ToString("dd-MMM-yyyy");

            string selCmd = string.Format(@"select REPLACE(STR(id, 6), SPACE(1), '0') Rcpt_No,Name,Amount,[Pay Method] 'Pay_Method',Comments,Type,format(Date,'dd-MMM-yyyy') Date 
            from(select fd.id,Name,fd.total_paid 'Amount',fd.payment_method 'Pay Method',fd.Comments,ie.Type,fd.date_created 'Date'
            from fees_details fd,inc_exp_heads ie
            where  fd.inc_exp_head = ie.id
            union
            select eit.id,Name,eit.Amount,eit.pay_method 'Pay Method',eit.Comments,ie.Type,eit.date_created 'Date'
            from inc_exp_trans eit,inc_exp_heads ie
            where  eit.inc_exp_head = ie.id
            union
            select rd.id,Name,rd.Amount,rd.pay_method 'Pay Method',rd.Comments,ie.Type,rd.date_created  'Date'
            from rent_details rd,inc_exp_heads ie
            where  rd.inc_exp_head = ie.id) a
            where format(date,'dd-MMM-yyyy') between '{0}' and '{1}'
            order by a.type desc", from_date, to_date);

            var ds = common.getDataSet(selCmd);
            if (ds.Tables[0].Rows.Count <= 0) {
                MessageBox.Show("No Records Found");
                return;
            }
            

            Dictionary<string, object> frmParams = new Dictionary<string, object>();
            Dictionary<string, string> rptParams = new Dictionary<string, string>();
            string period = "Income Expense Status From " + from_date+ " To " + to_date;
            string rptHeading = ConfigurationManager.AppSettings["Institute_Name"].ToString();
            string rptSubHeading = ConfigurationManager.AppSettings["Jamaat_Name"].ToString();
            rptParams.Add("Period", period);
            rptParams.Add("Report_Heading", rptHeading);
            rptParams.Add("Report_Sub_Heading", rptSubHeading);
            frmParams.Add("reportDataSrc", ds.Tables[0]);
            frmParams.Add("reportParams", rptParams);
            frmParams.Add("reportName", "inc_exp_status.rdlc");
            Form objForm = new Report_Viewer(frmParams);
            common.showForm(objForm);

        }
    }
}
