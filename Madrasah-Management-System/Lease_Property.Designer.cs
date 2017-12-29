namespace Madrasah_Management_System
{
    partial class Lease_Property
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dp_to_month = new System.Windows.Forms.DateTimePicker();
            this.dp_from_month = new System.Windows.Forms.DateTimePicker();
            this.cmb_properties = new System.Windows.Forms.ComboBox();
            this.cmb_tenants = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_lease_dtls = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lease_dtls)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_rent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dp_to_month);
            this.groupBox1.Controls.Add(this.dp_from_month);
            this.groupBox1.Controls.Add(this.cmb_properties);
            this.groupBox1.Controls.Add(this.cmb_tenants);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lease Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Monthly Rent";
            // 
            // txt_rent
            // 
            this.txt_rent.Location = new System.Drawing.Point(94, 101);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.Size = new System.Drawing.Size(321, 20);
            this.txt_rent.TabIndex = 5;
            this.txt_rent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForNumbers);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lease To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lease From";
            // 
            // dp_to_month
            // 
            this.dp_to_month.Location = new System.Drawing.Point(296, 76);
            this.dp_to_month.Name = "dp_to_month";
            this.dp_to_month.Size = new System.Drawing.Size(119, 20);
            this.dp_to_month.TabIndex = 4;
            // 
            // dp_from_month
            // 
            this.dp_from_month.Location = new System.Drawing.Point(94, 76);
            this.dp_from_month.Name = "dp_from_month";
            this.dp_from_month.Size = new System.Drawing.Size(119, 20);
            this.dp_from_month.TabIndex = 3;
            // 
            // cmb_properties
            // 
            this.cmb_properties.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.cmb_properties.DisplayMember = "name";
            this.cmb_properties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_properties.FormattingEnabled = true;
            this.cmb_properties.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_properties.Location = new System.Drawing.Point(94, 19);
            this.cmb_properties.Name = "cmb_properties";
            this.cmb_properties.Size = new System.Drawing.Size(321, 21);
            this.cmb_properties.TabIndex = 1;
            this.cmb_properties.ValueMember = "id";
            // 
            // cmb_tenants
            // 
            this.cmb_tenants.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.cmb_tenants.DisplayMember = "name";
            this.cmb_tenants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tenants.FormattingEnabled = true;
            this.cmb_tenants.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_tenants.Location = new System.Drawing.Point(94, 46);
            this.cmb_tenants.Name = "cmb_tenants";
            this.cmb_tenants.Size = new System.Drawing.Size(321, 21);
            this.cmb_tenants.TabIndex = 2;
            this.cmb_tenants.ValueMember = "id";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(194, 137);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 24);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tenant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "stu_name";
            // 
            // dg_lease_dtls
            // 
            this.dg_lease_dtls.AllowUserToAddRows = false;
            this.dg_lease_dtls.AllowUserToDeleteRows = false;
            this.dg_lease_dtls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lease_dtls.Location = new System.Drawing.Point(12, 224);
            this.dg_lease_dtls.Name = "dg_lease_dtls";
            this.dg_lease_dtls.Size = new System.Drawing.Size(502, 178);
            this.dg_lease_dtls.TabIndex = 5;
            // 
            // Lease_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 436);
            this.Controls.Add(this.dg_lease_dtls);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lease_Property";
            this.Text = "Lease stu_name";
            this.Load += new System.EventHandler(this.Lease_Property_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lease_dtls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_properties;
        private System.Windows.Forms.ComboBox cmb_tenants;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dp_from_month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dp_to_month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_rent;
        private System.Windows.Forms.DataGridView dg_lease_dtls;

    }
}