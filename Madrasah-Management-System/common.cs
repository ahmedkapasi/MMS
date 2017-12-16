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
        public const string SUCCESS_MSG = "Sucess";
        public static bool isLoggedIn { get; set; }
        public static DataSet getDataSet(string cmd)
        {
            DataSet ds = new DataSet("dataset");
            try
            {
                string connstr = ConfigurationSettings.AppSettings["Connection_String"];
                SqlDataAdapter sql_da = new SqlDataAdapter(cmd, connstr);
                sql_da.Fill(ds);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public static string updateTable(string cmd)
        {
            SqlConnection sqlconn =null;
            SqlTransaction st =null;
            SqlDataAdapter sql_da = null;
            SqlCommand sql_cmd = null;
            try
            {

                string connstr = ConfigurationSettings.AppSettings["Connection_String"];
                sqlconn = new SqlConnection(connstr);
                sqlconn.Open();
                st = sqlconn.BeginTransaction();
                sql_cmd = new SqlCommand(cmd);
                sql_cmd.Transaction = st;
                sql_cmd.Connection = sqlconn;
                sql_cmd.ExecuteNonQuery();
                st.Commit();
                return SUCCESS_MSG;
            }
            catch (Exception ex)
            {
                if (sqlconn != null && sqlconn.State == ConnectionState.Open)
                {
                    st.Rollback();
                    sqlconn.Close();
                }
                return ex.Message;
            }
            finally {
                if (sqlconn != null && sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
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
