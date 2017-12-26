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
            DataSet ds = common.getDataSet("SELECT * FROM STANDARDS ORDER BY SEQUENCE");
            cmb_standard.Items.Add(new { id = 0, name = "All" });
            foreach (DataRow dr in ds.Tables[0].Rows) {
                cmb_standard.Items.Add(new { id = int.Parse(dr["id"].ToString()), name = dr["name"].ToString() });
            }

            string selCmd = @"SELECT YEAR FROM(SELECT DISTINCT YEAR(FEES_FROM) 'YEAR' FROM FEES_DETAILS WHERE FEES_FROM IS NOT NULL
            UNION SELECT DISTINCT YEAR(FEES_TO) 'YEAR' FROM FEES_DETAILS WHERE FEES_TO IS NOT NULL) A ORDER BY YEAR";
            ds = common.getDataSet(selCmd);
            cmb_year.DataSource = ds.Tables[0];
        }
    }
}
