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
    public partial class RentCollection : Form
    {
        DataSet ds_prop_dtls;
        public RentCollection()
        {
            InitializeComponent();
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

            string property = cmb_properties.SelectedValue.ToString();
            string from_dt = dp_from.Value.ToString("yyyy-MMM-dd");
            string to_dt = dp_to.Value.ToString("yyyy-MMM-dd");
            string amount = txt_tot_rent.Text;
            string date = DateTime.Now.ToString("yyyy-MMM-dd");
            string insrtCmd = string.Format(@"INSERT INTO RENT_DETAILS(LEASE_ID,RENT_FROM,RENT_TO,RECEIVED_ON,TOTAL_RENT)
            VALUES({0},'{1}','{2}','{3}',{4})", property, from_dt, to_dt, date, amount);

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

        private void RentCollection_Load(object sender, EventArgs e)
        {
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
            string selCmd = @"SELECT LD.ID,PR.NAME 'Property',TN.NAME 'Tenant',FORMAT(RD.RENT_FROM,'dd-MMM-yyyy') 'Rent From',FORMAT(RD.RENT_TO,'dd-MMM-yyyy') 'Rent To'
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
    }
}
