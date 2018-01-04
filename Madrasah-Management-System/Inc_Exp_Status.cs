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

            string selCmd = string.Format(@"select Name,Amount,[Pay Method],Comments,Type,format(Date,'dd-MMM-yyyy') Date 
            from(select Name,fd.total_paid 'Amount',fd.payment_method 'Pay Method',fd.Comments,ie.Type,fd.date_created 'Date'
            from fees_details fd,inc_exp_heads ie
            where  fd.inc_exp_head = ie.id
            union
            select Name,eit.Amount,eit.pay_method 'Pay Method',eit.Comments,ie.Type,eit.date_created 'Date'
            from inc_exp_trans eit,inc_exp_heads ie
            where  eit.inc_exp_head = ie.id
            union
            select Name,rd.Amount,rd.pay_method 'Pay Method',rd.Comments,ie.Type,rd.date_created  'Date'
            from rent_details rd,inc_exp_heads ie
            where  rd.inc_exp_head = ie.id) a
            where date between '{0}' and '{1}'
            order by a.type", from_date, to_date);

            var ds = common.getDataSet(selCmd);
            if (ds.Tables[0].Rows.Count <= 0) {
                MessageBox.Show("No Records Found");
                return;
            }
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
