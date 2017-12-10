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
    public partial class StudentSearch : Form
    {
        DataTable dt = new DataTable();
        public StudentSearch()
        {
            InitializeComponent();
        }

        private void StudentSearch_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("RollNo");
            dt.Columns.Add("ITSID");

            DataRow dr = dt.NewRow();
            dr[0] = "Ahmed Kapasi";
            dr[1] = "1435";
            dr[2] = "30416842";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = "Murtaza Rampurawala";
            dr[1] = "1363";
            dr[2] = "30496213";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = "Shabbir jasdanwala";
            dr[1] = "1215";
            dr[2] = "306895";
            dt.Rows.Add(dr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text;
            dt.DefaultView.RowFilter = "Name like '%" + name + "%'";
            dataGridView1.DataSource = dt.DefaultView;
        }
    }
}
