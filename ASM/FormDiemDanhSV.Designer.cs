namespace ASM
{
    partial class FormDiemDanhSV
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDiemDanhAll = new System.Windows.Forms.Button();
            this.btnHuyDiemDanhAll = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.dtpNgayDiemDanh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnDiemDanhAll);
            this.groupBox1.Controls.Add(this.btnHuyDiemDanhAll);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.cboMonHoc);
            this.groupBox1.Controls.Add(this.cboLopHoc);
            this.groupBox1.Controls.Add(this.dtpNgayDiemDanh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm danh";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(637, 63);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu điểm danh";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnDiemDanhAll
            // 
            this.btnDiemDanhAll.Location = new System.Drawing.Point(328, 63);
            this.btnDiemDanhAll.Name = "btnDiemDanhAll";
            this.btnDiemDanhAll.Size = new System.Drawing.Size(97, 23);
            this.btnDiemDanhAll.TabIndex = 0;
            this.btnDiemDanhAll.Text = "Có mặt tất cả";
            this.btnDiemDanhAll.UseVisualStyleBackColor = true;
            // 
            // btnHuyDiemDanhAll
            // 
            this.btnHuyDiemDanhAll.Location = new System.Drawing.Point(431, 63);
            this.btnHuyDiemDanhAll.Name = "btnHuyDiemDanhAll";
            this.btnHuyDiemDanhAll.Size = new System.Drawing.Size(97, 23);
            this.btnHuyDiemDanhAll.TabIndex = 0;
            this.btnHuyDiemDanhAll.Text = "Vắng tất cả";
            this.btnHuyDiemDanhAll.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(534, 63);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(97, 23);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(115, 65);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(187, 21);
            this.cboMonHoc.TabIndex = 2;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(115, 29);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(187, 21);
            this.cboLopHoc.TabIndex = 1;
            this.cboLopHoc.SelectedIndexChanged += new System.EventHandler(this.cboLopHoc_SelectedIndexChanged);
            // 
            // dtpNgayDiemDanh
            // 
            this.dtpNgayDiemDanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDiemDanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDiemDanh.Location = new System.Drawing.Point(475, 29);
            this.dtpNgayDiemDanh.Name = "dtpNgayDiemDanh";
            this.dtpNgayDiemDanh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayDiemDanh.TabIndex = 3;
            this.dtpNgayDiemDanh.ValueChanged += new System.EventHandler(this.dtpNgayDiemDanh_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày điểm danh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp học:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐIỂM DANH SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSachSinhVien
            // 
            this.dgvDanhSachSinhVien.AllowUserToAddRows = false;
            this.dgvDanhSachSinhVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachSinhVien.Location = new System.Drawing.Point(0, 136);
            this.dgvDanhSachSinhVien.Name = "dgvDanhSachSinhVien";
            this.dgvDanhSachSinhVien.Size = new System.Drawing.Size(863, 341);
            this.dgvDanhSachSinhVien.TabIndex = 3;
            // 
            // FormDiemDanhSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachSinhVien);
            this.Name = "FormDiemDanhSV";
            this.Text = "FormDiemDanhSV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDiemDanhAll;
        private System.Windows.Forms.Button btnHuyDiemDanhAll;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.DateTimePicker dtpNgayDiemDanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachSinhVien;
    }
}