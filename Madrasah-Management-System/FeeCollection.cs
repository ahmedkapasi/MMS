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
        public FeeCollection(string studentID)
        {
            InitializeComponent();
            try
            {
                txt_stu_name.Text = studentID;       
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
            objForm.MdiParent = this.MdiParent;
            objForm.Show();
            this.Close();
        }

        private void FeeCollection_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
               
        }
    }
}