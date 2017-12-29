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
    public partial class Student_Registration : Form
    {
        public Student_Registration()
        {
            InitializeComponent();
            fillStandardsCombo();
            cmb_gender.SelectedIndex = 0;
            cmb_standard.SelectedIndex = 0;

        }
        bool isEdit = false;
        DataRow dataRowEdited;
        public Student_Registration(DataRow dataRow)
        {
            InitializeComponent();
            isEdit = true;
            DataSet ds = common.getDataSet("SELECT * FROM STUDENTS WHERE ID=" + dataRow["ID"].ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                fillStandardsCombo();
                DataRow dr = dataRowEdited = ds.Tables[0].Rows[0];
                txt_name.Text = dr["name"].ToString();
                txt_its_id.Text = dr["its_id"].ToString();
                txt_phone_no.Text = dr["phone_no"].ToString();
                txt_dob_hijri.Text = dr["dob_hijri"].ToString();
                cmb_standard.SelectedValue = dr["standard"].ToString();
                cmb_gender.SelectedIndex = dr["gender"].ToString() == "Male" ? 0 : 1;
                dp_dob.Value = dr["dob"].ToString() == string.Empty ? DateTime.Now : DateTime.Parse(dr["dob"].ToString());
            }
        }
        private void fillStandardsCombo()
        {
            DataSet ds = common.getDataSet("SELECT * FROM STANDARDS ORDER BY SEQUENCE");
            cmb_standard.DataSource = ds.Tables[0];
            cmb_gender.SelectedIndex = 0;
        }
        private void Student_Registration_Load(object sender, EventArgs e)
        {

            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (validateData() == false)
            {
                return;
            }
            string name = txt_name.Text.Trim();
            string mhr_no = "(SELECT MAX(MHR_NO)+1 FROM STUDENTS)";
            string its_id = txt_its_id.Text.Trim();
            string phone = txt_phone_no.Text.Trim();
            string gender = cmb_gender.Text;
            string standard = cmb_standard.SelectedValue.ToString();
            string dob_hijri = txt_dob_hijri.Text.Trim();
            string dob = dp_dob.Value.ToString("dd-MMM-yyyy");
            string address = "";
            string dmlCmd;
            if (isEdit == true)
            {
                string studentID = dataRowEdited["ID"].ToString();
                dmlCmd = string.Format(@"UPDATE STUDENTS SET NAME='{0}',ITS_ID='{1}',DOB='{2}',DOB_HIJRI='{3}',GENDER='{4}',STANDARD='{5}',ADDRESS='{6}',PHONE_NO='{7}' 
                            WHERE ID = {8}", name, its_id, dob, dob_hijri, gender, standard, address, phone, studentID);
            }
            else
            {
                dmlCmd = string.Format(@"INSERT INTO STUDENTS(NAME,MHR_NO,ITS_ID,DOB,DOB_HIJRI,GENDER,STANDARD,ADDRESS,PHONE_NO) 
                            VALUES('{0}',{1},'{2}','{3}','{4}','{5}',{6},'{7}','{8}')", name, mhr_no, its_id, dob, dob_hijri, gender, standard, address, phone);
            }

            string retVal = common.updateTable(dmlCmd);
            if (retVal == common.SUCCESS_MSG)
            {
                MessageBox.Show("Record Saved Successfully.");
            }
            else
            {
                MessageBox.Show(retVal);
            }
        }

        private bool validateData()
        {
            if (txt_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Student's Name");
                return false;
            }
            if (txt_phone_no.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Student's Contact No.");
                return false;
            }
            return true;
        }
    }
}
