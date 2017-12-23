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
    public partial class Lease_Property : Form
    {
        public Lease_Property()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void Lease_Property_Load(object sender, EventArgs e)
        {
            var tenants = common.getDataSet("SELECT * FROM TENANTS");
            var properties = common.getDataSet("SELECT * FROM PROPERTIES");
            cmb_properties.DataSource = properties.Tables[0];
            cmb_tenants.DataSource = tenants.Tables[0];
            cmb_tenants.SelectedIndex = cmb_properties.SelectedIndex = 0;
        }
    }
}
