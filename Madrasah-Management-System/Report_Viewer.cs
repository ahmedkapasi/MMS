using Microsoft.Reporting.WinForms;
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
    public partial class Report_Viewer : Form
    {
        
        public Report_Viewer(Dictionary<string, object> reportDtls)
        {
            InitializeComponent();
            LocalReport localReport = reportViewer1.LocalReport;

            string reportName = reportDtls["reportName"].ToString();
            if (reportName == "fees_status.rdlc") {
                reportViewer1.Width = 1200;
                this.Width = 1200;
            }
            localReport.ReportPath = reportName;
            
            if (reportDtls.Keys.Contains("reportParams"))
            {
                Dictionary<string, string> rptParams = reportDtls["reportParams"] as Dictionary<string, string>;
                List<ReportParameter> reportParam = new List<ReportParameter>();
                foreach (string key in rptParams.Keys)
                {
                    reportParam.Add(new ReportParameter(key, rptParams[key]));
                }
                 localReport.SetParameters(reportParam);
            }

            if (reportDtls.Keys.Contains("reportDataSrc"))
            {
                ReportDataSource rds = new ReportDataSource("reportDataSrc");
                rds.Value = (reportDtls["reportDataSrc"] as DataTable);
                rds.Name = "DataSet1";
                localReport.DataSources.Add(rds);
            }
            //else {
            //    ReportDataSource rds = new ReportDataSource("reportDataSrc");
            //    DataSet ds = new DataSet();
            //    ds.Tables.Add(new DataTable());
            //    rds.Value = ds.Tables[0];
            //    localReport.DataSources.Add(rds);
            //}
            reportViewer1.Show();
            
            reportViewer1.RefreshReport();
        }

        private void Report_Viewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
