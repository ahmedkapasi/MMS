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
        DataTable dt;
        public ExpenseMaster()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ExpenseMaster_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            
            dt.Columns.Add("Name");
            dt.Columns.Add("Type");
            //dt.Rows.Add(dt.NewRow());
            dataGridView1.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Name"] = textBox1.Text;
            dr["Type"] = comboBox1.Text;
            dt.Rows.Add(dr);
        }
    }
}
