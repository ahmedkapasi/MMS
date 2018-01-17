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
    public partial class Lease_Property : base_form
    {
        public Lease_Property()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_rent.Text.Trim() == string.Empty || float.Parse(txt_rent.Text) <= 0)
            {
                MessageBox.Show("Invalid Rent Amount");
                txt_rent.Focus();
                return;
            }

            string property = cmb_properties.SelectedValue.ToString();
            string tenant = cmb_tenants.SelectedValue.ToString();
            string amount = txt_rent.Text.Trim();
            string from_dt= dp_from_month.Value.ToString("yyyy-MMM-dd");
            string to_dt = dp_to_month.Value.ToString("yyyy-MMM-dd");
            string insrtCmd = string.Format(@"INSERT INTO LEASE_DETAILS(PROPERTY,TENANT,LEASE_START,LEASE_END,RENT_AMOUNT)
            VALUES({0},{1},'{2}','{3}',{4})", property, tenant, from_dt, to_dt,amount);

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

        private void Lease_Property_Load(object sender, EventArgs e)
        {
            var tenants = common.getDataSet("SELECT * FROM TENANTS");
            var properties = common.getDataSet("SELECT * FROM PROPERTIES");
            cmb_properties.DataSource = properties.Tables[0];
            cmb_tenants.DataSource = tenants.Tables[0];
            cmb_tenants.SelectedIndex = cmb_properties.SelectedIndex = 0;
            loadGridData();
        }

        private void loadGridData()
        {
            string selCmd = @"SELECT PR.NAME 'Property',TN.NAME 'Tenant',FORMAT(LD.lease_start,'dd-MMM-yyyy') 'Lease From',FORMAT(LD.lease_end,'dd-MMM-yyyy') 'Lease To'
                            FROM LEASE_DETAILS LD INNER JOIN 
                            PROPERTIES PR ON LD.PROPERTY = PR.ID 
                            INNER JOIN TENANTS TN ON TN.ID = LD.tenant";
            var ds = common.getDataSet(selCmd);
            dg_lease_dtls.DataSource = ds.Tables[0];
        }

        private void checkForNumbers(object sender, KeyPressEventArgs e)
        {

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
    }
}
