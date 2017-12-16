using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Madrasah_Management_System
{
    public partial class StudentSearch : Form
    {
        DataSet student_ds = new DataSet("students");
        public StudentSearch()
        {
            InitializeComponent();
        }

        private void StudentSearch_Load(object sender, EventArgs e)
        {
            try
            {
                
                string cmd = @"SELECT STU.ID,ST.FEES,STU.NAME,STU.MHR_NO,STU.ITS_ID,ST.name 'STANDARD'
                FROM STUDENTS STU,STANDARDS ST WHERE STU.STANDARD = ST.ID";
                student_ds = common.getDataSet(cmd);
                dataGridView1.DataSource = student_ds.Tables[0];
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["FEES"].Visible = false;
                dataGridView1.Columns["NAME"].Width = 300;
                dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
                dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showFeeForm(e.RowIndex);
        }

        void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            showFeeForm(e.RowIndex);
        }

        void showFeeForm(int rowIndx) {
            Form fc = new FeeCollection(student_ds.Tables[0].Rows[rowIndx]);
            fc.MdiParent = this.MdiParent;
            fc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rowFilter = "";

            string name = txt_name.Text;
            string its_id = txt_its_no.Text;
            string mhr_no = txt_mhr_no.Text;
            if (name.Trim() != string.Empty) {
                rowFilter += "name like '%" + name + "%'";
            }
            if (its_id.Trim() != string.Empty)
            {
                rowFilter += rowFilter != "" ? " or " : "";
                rowFilter +=  "its_id = '" + its_id + "'";
            }
            if (mhr_no.Trim() != string.Empty)
            {
                rowFilter += rowFilter != "" ? " or " : "";
                rowFilter += "mhr_no = '" + mhr_no + "'";
            }

            student_ds.Tables[0].DefaultView.RowFilter = rowFilter;
            dataGridView1.DataSource = student_ds.Tables[0].DefaultView;
        }
    }
}
