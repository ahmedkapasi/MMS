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
    public partial class FeeCollection : Form
    {
        public FeeCollection()
        {
            InitializeComponent();
        }
        public FeeCollection(DataRow studentRow)
        {
            InitializeComponent();
            try
            {
                txt_stu_name.Text = studentRow["name"].ToString();
                txt_mhr_no.Text = studentRow["mhr_no"].ToString();
                txt_stu_std.Text = studentRow["standard"].ToString();
                txt_fees.Text = studentRow["fees"].ToString();
                cmb_pay_method.SelectedIndex = 0;
               var incType = common.getDataSet("SELECT * FROM INC_EXP_HEADS WHERE TYPE='Income'");
               cmb_inc_type.DataSource = incType.Tables[0];
               cmb_inc_type.DisplayMember = "name";
               cmb_inc_type.ValueMember = "id";
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        Form objForm;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            objForm = new StudentSearch();
            common.showForm(objForm);
            this.Close();
        }

        private void FeeCollection_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void chk_inc_type_CheckedChanged(object sender, EventArgs e)
        {
            cmb_inc_type.Enabled = chk_inc_type.Checked;
        }

        private void chk_fees_CheckedChanged(object sender, EventArgs e)
        {
            txt_fees.Enabled = chk_fees.Checked;
        }

        private void chk_comments_CheckedChanged(object sender, EventArgs e)
        {
            txt_comments.Enabled = chk_comments.Checked;
        }
    }
}