namespace ASM
{
    partial class FormCBDT
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
            this.components = new System.ComponentModel.Container();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.UserNameThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.RoleThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMenuQlyMonHoc = new System.Windows.Forms.Button();
            this.btnMenyQlyKyHoc = new System.Windows.Forms.Button();
            this.btnMenuQlyLichhoc = new System.Windows.Forms.Button();
            this.btnMenuQlyLop = new System.Windows.Forms.Button();
            this.btnMenuQlyGiangVien = new System.Windows.Forms.Button();
            this.btnMenuQlySV = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMarquee = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnMenuQlyPhanChiaViec = new System.Windows.Forms.Button();
            this.tabPage.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabMain);
            this.tabPage.Location = new System.Drawing.Point(222, 53);
            this.tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1057, 626);
            this.tabPage.TabIndex = 11;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pictureBox1);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1049, 600);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1007, 569);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.ThongTinTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // ThongTinTaiKhoan
            // 
            this.ThongTinTaiKhoan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ThongTinTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserNameThongTinTaiKhoan,
            this.RoleThongTinTaiKhoan});
            this.ThongTinTaiKhoan.Name = "ThongTinTaiKhoan";
            this.ThongTinTaiKhoan.Size = new System.Drawing.Size(31, 20);
            this.ThongTinTaiKhoan.Text = "Hi";
            // 
            // UserNameThongTinTaiKhoan
            // 
            this.UserNameThongTinTaiKhoan.Name = "UserNameThongTinTaiKhoan";
            this.UserNameThongTinTaiKhoan.Size = new System.Drawing.Size(129, 22);
            this.UserNameThongTinTaiKhoan.Text = "UserName";
            // 
            // RoleThongTinTaiKhoan
            // 
            this.RoleThongTinTaiKhoan.Name = "RoleThongTinTaiKhoan";
            this.RoleThongTinTaiKhoan.Size = new System.Drawing.Size(129, 22);
            this.RoleThongTinTaiKhoan.Text = "Role";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMenuQlyMonHoc);
            this.groupBox2.Controls.Add(this.btnMenyQlyKyHoc);
            this.groupBox2.Controls.Add(this.btnMenuQlyPhanChiaViec);
            this.groupBox2.Controls.Add(this.btnMenuQlyLichhoc);
            this.groupBox2.Controls.Add(this.btnMenuQlyLop);
            this.groupBox2.Controls.Add(this.btnMenuQlyGiangVien);
            this.groupBox2.Controls.Add(this.btnMenuQlySV);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(218, 626);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btnMenuQlyMonHoc
            // 
            this.btnMenuQlyMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlyMonHoc.Location = new System.Drawing.Point(2, 332);
            this.btnMenuQlyMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyMonHoc.Name = "btnMenuQlyMonHoc";
            this.btnMenuQlyMonHoc.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyMonHoc.TabIndex = 2;
            this.btnMenuQlyMonHoc.Text = "Quản lý môn học";
            this.btnMenuQlyMonHoc.UseVisualStyleBackColor = true;
            this.btnMenuQlyMonHoc.Click += new System.EventHandler(this.btnMenuQlyMonHoc_Click);
            // 
            // btnMenyQlyKyHoc
            // 
            this.btnMenyQlyKyHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenyQlyKyHoc.Location = new System.Drawing.Point(2, 268);
            this.btnMenyQlyKyHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenyQlyKyHoc.Name = "btnMenyQlyKyHoc";
            this.btnMenyQlyKyHoc.Size = new System.Drawing.Size(213, 41);
            this.btnMenyQlyKyHoc.TabIndex = 2;
            this.btnMenyQlyKyHoc.Text = "Quản lý kỳ học";
            this.btnMenyQlyKyHoc.UseVisualStyleBackColor = true;
            this.btnMenyQlyKyHoc.Click += new System.EventHandler(this.btnMenyQlyKyHoc_Click);
            // 
            // btnMenuQlyLichhoc
            // 
            this.btnMenuQlyLichhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlyLichhoc.Location = new System.Drawing.Point(2, 395);
            this.btnMenuQlyLichhoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyLichhoc.Name = "btnMenuQlyLichhoc";
            this.btnMenuQlyLichhoc.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyLichhoc.TabIndex = 2;
            this.btnMenuQlyLichhoc.Text = "Quản lý lịch học";
            this.btnMenuQlyLichhoc.UseVisualStyleBackColor = true;
            this.btnMenuQlyLichhoc.Click += new System.EventHandler(this.btnMenuQlyLichhoc_Click);
            // 
            // btnMenuQlyLop
            // 
            this.btnMenuQlyLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlyLop.Location = new System.Drawing.Point(2, 206);
            this.btnMenuQlyLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyLop.Name = "btnMenuQlyLop";
            this.btnMenuQlyLop.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyLop.TabIndex = 2;
            this.btnMenuQlyLop.Text = "Quản lý lớp";
            this.btnMenuQlyLop.UseVisualStyleBackColor = true;
            this.btnMenuQlyLop.Click += new System.EventHandler(this.btnMenuQlyLop_Click);
            // 
            // btnMenuQlyGiangVien
            // 
            this.btnMenuQlyGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlyGiangVien.Location = new System.Drawing.Point(2, 148);
            this.btnMenuQlyGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyGiangVien.Name = "btnMenuQlyGiangVien";
            this.btnMenuQlyGiangVien.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyGiangVien.TabIndex = 2;
            this.btnMenuQlyGiangVien.Text = "Quản lý giảng viên";
            this.btnMenuQlyGiangVien.UseVisualStyleBackColor = true;
            this.btnMenuQlyGiangVien.Click += new System.EventHandler(this.btnMenuQlyGiangVien_Click);
            // 
            // btnMenuQlySV
            // 
            this.btnMenuQlySV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlySV.Location = new System.Drawing.Point(2, 89);
            this.btnMenuQlySV.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlySV.Name = "btnMenuQlySV";
            this.btnMenuQlySV.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlySV.TabIndex = 2;
            this.btnMenuQlySV.Text = "Quản lý sinh viên";
            this.btnMenuQlySV.UseVisualStyleBackColor = true;
            this.btnMenuQlySV.Click += new System.EventHandler(this.btnMenuQlySV_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(2, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "MENU";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblMarquee
            // 
            this.lblMarquee.AutoSize = true;
            this.lblMarquee.Location = new System.Drawing.Point(1243, 34);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(35, 13);
            this.lblMarquee.TabIndex = 12;
            this.lblMarquee.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnMenuQlyPhanChiaViec
            // 
            this.btnMenuQlyPhanChiaViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlyPhanChiaViec.Location = new System.Drawing.Point(2, 461);
            this.btnMenuQlyPhanChiaViec.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyPhanChiaViec.Name = "btnMenuQlyPhanChiaViec";
            this.btnMenuQlyPhanChiaViec.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyPhanChiaViec.TabIndex = 2;
            this.btnMenuQlyPhanChiaViec.Text = "Quản lý công việc";
            this.btnMenuQlyPhanChiaViec.UseVisualStyleBackColor = true;
            this.btnMenuQlyPhanChiaViec.Click += new System.EventHandler(this.btnMenuQlyPhanChiaViec_Click);
            // 
            // FormCBDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 701);
            this.Controls.Add(this.lblMarquee);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCBDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCBDT";
            this.tabPage.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMenuQlyLop;
        private System.Windows.Forms.Button btnMenuQlyGiangVien;
        private System.Windows.Forms.Button btnMenuQlySV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem ThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem UserNameThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem RoleThongTinTaiKhoan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenuQlyLichhoc;
        private System.Windows.Forms.Button btnMenyQlyKyHoc;
        private System.Windows.Forms.Button btnMenuQlyMonHoc;
        private System.Windows.Forms.Button btnMenuQlyPhanChiaViec;
    }
}