namespace Madrasah_Management_System
{
    partial class Income_Exp_Trans
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
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lbl_rcvd_from = new System.Windows.Forms.Label();
            this.dp_rcvd_dt = new System.Windows.Forms.DateTimePicker();
            this.lbl_rcvd_dt = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_heads = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_srch_student = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.lbl_rcvd_from);
            this.groupBox1.Controls.Add(this.dp_rcvd_dt);
            this.groupBox1.Controls.Add(this.lbl_rcvd_dt);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 128);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inc/Exp Details";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(98, 27);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(234, 20);
            this.txt_desc.TabIndex = 14;
            // 
            // lbl_rcvd_from
            // 
            this.lbl_rcvd_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rcvd_from.Location = new System.Drawing.Point(5, 31);
            this.lbl_rcvd_from.Name = "lbl_rcvd_from";
            this.lbl_rcvd_from.Size = new System.Drawing.Size(83, 16);
            this.lbl_rcvd_from.TabIndex = 13;
            this.lbl_rcvd_from.Text = "Recvd. From";
            this.lbl_rcvd_from.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dp_rcvd_dt
            // 
            this.dp_rcvd_dt.Location = new System.Drawing.Point(98, 56);
            this.dp_rcvd_dt.Name = "dp_rcvd_dt";
            this.dp_rcvd_dt.Size = new System.Drawing.Size(234, 20);
            this.dp_rcvd_dt.TabIndex = 12;
            // 
            // lbl_rcvd_dt
            // 
            this.lbl_rcvd_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rcvd_dt.Location = new System.Drawing.Point(12, 58);
            this.lbl_rcvd_dt.Name = "lbl_rcvd_dt";
            this.lbl_rcvd_dt.Size = new System.Drawing.Size(76, 16);
            this.lbl_rcvd_dt.TabIndex = 11;
            this.lbl_rcvd_dt.Text = "Recvd. On";
            this.lbl_rcvd_dt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(98, 86);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(234, 20);
            this.txt_amount.TabIndex = 10;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForNumbers);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_heads);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmb_type);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 101);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inc/Exp Type";
            // 
            // cmb_heads
            // 
            this.cmb_heads.DisplayMember = "name";
            this.cmb_heads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_heads.FormattingEnabled = true;
            this.cmb_heads.Location = new System.Drawing.Point(98, 61);
            this.cmb_heads.Name = "cmb_heads";
            this.cmb_heads.Size = new System.Drawing.Size(234, 21);
            this.cmb_heads.TabIndex = 14;
            this.cmb_heads.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Inc/Exp Head";
            // 
            // cmb_type
            // 
            this.cmb_type.DisplayMember = "name";
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmb_type.Location = new System.Drawing.Point(98, 24);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(234, 21);
            this.cmb_type.TabIndex = 12;
            this.cmb_type.ValueMember = "id";
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(150, 309);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_srch_student
            // 
            this.btn_srch_student.Location = new System.Drawing.Point(25, 12);
            this.btn_srch_student.Name = "btn_srch_student";
            this.btn_srch_student.Size = new System.Drawing.Size(363, 23);
            this.btn_srch_student.TabIndex = 17;
            this.btn_srch_student.Text = "Search Student";
            this.btn_srch_student.UseVisualStyleBackColor = true;
            this.btn_srch_student.Click += new System.EventHandler(this.btn_srch_student_Click);
            // 
            // Income_Exp_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 350);
            this.Controls.Add(this.btn_srch_student);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Income_Exp_Trans";
            this.Text = "New Income/Expense";
            this.Load += new System.EventHandler(this.Income_Exp_Trans_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label lbl_rcvd_from;
        private System.Windows.Forms.DateTimePicker dp_rcvd_dt;
        private System.Windows.Forms.Label lbl_rcvd_dt;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_heads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_srch_student;
    }
}