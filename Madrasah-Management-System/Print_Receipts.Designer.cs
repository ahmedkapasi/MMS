namespace Madrasah_Management_System
{
    partial class Print_Receipts
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rcpt_no = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_rcpt_no);
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.cmb_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Receipt No.";
            // 
            // txt_rcpt_no
            // 
            this.txt_rcpt_no.Location = new System.Drawing.Point(135, 59);
            this.txt_rcpt_no.Name = "txt_rcpt_no";
            this.txt_rcpt_no.Size = new System.Drawing.Size(167, 20);
            this.txt_rcpt_no.TabIndex = 2;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(135, 99);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // cmb_type
            // 
            this.cmb_type.DisplayMember = "name";
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Fees",
            "Rent",
            "Inc/Exp"});
            this.cmb_type.Location = new System.Drawing.Point(135, 31);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(167, 21);
            this.cmb_type.TabIndex = 1;
            this.cmb_type.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Receipt Type";
            // 
            // Print_Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 162);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Print_Receipts";
            this.Text = "Print Receipts";
            this.Load += new System.EventHandler(this.Print_Receipts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rcpt_no;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label1;
    }
}