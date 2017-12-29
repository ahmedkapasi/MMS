namespace Madrasah_Management_System
{
    partial class RentCollection
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_properties = new System.Windows.Forms.ComboBox();
            this.txt_tent_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_pay_method = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dp_recvd_on = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tot_rent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dp_to = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mnth_rent = new System.Windows.Forms.TextBox();
            this.dp_from = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_rent_dtls = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rent_dtls)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_properties);
            this.groupBox2.Controls.Add(this.txt_tent_name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 132);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "stu_name Details";
            // 
            // cmb_properties
            // 
            this.cmb_properties.DisplayMember = "name";
            this.cmb_properties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_properties.FormattingEnabled = true;
            this.cmb_properties.Location = new System.Drawing.Point(100, 34);
            this.cmb_properties.Name = "cmb_properties";
            this.cmb_properties.Size = new System.Drawing.Size(319, 21);
            this.cmb_properties.TabIndex = 1;
            this.cmb_properties.ValueMember = "id";
            this.cmb_properties.SelectedIndexChanged += new System.EventHandler(this.cmb_properties_SelectedIndexChanged);
            // 
            // txt_tent_name
            // 
            this.txt_tent_name.Enabled = false;
            this.txt_tent_name.Location = new System.Drawing.Point(100, 75);
            this.txt_tent_name.Name = "txt_tent_name";
            this.txt_tent_name.Size = new System.Drawing.Size(321, 20);
            this.txt_tent_name.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tenant Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "stu_name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_pay_method);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dp_recvd_on);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_tot_rent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dp_to);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_mnth_rent);
            this.groupBox1.Controls.Add(this.dp_from);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 116);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent Details";
            // 
            // cmb_pay_method
            // 
            this.cmb_pay_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pay_method.FormattingEnabled = true;
            this.cmb_pay_method.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.cmb_pay_method.Location = new System.Drawing.Point(299, 49);
            this.cmb_pay_method.Name = "cmb_pay_method";
            this.cmb_pay_method.Size = new System.Drawing.Size(122, 21);
            this.cmb_pay_method.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Pay Method";
            // 
            // dp_recvd_on
            // 
            this.dp_recvd_on.Location = new System.Drawing.Point(100, 48);
            this.dp_recvd_on.Name = "dp_recvd_on";
            this.dp_recvd_on.Size = new System.Drawing.Size(120, 20);
            this.dp_recvd_on.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Recvd. On";
            // 
            // txt_tot_rent
            // 
            this.txt_tot_rent.Enabled = false;
            this.txt_tot_rent.Location = new System.Drawing.Point(301, 77);
            this.txt_tot_rent.Name = "txt_tot_rent";
            this.txt_tot_rent.Size = new System.Drawing.Size(120, 20);
            this.txt_tot_rent.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Rent";
            // 
            // dp_to
            // 
            this.dp_to.Location = new System.Drawing.Point(299, 21);
            this.dp_to.Name = "dp_to";
            this.dp_to.Size = new System.Drawing.Size(122, 20);
            this.dp_to.TabIndex = 3;
            this.dp_to.ValueChanged += new System.EventHandler(this.dp_to_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monthly Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rent To";
            // 
            // txt_mnth_rent
            // 
            this.txt_mnth_rent.Enabled = false;
            this.txt_mnth_rent.Location = new System.Drawing.Point(102, 77);
            this.txt_mnth_rent.Name = "txt_mnth_rent";
            this.txt_mnth_rent.Size = new System.Drawing.Size(120, 20);
            this.txt_mnth_rent.TabIndex = 10;
            // 
            // dp_from
            // 
            this.dp_from.Location = new System.Drawing.Point(100, 21);
            this.dp_from.Name = "dp_from";
            this.dp_from.Size = new System.Drawing.Size(120, 20);
            this.dp_from.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rent From";
            // 
            // dg_rent_dtls
            // 
            this.dg_rent_dtls.AllowUserToAddRows = false;
            this.dg_rent_dtls.AllowUserToDeleteRows = false;
            this.dg_rent_dtls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rent_dtls.Location = new System.Drawing.Point(24, 336);
            this.dg_rent_dtls.Name = "dg_rent_dtls";
            this.dg_rent_dtls.ReadOnly = true;
            this.dg_rent_dtls.Size = new System.Drawing.Size(451, 150);
            this.dg_rent_dtls.TabIndex = 14;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(196, 305);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 24);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // RentCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 500);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dg_rent_dtls);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentCollection";
            this.Text = "Rent Collection";
            this.Load += new System.EventHandler(this.RentCollection_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rent_dtls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tent_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_properties;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dp_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dp_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mnth_rent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tot_rent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dg_rent_dtls;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dp_recvd_on;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_pay_method;
        private System.Windows.Forms.Label label9;
    }
}