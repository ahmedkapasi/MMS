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
    public partial class ExpenseMaster : Form
    {
        bool isEdit = false;
        DataRow dataRowEdited;
        public ExpenseMaster()
        {
            InitializeComponent();
        }

        private void ExpenseMaster_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void loadData()
        {

            DataSet ds = common.getDataSet("SELECT ID,Name,TYPE Type,GL_CODE 'GL Code' FROM INC_EXP_HEADS");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["NAME"].Width = 150;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            cmb_type.SelectedIndex = 0;
        }

        void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isEdit = true;
            DataRow dr = dataRowEdited = (dataGridView1.DataSource as DataTable).Rows[e.RowIndex];
            txt_name.Text = dr["name"].ToString();
            txt_gl_code.Text = dr["gl code"].ToString();
            cmb_type.SelectedIndex = dr["type"].ToString() == "Income" ? 0 : 1;
            txt_name.Enabled = false;
            cmb_type.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string type = cmb_type.Text;
            
            string glcode = txt_gl_code.Text;
            if (name == string.Empty)
            {
                MessageBox.Show("Please Enter a Name");
                return;
            }
            string selCmd = "SELECT * FROM INC_EXP_HEADS WHERE NAME='" + txt_name.Text.Trim() + "'";
            if (isEdit == true)
            {
                selCmd += " AND ID != " + dataRowEdited["ID"].ToString();
            }
            DataSet ds = common.getDataSet(selCmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Name already Exists, Select a different name");
                return;
            }
            string dmlCmd = "";
            if (isEdit == false)
            {
                dmlCmd = string.Format(@"INSERT INTO INC_EXP_HEADS(NAME,TYPE,GL_CODE) 
            VALUES('{0}','{1}','{2}')", name, type, glcode);
            }
            else
            {
                dmlCmd = string.Format(@"UPDATE INC_EXP_HEADS SET GL_CODE = '{0}'
                WHERE ID={1}", glcode, dataRowEdited["ID"].ToString());
            }
            string retVal = common.updateTable(dmlCmd);
            if (retVal == common.SUCCESS_MSG)
            {
                MessageBox.Show("Record Saved Successfully");
                loadData();
            }
            else
            {
                MessageBox.Show(retVal);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            isEdit = false;
            txt_gl_code.Text = "";
            txt_name.Text = "";
            txt_name.Enabled = true;
            cmb_type.Enabled = true;
            cmb_type.SelectedIndex = 0;
        }

        
    }
}
