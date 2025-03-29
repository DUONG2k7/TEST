namespace ASM
{
    partial class FormADMIN
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
            this.btnMenuQlyGlobalBan = new System.Windows.Forms.Button();
            this.btnMenuQlyGV = new System.Windows.Forms.Button();
            this.btnMenuQlyCBDT = new System.Windows.Forms.Button();
            this.btnMenuQlyTaiKhoan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabpage = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMarquee = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabpage.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1420, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.groupBox2.Controls.Add(this.btnMenuQlyGlobalBan);
            this.groupBox2.Controls.Add(this.btnMenuQlyGV);
            this.groupBox2.Controls.Add(this.btnMenuQlyCBDT);
            this.groupBox2.Controls.Add(this.btnMenuQlyTaiKhoan);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(7, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(218, 363);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnMenuQlyGlobalBan
            // 
            this.btnMenuQlyGlobalBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlyGlobalBan.Location = new System.Drawing.Point(2, 262);
            this.btnMenuQlyGlobalBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyGlobalBan.Name = "btnMenuQlyGlobalBan";
            this.btnMenuQlyGlobalBan.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyGlobalBan.TabIndex = 2;
            this.btnMenuQlyGlobalBan.Text = "Quản lý tài khoản đã bị khóa";
            this.btnMenuQlyGlobalBan.UseVisualStyleBackColor = true;
            this.btnMenuQlyGlobalBan.Click += new System.EventHandler(this.btnMenuQlyGlobalBan_Click);
            // 
            // btnMenuQlyGV
            // 
            this.btnMenuQlyGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlyGV.Location = new System.Drawing.Point(2, 202);
            this.btnMenuQlyGV.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyGV.Name = "btnMenuQlyGV";
            this.btnMenuQlyGV.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyGV.TabIndex = 2;
            this.btnMenuQlyGV.Text = "Quản lý tài khoản GV";
            this.btnMenuQlyGV.UseVisualStyleBackColor = true;
            this.btnMenuQlyGV.Click += new System.EventHandler(this.btnMenuQlyGV_Click);
            // 
            // btnMenuQlyCBDT
            // 
            this.btnMenuQlyCBDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlyCBDT.Location = new System.Drawing.Point(2, 145);
            this.btnMenuQlyCBDT.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyCBDT.Name = "btnMenuQlyCBDT";
            this.btnMenuQlyCBDT.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyCBDT.TabIndex = 2;
            this.btnMenuQlyCBDT.Text = "Quản lý tài khoản CBDT";
            this.btnMenuQlyCBDT.UseVisualStyleBackColor = true;
            this.btnMenuQlyCBDT.Click += new System.EventHandler(this.btnMenuQlyCBDT_Click);
            // 
            // btnMenuQlyTaiKhoan
            // 
            this.btnMenuQlyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQlyTaiKhoan.Location = new System.Drawing.Point(2, 89);
            this.btnMenuQlyTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuQlyTaiKhoan.Name = "btnMenuQlyTaiKhoan";
            this.btnMenuQlyTaiKhoan.Size = new System.Drawing.Size(213, 41);
            this.btnMenuQlyTaiKhoan.TabIndex = 2;
            this.btnMenuQlyTaiKhoan.Text = "Quản lý tài khoản ADMIN";
            this.btnMenuQlyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnMenuQlyTaiKhoan.Click += new System.EventHandler(this.btnMenuQlyTaiKhoan_Click);
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
            // tabpage
            // 
            this.tabpage.Controls.Add(this.tabMain);
            this.tabpage.Location = new System.Drawing.Point(229, 47);
            this.tabpage.Margin = new System.Windows.Forms.Padding(2);
            this.tabpage.Name = "tabpage";
            this.tabpage.SelectedIndex = 0;
            this.tabpage.Size = new System.Drawing.Size(1180, 643);
            this.tabpage.TabIndex = 3;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pictureBox1);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1172, 617);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1130, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMarquee
            // 
            this.lblMarquee.AutoSize = true;
            this.lblMarquee.Location = new System.Drawing.Point(1385, 32);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(35, 13);
            this.lblMarquee.TabIndex = 4;
            this.lblMarquee.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 701);
            this.Controls.Add(this.lblMarquee);
            this.Controls.Add(this.tabpage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormADMIN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabpage.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMenuQlyTaiKhoan;
        private System.Windows.Forms.TabControl tabpage;
        private System.Windows.Forms.Button btnMenuQlyGV;
        private System.Windows.Forms.Button btnMenuQlyCBDT;
        private System.Windows.Forms.Button btnMenuQlyGlobalBan;
        private System.Windows.Forms.ToolStripMenuItem ThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem UserNameThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem RoleThongTinTaiKhoan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}