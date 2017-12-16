using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace Madrasah_Management_System
{
    public class common
    {
        public static bool isLoggedIn { get; set; }
        public static DataSet getDataSet(string cmd) {
            DataSet ds = new DataSet("dataset");
            try
            {
                string connstr = ConfigurationSettings.AppSettings["Connection_String"];
                SqlDataAdapter sql_da = new SqlDataAdapter(cmd,connstr);
                sql_da.Fill(ds);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);   
            }
            return ds;
        }
        public static void showForm(Form form)
        {
            foreach (Form f in MainForm.ActiveForm.MdiChildren)
            {
                if (form.GetType() == f.GetType())
                {
                    f.Show();
                    return;
                }
            }
            form.MdiParent = MainForm.ActiveForm;
            form.Show();
        }
    }
}
