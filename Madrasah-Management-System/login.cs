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
    public partial class login : base_form
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "admin@1" && txt_user.Text.ToLower() == "admin")
            {
                common.isLoggedIn = true;
                this.MdiParent.MainMenuStrip.Enabled = true;
                this.Close();
            }
            else {
                MessageBox.Show("Invalid Credentials");
            }
            
        }
    }
}
