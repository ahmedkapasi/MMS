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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //menuStrip1.Enabled = false;
            //showForm(new login());
            
        }

            private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
            {
            
           
            }

            private void expenseMasterToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void incomeMasterToolStripMenuItem_Click(object sender, EventArgs e)
            {
            
            
            }

        private void feeReceiptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new StudentSearch());
            
        }

        private void expenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showForm(new StudentSearch());
            
        }
        void showForm(Form form) { 
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showForm(new Student_Registration());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            showForm(new ExpenseMaster());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            showForm(new FeeCollection());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }
    }
}
