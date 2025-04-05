namespace ASM
{
    partial class FormITQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormITQuanLyTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoU = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.cbTk = new System.Windows.Forms.ComboBox();
            this.btnHis = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvDataTk = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtMaTk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCapTaiKhoan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbLocDuLieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(386, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản Lý Tài Khoản CBDT";
            // 
            // btnLoU
            // 
            this.btnLoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoU.Location = new System.Drawing.Point(886, 403);
            this.btnLoU.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoU.Name = "btnLoU";
            this.btnLoU.Size = new System.Drawing.Size(205, 60);
            this.btnLoU.TabIndex = 28;
            this.btnLoU.Text = "Khóa / Mở Khóa ";
            this.btnLoU.UseVisualStyleBackColor = true;
            this.btnLoU.Click += new System.EventHandler(this.btnLoU_Click);
            // 
            // txtTk
            // 
            this.txtTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTk.Location = new System.Drawing.Point(717, 158);
            this.txtTk.Margin = new System.Windows.Forms.Padding(2);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(284, 26);
            this.txtTk.TabIndex = 19;
            // 
            // txtMk
            // 
            this.txtMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.Location = new System.Drawing.Point(717, 197);
            this.txtMk.Margin = new System.Windows.Forms.Padding(2);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(284, 26);
            this.txtMk.TabIndex = 18;
            // 
            // cbTk
            // 
            this.cbTk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTk.FormattingEnabled = true;
            this.cbTk.Location = new System.Drawing.Point(717, 235);
            this.cbTk.Margin = new System.Windows.Forms.Padding(2);
            this.cbTk.Name = "cbTk";
            this.cbTk.Size = new System.Drawing.Size(284, 28);
            this.cbTk.TabIndex = 32;
            // 
            // btnHis
            // 
            this.btnHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHis.Image = global::ASM.Properties.Resources.Kính_Lúp1;
            this.btnHis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHis.Location = new System.Drawing.Point(886, 320);
            this.btnHis.Margin = new System.Windows.Forms.Padding(2);
            this.btnHis.Name = "btnHis";
            this.btnHis.Size = new System.Drawing.Size(205, 63);
            this.btnHis.TabIndex = 28;
            this.btnHis.Text = "Lịch Sử Đăng Nhập";
            this.btnHis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHis.UseVisualStyleBackColor = true;
            this.btnHis.Click += new System.EventHandler(this.btnHis_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(135, 492);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 78);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::ASM.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(758, 492);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 79);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvDataTk
            // 
            this.dgvDataTk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTk.Location = new System.Drawing.Point(135, 305);
            this.dgvDataTk.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataTk.Name = "dgvDataTk";
            this.dgvDataTk.RowHeadersWidth = 51;
            this.dgvDataTk.RowTemplate.Height = 24;
            this.dgvDataTk.Size = new System.Drawing.Size(728, 183);
            this.dgvDataTk.TabIndex = 17;
            this.dgvDataTk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatatK_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::ASM.Properties.Resources.butchi1;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(446, 492);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 79);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangthai.Location = new System.Drawing.Point(272, 377);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(220, 23);
            this.txtTrangthai.TabIndex = 18;
            this.txtTrangthai.Visible = false;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(223, 232);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(244, 28);
            this.cbRole.TabIndex = 30;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // txtMaTk
            // 
            this.txtMaTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTk.Location = new System.Drawing.Point(223, 197);
            this.txtMaTk.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTk.Name = "txtMaTk";
            this.txtMaTk.Size = new System.Drawing.Size(244, 26);
            this.txtMaTk.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Danh sách tài khoản";
            // 
            // lbCapTaiKhoan
            // 
            this.lbCapTaiKhoan.AutoSize = true;
            this.lbCapTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapTaiKhoan.Location = new System.Drawing.Point(554, 238);
            this.lbCapTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCapTaiKhoan.Name = "lbCapTaiKhoan";
            this.lbCapTaiKhoan.Size = new System.Drawing.Size(159, 20);
            this.lbCapTaiKhoan.TabIndex = 37;
            this.lbCapTaiKhoan.Text = "Chưa có tài khoản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Role:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(625, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Mật khẩu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(621, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Tài khoản:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(156, 200);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "MaTk:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ASM.Properties.Resources._2021_PTCD_01;
            this.pictureBox5.Location = new System.Drawing.Point(971, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(168, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ASM.Properties.Resources._2020_FPTPolytechic;
            this.pictureBox4.Location = new System.Drawing.Point(19, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // cbLocDuLieu
            // 
            this.cbLocDuLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocDuLieu.FormattingEnabled = true;
            this.cbLocDuLieu.Location = new System.Drawing.Point(223, 158);
            this.cbLocDuLieu.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocDuLieu.Name = "cbLocDuLieu";
            this.cbLocDuLieu.Size = new System.Drawing.Size(244, 28);
            this.cbLocDuLieu.TabIndex = 30;
            this.cbLocDuLieu.SelectedIndexChanged += new System.EventHandler(this.cbLocDuLieu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Lọc dữ liệu:";
            // 
            // FormITQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 626);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbCapTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbTk);
            this.Controls.Add(this.cbLocDuLieu);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.btnLoU);
            this.Controls.Add(this.btnHis);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtMaTk);
            this.Controls.Add(this.dgvDataTk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrangthai);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormITQuanLyTaiKhoan";
            this.Text = "FormAdminQuanLyTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoU;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.ComboBox cbTk;
        private System.Windows.Forms.Button btnHis;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvDataTk;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtMaTk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCapTaiKhoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cbLocDuLieu;
        private System.Windows.Forms.Label label2;
    }
}