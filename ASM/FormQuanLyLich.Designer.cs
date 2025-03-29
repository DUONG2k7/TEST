namespace ASM
{
    partial class FormQuanLyLich
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
            this.dgvLichHoc = new System.Windows.Forms.DataGridView();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbMonhoc = new System.Windows.Forms.ComboBox();
            this.cbGvMonhoc = new System.Windows.Forms.ComboBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.cbCahoc = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbNgayhoc = new System.Windows.Forms.RadioButton();
            this.rdbNgaythi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuoihoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHoc.Location = new System.Drawing.Point(95, 265);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.Size = new System.Drawing.Size(814, 243);
            this.dgvLichHoc.TabIndex = 0;
            this.dgvLichHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichHoc_CellClick);
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(186, 42);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 21);
            this.cbLop.TabIndex = 1;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // cbMonhoc
            // 
            this.cbMonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonhoc.FormattingEnabled = true;
            this.cbMonhoc.Location = new System.Drawing.Point(432, 42);
            this.cbMonhoc.Name = "cbMonhoc";
            this.cbMonhoc.Size = new System.Drawing.Size(145, 21);
            this.cbMonhoc.TabIndex = 1;
            this.cbMonhoc.SelectedIndexChanged += new System.EventHandler(this.cbMonhoc_SelectedIndexChanged);
            // 
            // cbGvMonhoc
            // 
            this.cbGvMonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGvMonhoc.FormattingEnabled = true;
            this.cbGvMonhoc.Location = new System.Drawing.Point(432, 93);
            this.cbGvMonhoc.Name = "cbGvMonhoc";
            this.cbGvMonhoc.Size = new System.Drawing.Size(145, 21);
            this.cbGvMonhoc.TabIndex = 1;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(432, 141);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(145, 20);
            this.dtpNgay.TabIndex = 2;
            // 
            // cbCahoc
            // 
            this.cbCahoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCahoc.FormattingEnabled = true;
            this.cbCahoc.Location = new System.Drawing.Point(186, 140);
            this.cbCahoc.Name = "cbCahoc";
            this.cbCahoc.Size = new System.Drawing.Size(121, 21);
            this.cbCahoc.TabIndex = 1;
            this.cbCahoc.SelectedIndexChanged += new System.EventHandler(this.cbCahoc_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(674, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(429, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 41);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(183, 202);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(131, 41);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "GV bộ môn:";
            // 
            // rdbNgayhoc
            // 
            this.rdbNgayhoc.AutoSize = true;
            this.rdbNgayhoc.Location = new System.Drawing.Point(664, 141);
            this.rdbNgayhoc.Name = "rdbNgayhoc";
            this.rdbNgayhoc.Size = new System.Drawing.Size(71, 17);
            this.rdbNgayhoc.TabIndex = 6;
            this.rdbNgayhoc.TabStop = true;
            this.rdbNgayhoc.Text = "Ngày học";
            this.rdbNgayhoc.UseVisualStyleBackColor = true;
            // 
            // rdbNgaythi
            // 
            this.rdbNgaythi.AutoSize = true;
            this.rdbNgaythi.Location = new System.Drawing.Point(795, 141);
            this.rdbNgaythi.Name = "rdbNgaythi";
            this.rdbNgaythi.Size = new System.Drawing.Size(64, 17);
            this.rdbNgaythi.TabIndex = 6;
            this.rdbNgaythi.TabStop = true;
            this.rdbNgaythi.Text = "Ngày thi";
            this.rdbNgaythi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Buổi:";
            // 
            // txtBuoihoc
            // 
            this.txtBuoihoc.Location = new System.Drawing.Point(186, 90);
            this.txtBuoihoc.Name = "txtBuoihoc";
            this.txtBuoihoc.ReadOnly = true;
            this.txtBuoihoc.Size = new System.Drawing.Size(121, 20);
            this.txtBuoihoc.TabIndex = 7;
            this.txtBuoihoc.TextChanged += new System.EventHandler(this.txtBuoihoc_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày:";
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.CustomFormat = "HH:mm tt";
            this.dtpGioBatDau.Enabled = false;
            this.dtpGioBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioBatDau.Location = new System.Drawing.Point(743, 43);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(166, 23);
            this.dtpGioBatDau.TabIndex = 8;
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.CustomFormat = "HH:mm tt";
            this.dtpGioKetThuc.Enabled = false;
            this.dtpGioKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(743, 87);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(166, 23);
            this.dtpGioKetThuc.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giờ bắt đầu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Giờ bắt đầu:";
            // 
            // FormLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 561);
            this.Controls.Add(this.dtpGioKetThuc);
            this.Controls.Add(this.dtpGioBatDau);
            this.Controls.Add(this.txtBuoihoc);
            this.Controls.Add(this.rdbNgaythi);
            this.Controls.Add(this.rdbNgayhoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.cbGvMonhoc);
            this.Controls.Add(this.cbMonhoc);
            this.Controls.Add(this.cbCahoc);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.dgvLichHoc);
            this.Name = "FormLich";
            this.Text = "FormLich";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichHoc;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbMonhoc;
        private System.Windows.Forms.ComboBox cbGvMonhoc;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cbCahoc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbNgayhoc;
        private System.Windows.Forms.RadioButton rdbNgaythi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuoihoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}