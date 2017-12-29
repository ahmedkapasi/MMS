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
    public partial class Property_Registration : Form
    {
        public Property_Registration()
        {
            InitializeComponent();
        }

        private void Property_Registration_Load(object sender, EventArgs e)
        {
            var ds = common.getDataSet("SELECT * FROM INC_EXP_HEADS WHERE TYPE = 'Income'");
            cmb_inc_head.DataSource = ds.Tables[0];
            cmb_inc_head.SelectedIndex = 0;
            loadGridData();
        }

        private void loadGridData()
        {
            var ds = common.getDataSet(@"SELECT P.NAME 'stu_name',P.ADDRESS 'Address',I.NAME 'Income Head' 
            FROM PROPERTIES P,INC_EXP_HEADS I WHERE P.INC_HEAD = I.ID");

            dg_prop_dtls.DataSource = ds.Tables[0];
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter stu_name Name");
                txt_name.Focus();
                return;
            }

            string name = txt_name.Text.Trim();
            string inc_head = cmb_inc_head.SelectedValue.ToString();
            string address = txt_address.Text.Trim();
            string insrtCmd = string.Format(@"INSERT INTO PROPERTIES(NAME,ADDRESS,INC_HEAD)
            VALUES('{0}','{1}','{2}')",name, address, inc_head);

            string retVal = common.updateTable(insrtCmd);
            if (retVal == common.SUCCESS_MSG)
            {
                MessageBox.Show("Record Saved Successfully");
                loadGridData();
            }
            else
            {
                MessageBox.Show(retVal);
            }
        }
    }
}
