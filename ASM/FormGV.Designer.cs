namespace ASM
{
    partial class FormGV
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.UserNameThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.RoleThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMenuTraCuuSV = new System.Windows.Forms.Button();
            this.btnMenuGvXemLichDaySV = new System.Windows.Forms.Button();
            this.btnMenuQlyDanhSach = new System.Windows.Forms.Button();
            this.btnMenuQlyDiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
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
            this.ThongTinTaiKhoan.Size = new System.Drawing.Size(38, 24);
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
            this.groupBox2.Controls.Add(this.btnMenuTraCuuSV);
            this.groupBox2.Controls.Add(this.btnMenuGvXemLichDaySV);
            this.groupBox2.Controls.Add(this.btnMenuQlyDanhSach);
            this.groupBox2.Controls.Add(this.btnMenuQlyDiem);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(2, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(218, 363);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnMenuTraCuuSV
            // 
            this.btnMenuTraCuuSV.Location = new System.Drawing.Point(1, 267);
            this.btnMenuTraCuuSV.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuTraCuuSV.Name = "btnMenuTraCuuSV";
            this.btnMenuTraCuuSV.Size = new System.Drawing.Size(213, 41);
            this.btnMenuTraCuuSV.TabIndex = 2;
            this.btnMenuTraCuuSV.Text = "Tra cứu sinh viên";
            this.btnMenuTraCuuSV.UseVisualStyleBackColor = true;
            this.btnMenuTraCuuSV.Click += new System.EventHandler(this.btnMenuTraCuuSV_Click);
            // 
            // btnMenuGvXemLichDaySV
            // 
            this.btnMenuGvXemLichDaySV.Location = new System.Drawing.Point(1, 203);
            this.btnMenuGvXemLichDaySV.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuGvXemLichDaySV.Name = "btnMenuGvXemLichDaySV";
            this.btnMenuGvXemLichDaySV.Size = new System.Drawing.Size(213, 41);
            this.btnMenuGvXemLichDaySV.TabIndex = 2;
            this.btnMenuGvXemLichDaySV.Text = "Xem lịch dạy học";
            this.btnMenuGvXemLichDaySV.UseVisualStyleBackColor = true;
            this.btnMenuGvXemLichDaySV.Click += new System.EventHandler(this.btnMenuGvXemLichDaySV_Click);
            // 
            // btnMenuQlyDanhSach
            // 
            this.btnMenuQlyDanhSach.Location = new System.Drawing.Point(2, 145);
            this.btnMenuQlyDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyDanhSach.Name = "btnMenuQlyDanhSach";
            this.btnMenuQlyDanhSach.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyDanhSach.TabIndex = 2;
            this.btnMenuQlyDanhSach.Text = "Thống kê sinh viên";
            this.btnMenuQlyDanhSach.UseVisualStyleBackColor = true;
            this.btnMenuQlyDanhSach.Click += new System.EventHandler(this.btnMenuQlyDanhSach_Click);
            // 
            // btnMenuQlyDiem
            // 
            this.btnMenuQlyDiem.Location = new System.Drawing.Point(1, 88);
            this.btnMenuQlyDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyDiem.Name = "btnMenuQlyDiem";
            this.btnMenuQlyDiem.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyDiem.TabIndex = 2;
            this.btnMenuQlyDiem.Text = "Quản lý sv có điểm";
            this.btnMenuQlyDiem.UseVisualStyleBackColor = true;
            this.btnMenuQlyDiem.Click += new System.EventHandler(this.btnMenuQlyDiem_Click);
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
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabMain);
            this.tabPage.Location = new System.Drawing.Point(221, 50);
            this.tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1051, 530);
            this.tabPage.TabIndex = 7;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pictureBox1);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1043, 504);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblMarquee
            // 
            this.lblMarquee.AutoSize = true;
            this.lblMarquee.Location = new System.Drawing.Point(1243, 35);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(35, 13);
            this.lblMarquee.TabIndex = 0;
            this.lblMarquee.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FormGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 585);
            this.Controls.Add(this.lblMarquee);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabPage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGV";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMenuQlyDiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.ToolStripMenuItem ThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem UserNameThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem RoleThongTinTaiKhoan;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenuQlyDanhSach;
        private System.Windows.Forms.Button btnMenuGvXemLichDaySV;
        private System.Windows.Forms.Button btnMenuTraCuuSV;
    }
}