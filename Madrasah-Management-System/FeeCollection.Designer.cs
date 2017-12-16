namespace Madrasah_Management_System
{
    partial class FeeCollection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_pay_method = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_comments = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_fees = new System.Windows.Forms.CheckBox();
            this.chk_inc_type = new System.Windows.Forms.CheckBox();
            this.cmb_inc_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.dp_for_month = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stu_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_its_id = new System.Windows.Forms.TextBox();
            this.txt_stu_std = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mhr_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_pay_method);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_comments);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chk_fees);
            this.groupBox1.Controls.Add(this.chk_inc_type);
            this.groupBox1.Controls.Add(this.cmb_inc_type);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_fees);
            this.groupBox1.Controls.Add(this.dp_for_month);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fees Details";
            // 
            // cmb_pay_method
            // 
            this.cmb_pay_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pay_method.FormattingEnabled = true;
            this.cmb_pay_method.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.cmb_pay_method.Location = new System.Drawing.Point(84, 110);
            this.cmb_pay_method.Name = "cmb_pay_method";
            this.cmb_pay_method.Size = new System.Drawing.Size(194, 21);
            this.cmb_pay_method.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pay Method";
            // 
            // txt_comments
            // 
            this.txt_comments.Location = new System.Drawing.Point(386, 74);
            this.txt_comments.Name = "txt_comments";
            this.txt_comments.Size = new System.Drawing.Size(236, 69);
            this.txt_comments.TabIndex = 14;
            this.txt_comments.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comments";
            // 
            // chk_fees
            // 
            this.chk_fees.AutoSize = true;
            this.chk_fees.Location = new System.Drawing.Point(220, 71);
            this.chk_fees.Name = "chk_fees";
            this.chk_fees.Size = new System.Drawing.Size(63, 17);
            this.chk_fees.TabIndex = 12;
            this.chk_fees.Text = "Change";
            this.chk_fees.UseVisualStyleBackColor = true;
            this.chk_fees.CheckedChanged += new System.EventHandler(this.chk_fees_CheckedChanged);
            // 
            // chk_inc_type
            // 
            this.chk_inc_type.AutoSize = true;
            this.chk_inc_type.Location = new System.Drawing.Point(559, 37);
            this.chk_inc_type.Name = "chk_inc_type";
            this.chk_inc_type.Size = new System.Drawing.Size(63, 17);
            this.chk_inc_type.TabIndex = 11;
            this.chk_inc_type.Text = "Change";
            this.chk_inc_type.UseVisualStyleBackColor = true;
            this.chk_inc_type.CheckedChanged += new System.EventHandler(this.chk_inc_type_CheckedChanged);
            // 
            // cmb_inc_type
            // 
            this.cmb_inc_type.DisplayMember = "name";
            this.cmb_inc_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_inc_type.Enabled = false;
            this.cmb_inc_type.FormattingEnabled = true;
            this.cmb_inc_type.Location = new System.Drawing.Point(386, 31);
            this.cmb_inc_type.Name = "cmb_inc_type";
            this.cmb_inc_type.Size = new System.Drawing.Size(161, 21);
            this.cmb_inc_type.TabIndex = 10;
            this.cmb_inc_type.ValueMember = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Income Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fees Amount";
            // 
            // txt_fees
            // 
            this.txt_fees.Enabled = false;
            this.txt_fees.Location = new System.Drawing.Point(84, 72);
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.Size = new System.Drawing.Size(125, 20);
            this.txt_fees.TabIndex = 6;
            // 
            // dp_for_month
            // 
            this.dp_for_month.Location = new System.Drawing.Point(84, 35);
            this.dp_for_month.Name = "dp_for_month";
            this.dp_for_month.Size = new System.Drawing.Size(194, 20);
            this.dp_for_month.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "For Month";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(278, 399);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Name";
            // 
            // txt_stu_name
            // 
            this.txt_stu_name.Enabled = false;
            this.txt_stu_name.Location = new System.Drawing.Point(100, 30);
            this.txt_stu_name.Name = "txt_stu_name";
            this.txt_stu_name.Size = new System.Drawing.Size(522, 20);
            this.txt_stu_name.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_its_id);
            this.groupBox2.Controls.Add(this.txt_stu_std);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_mhr_no);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_stu_name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(39, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 132);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "ITS ID";
            // 
            // txt_its_id
            // 
            this.txt_its_id.Enabled = false;
            this.txt_its_id.Location = new System.Drawing.Point(470, 72);
            this.txt_its_id.Name = "txt_its_id";
            this.txt_its_id.Size = new System.Drawing.Size(152, 20);
            this.txt_its_id.TabIndex = 10;
            // 
            // txt_stu_std
            // 
            this.txt_stu_std.Enabled = false;
            this.txt_stu_std.Location = new System.Drawing.Point(100, 72);
            this.txt_stu_std.Name = "txt_stu_std";
            this.txt_stu_std.Size = new System.Drawing.Size(71, 20);
            this.txt_stu_std.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Standard";
            // 
            // txt_mhr_no
            // 
            this.txt_mhr_no.Enabled = false;
            this.txt_mhr_no.Location = new System.Drawing.Point(252, 72);
            this.txt_mhr_no.Name = "txt_mhr_no";
            this.txt_mhr_no.Size = new System.Drawing.Size(152, 20);
            this.txt_mhr_no.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MHR No.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(641, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Search Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FeeCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 439);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeeCollection";
            this.Text = "Fee Collection";
            this.Load += new System.EventHandler(this.FeeCollection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fees;
        private System.Windows.Forms.DateTimePicker dp_for_month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stu_name;
        private System.Windows.Forms.TextBox txt_mhr_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_fees;
        private System.Windows.Forms.CheckBox chk_inc_type;
        private System.Windows.Forms.ComboBox cmb_inc_type;
        private System.Windows.Forms.TextBox txt_stu_std;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_comments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_pay_method;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_its_id;
    }
}