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
        private int _selectedRowIndx;

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
                dataGridView1.MouseDown += dataGridView1_MouseDown;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int rowIndx = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowIndx == -1) { return; }
                _selectedRowIndx = rowIndx;
                
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndx].Selected = true;
                contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
            }
        }

        

        void showStudentForm(int formType)
        {
            
            Form fc;
            DataRow dr = getSelectedRow();
            if (formType == 1)
            {
                fc = new Student_Registration(dr);
            }
            else {
                fc = new FeeCollection(dr);
            }
            
            fc.MdiParent = this.MdiParent;
            fc.Show();
        }

        private DataRow getSelectedRow()
        {
            DataRow dr;
            if (dataGridView1.DataSource.GetType() == typeof(DataView))
            {
                dr = (dataGridView1.DataSource as DataView).ToTable().Rows[_selectedRowIndx];
            }
            else
            {
                dr = (dataGridView1.DataSource as DataTable).Rows[_selectedRowIndx];
            }
            return dr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rowFilter = "";

            string name = txt_name.Text;
            string its_id = txt_its_no.Text;
            string mhr_no = txt_mhr_no.Text;
            if (name.Trim() != string.Empty)
            {
                rowFilter += "name like '%" + name + "%'";
            }
            if (its_id.Trim() != string.Empty)
            {
                rowFilter += rowFilter != "" ? " or " : "";
                rowFilter += "its_id = '" + its_id + "'";
            }
            if (mhr_no.Trim() != string.Empty)
            {
                rowFilter += rowFilter != "" ? " or " : "";
                rowFilter += "mhr_no = '" + mhr_no + "'";
            }

            student_ds.Tables[0].DefaultView.RowFilter = rowFilter;
            dataGridView1.DataSource = student_ds.Tables[0].DefaultView;

        }



        private void edit_record_Click(object sender, EventArgs e)
        {
            showStudentForm(1);

        }

        private void receive_fee_Click(object sender, EventArgs e)
        {
            showStudentForm(2);
        }

        private void copyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow dr = getSelectedRow();
            string name = dr["name"].ToString();
            Clipboard.SetText(name);

        }

        private void newIncExpEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow dr = getSelectedRow();
            common.showForm(new Income_Exp_Trans(dr));
        }
    }
}
