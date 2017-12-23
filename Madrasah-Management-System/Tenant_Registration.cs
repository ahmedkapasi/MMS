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
    public partial class Tenant_Registration : Form
    {
        public Tenant_Registration()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Tenant Name");
                txt_name.Focus();
                return;
            }

            string name = txt_name.Text.Trim();
            string its_id = txt_its_id.Text.Trim();
            string gender = cmb_gender.Text;
            string address = txt_address.Text.Trim();
            string phone_no = txt_phone_no.Text.Trim();
            string pancard_no = txt_pan_no.Text.Trim();
            string adhaarcard_no = txt_adhaar_no.Text.Trim();

            string insrtCmd = string.Format(@"INSERT INTO TENANTS(NAME,ITS_ID,GENDER,
            ADDRESS,PHONE_NO,PANCARD_NO,ADHAARCARD_NO)
            VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", 
            name, its_id, gender, address, phone_no, pancard_no, adhaarcard_no);

            string retVal = common.updateTable(insrtCmd);
            if (retVal == common.SUCCESS_MSG)
            {
                MessageBox.Show("Record Saved Successfully");
            }
            else {
                MessageBox.Show(retVal);
            }
            
        }

        private void Tenant_Registration_Load(object sender, EventArgs e)
        {
            cmb_gender.SelectedIndex = 0;
        }
    }
}
