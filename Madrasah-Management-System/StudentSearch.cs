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
                
                string cmd = @"SELECT STU.ID,STU.NAME,STU.MHR_NO,STU.ITS_ID,ST.name 'STANDARD'
                FROM STUDENTS STU,STANDARDS ST WHERE STU.STANDARD = ST.ID";
                student_ds = common.getDataSet(cmd);
                dataGridView1.DataSource = student_ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           string name = student_ds.Tables[0].Rows[e.RowIndex]["name"].ToString();
           Form fc = new FeeCollection(name);
           fc.MdiParent = this.MdiParent;
           fc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string name = textBox1.Text;
            //dt.DefaultView.RowFilter = "Name like '%" + name + "%'";
            //dataGridView1.DataSource = dt.DefaultView;
        }
    }
}
