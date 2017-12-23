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
            this.cmb_tenants = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_properties = new System.Windows.Forms.ComboBox();
            this.dp_from_month = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_fees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dp_from_month);
            this.groupBox1.Controls.Add(this.cmb_properties);
            this.groupBox1.Controls.Add(this.cmb_tenants);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 206);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lease Details";
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
            this.cmb_tenants.Size = new System.Drawing.Size(231, 21);
            this.cmb_tenants.TabIndex = 2;
            this.cmb_tenants.ValueMember = "id";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(127, 173);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 24);
            this.btn_save.TabIndex = 4;
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
            this.label1.Text = "Property";
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
            this.cmb_properties.Size = new System.Drawing.Size(231, 21);
            this.cmb_properties.TabIndex = 21;
            this.cmb_properties.ValueMember = "id";
            // 
            // dp_from_month
            // 
            this.dp_from_month.Location = new System.Drawing.Point(94, 73);
            this.dp_from_month.Name = "dp_from_month";
            this.dp_from_month.Size = new System.Drawing.Size(231, 20);
            this.dp_from_month.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lease From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lease To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Monthly Rent";
            // 
            // txt_fees
            // 
            this.txt_fees.Location = new System.Drawing.Point(94, 125);
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.Size = new System.Drawing.Size(231, 20);
            this.txt_fees.TabIndex = 25;
            this.txt_fees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForNumbers);
            // 
            // Lease_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 316);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lease_Property";
            this.Text = "Lease Property";
            this.Load += new System.EventHandler(this.Lease_Property_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fees;

    }
}