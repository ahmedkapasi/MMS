namespace Madrasah_Management_System
{
    partial class Rpt_Fees_Status
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
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.cmb_standard = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_defaulters = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_defaulters);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmb_year);
            this.groupBox2.Controls.Add(this.btn_show);
            this.groupBox2.Controls.Add(this.cmb_standard);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 160);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Filters";
            // 
            // cmb_year
            // 
            this.cmb_year.DisplayMember = "year";
            this.cmb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(110, 21);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(129, 21);
            this.cmb_year.TabIndex = 26;
            this.cmb_year.ValueMember = "year";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(87, 113);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(115, 23);
            this.btn_show.TabIndex = 25;
            this.btn_show.Text = "Show Report";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // cmb_standard
            // 
            this.cmb_standard.DisplayMember = "name";
            this.cmb_standard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_standard.FormattingEnabled = true;
            this.cmb_standard.Location = new System.Drawing.Point(110, 50);
            this.cmb_standard.Name = "cmb_standard";
            this.cmb_standard.Size = new System.Drawing.Size(129, 21);
            this.cmb_standard.TabIndex = 23;
            this.cmb_standard.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Standard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Academic Year";
            // 
            // chk_defaulters
            // 
            this.chk_defaulters.AutoSize = true;
            this.chk_defaulters.Location = new System.Drawing.Point(110, 83);
            this.chk_defaulters.Name = "chk_defaulters";
            this.chk_defaulters.Size = new System.Drawing.Size(15, 14);
            this.chk_defaulters.TabIndex = 28;
            this.chk_defaulters.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Only Defaulters";
            // 
            // Rpt_Fees_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 184);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rpt_Fees_Status";
            this.Text = "Fees Status";
            this.Load += new System.EventHandler(this.Rpt_Fees_Status_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ComboBox cmb_standard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.CheckBox chk_defaulters;
        private System.Windows.Forms.Label label1;
    }
}