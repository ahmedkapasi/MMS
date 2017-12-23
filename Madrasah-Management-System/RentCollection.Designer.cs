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
            this.dp_to = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dp_from = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rent_amt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(431, 132);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property Details";
            // 
            // cmb_properties
            // 
            this.cmb_properties.DisplayMember = "name";
            this.cmb_properties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_properties.Enabled = false;
            this.cmb_properties.FormattingEnabled = true;
            this.cmb_properties.Location = new System.Drawing.Point(100, 34);
            this.cmb_properties.Name = "cmb_properties";
            this.cmb_properties.Size = new System.Drawing.Size(304, 21);
            this.cmb_properties.TabIndex = 12;
            this.cmb_properties.ValueMember = "id";
            // 
            // txt_tent_name
            // 
            this.txt_tent_name.Enabled = false;
            this.txt_tent_name.Location = new System.Drawing.Point(100, 75);
            this.txt_tent_name.Name = "txt_tent_name";
            this.txt_tent_name.Size = new System.Drawing.Size(304, 20);
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
            this.label1.Text = "Property";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dp_to);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dp_from);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_rent_amt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 162);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent Details";
            // 
            // dp_to
            // 
            this.dp_to.Location = new System.Drawing.Point(282, 97);
            this.dp_to.Name = "dp_to";
            this.dp_to.Size = new System.Drawing.Size(122, 20);
            this.dp_to.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rent To";
            // 
            // dp_from
            // 
            this.dp_from.Location = new System.Drawing.Point(98, 95);
            this.dp_from.Name = "dp_from";
            this.dp_from.Size = new System.Drawing.Size(122, 20);
            this.dp_from.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rent From";
            // 
            // txt_rent_amt
            // 
            this.txt_rent_amt.Enabled = false;
            this.txt_rent_amt.Location = new System.Drawing.Point(100, 67);
            this.txt_rent_amt.Name = "txt_rent_amt";
            this.txt_rent_amt.Size = new System.Drawing.Size(304, 20);
            this.txt_rent_amt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monthly Rent";
            // 
            // RentCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "RentCollection";
            this.Text = "RentCollection";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_rent_amt;
        private System.Windows.Forms.Label label3;
    }
}