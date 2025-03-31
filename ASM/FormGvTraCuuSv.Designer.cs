namespace ASM
{
    partial class FormGvTraCuuSv
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
            this.tabTraCuu = new System.Windows.Forms.TabControl();
            this.tabThongTinSinhVien = new System.Windows.Forms.TabPage();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbIDLop = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.tabBangDiem = new System.Windows.Forms.TabPage();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lbMaSinhVien = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tabTraCuu.SuspendLayout();
            this.tabThongTinSinhVien.SuspendLayout();
            this.tabBangDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTraCuu
            // 
            this.tabTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTraCuu.Controls.Add(this.tabThongTinSinhVien);
            this.tabTraCuu.Controls.Add(this.tabBangDiem);
            this.tabTraCuu.Location = new System.Drawing.Point(3, 60);
            this.tabTraCuu.Name = "tabTraCuu";
            this.tabTraCuu.SelectedIndex = 0;
            this.tabTraCuu.Size = new System.Drawing.Size(795, 372);
            this.tabTraCuu.TabIndex = 14;
            // 
            // tabThongTinSinhVien
            // 
            this.tabThongTinSinhVien.Controls.Add(this.lbGioiTinh);
            this.tabThongTinSinhVien.Controls.Add(this.lbEmail);
            this.tabThongTinSinhVien.Controls.Add(this.lbSDT);
            this.tabThongTinSinhVien.Controls.Add(this.lbHoTen);
            this.tabThongTinSinhVien.Controls.Add(this.lbIDLop);
            this.tabThongTinSinhVien.Controls.Add(this.lbDiaChi);
            this.tabThongTinSinhVien.Location = new System.Drawing.Point(4, 22);
            this.tabThongTinSinhVien.Name = "tabThongTinSinhVien";
            this.tabThongTinSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongTinSinhVien.Size = new System.Drawing.Size(787, 346);
            this.tabThongTinSinhVien.TabIndex = 0;
            this.tabThongTinSinhVien.Text = "Thông tin sinh viên";
            this.tabThongTinSinhVien.UseVisualStyleBackColor = true;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(36, 158);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lbGioiTinh.TabIndex = 7;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(36, 51);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(36, 121);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(70, 13);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(36, 19);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(43, 13);
            this.lbHoTen.TabIndex = 3;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // lbIDLop
            // 
            this.lbIDLop.AutoSize = true;
            this.lbIDLop.Location = new System.Drawing.Point(36, 92);
            this.lbIDLop.Name = "lbIDLop";
            this.lbIDLop.Size = new System.Drawing.Size(35, 13);
            this.lbIDLop.TabIndex = 5;
            this.lbIDLop.Text = "ID lớp";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(36, 195);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lbDiaChi.TabIndex = 8;
            this.lbDiaChi.Text = "Địa chỉ ";
            // 
            // tabBangDiem
            // 
            this.tabBangDiem.Controls.Add(this.dgvDiem);
            this.tabBangDiem.Location = new System.Drawing.Point(4, 22);
            this.tabBangDiem.Name = "tabBangDiem";
            this.tabBangDiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabBangDiem.Size = new System.Drawing.Size(787, 346);
            this.tabBangDiem.TabIndex = 1;
            this.tabBangDiem.Text = "Bảng điểm";
            this.tabBangDiem.UseVisualStyleBackColor = true;
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(4, 3);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(783, 343);
            this.dgvDiem.TabIndex = 9;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(149, 21);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimkiem.TabIndex = 13;
            // 
            // lbMaSinhVien
            // 
            this.lbMaSinhVien.AutoSize = true;
            this.lbMaSinhVien.Location = new System.Drawing.Point(53, 21);
            this.lbMaSinhVien.Name = "lbMaSinhVien";
            this.lbMaSinhVien.Size = new System.Drawing.Size(67, 13);
            this.lbMaSinhVien.TabIndex = 12;
            this.lbMaSinhVien.Text = "Mã sinh viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(296, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FormGvTraCuuSv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabTraCuu);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.lbMaSinhVien);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "FormGvTraCuuSv";
            this.Text = "FormGvTraCuuSv";
            this.tabTraCuu.ResumeLayout(false);
            this.tabThongTinSinhVien.ResumeLayout(false);
            this.tabThongTinSinhVien.PerformLayout();
            this.tabBangDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTraCuu;
        private System.Windows.Forms.TabPage tabThongTinSinhVien;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbIDLop;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TabPage tabBangDiem;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lbMaSinhVien;
        private System.Windows.Forms.Button btnTimKiem;
    }
}