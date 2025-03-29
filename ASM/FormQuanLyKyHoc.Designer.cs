namespace ASM
{
    partial class FormQuanLyKyHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyKyHoc));
            this.tcQlyKyHoc = new System.Windows.Forms.TabControl();
            this.tpTaoKyHoc = new System.Windows.Forms.TabPage();
            this.btnUseKyHoc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpNamKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNamBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtTenKy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDsKyHoc = new System.Windows.Forms.DataGridView();
            this.tpChiDinhMonHoc = new System.Windows.Forms.TabPage();
            this.btnLockOrUnlockMonHoc = new System.Windows.Forms.Button();
            this.dgvChiDinhMHtoKyhoc = new System.Windows.Forms.DataGridView();
            this.CheckColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSaveChiDinhMHtoKyhoc = new System.Windows.Forms.Button();
            this.btnUpdateSetMHtoKyHoc = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbChonKyHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDsKyHocMonHoc = new System.Windows.Forms.DataGridView();
            this.tcQlyKyHoc.SuspendLayout();
            this.tpTaoKyHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKyHoc)).BeginInit();
            this.tpChiDinhMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiDinhMHtoKyhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKyHocMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tcQlyKyHoc
            // 
            this.tcQlyKyHoc.Controls.Add(this.tpTaoKyHoc);
            this.tcQlyKyHoc.Controls.Add(this.tpChiDinhMonHoc);
            this.tcQlyKyHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQlyKyHoc.Location = new System.Drawing.Point(0, 0);
            this.tcQlyKyHoc.Name = "tcQlyKyHoc";
            this.tcQlyKyHoc.SelectedIndex = 0;
            this.tcQlyKyHoc.Size = new System.Drawing.Size(1033, 561);
            this.tcQlyKyHoc.TabIndex = 0;
            // 
            // tpTaoKyHoc
            // 
            this.tpTaoKyHoc.Controls.Add(this.btnUseKyHoc);
            this.tpTaoKyHoc.Controls.Add(this.btnSave);
            this.tpTaoKyHoc.Controls.Add(this.btnUpdate);
            this.tpTaoKyHoc.Controls.Add(this.btnAdd);
            this.tpTaoKyHoc.Controls.Add(this.dtpNamKetThuc);
            this.tpTaoKyHoc.Controls.Add(this.dtpNamBatDau);
            this.tpTaoKyHoc.Controls.Add(this.txtTenKy);
            this.tpTaoKyHoc.Controls.Add(this.label2);
            this.tpTaoKyHoc.Controls.Add(this.label4);
            this.tpTaoKyHoc.Controls.Add(this.label3);
            this.tpTaoKyHoc.Controls.Add(this.label1);
            this.tpTaoKyHoc.Controls.Add(this.dgvDsKyHoc);
            this.tpTaoKyHoc.Location = new System.Drawing.Point(4, 22);
            this.tpTaoKyHoc.Name = "tpTaoKyHoc";
            this.tpTaoKyHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaoKyHoc.Size = new System.Drawing.Size(1025, 535);
            this.tpTaoKyHoc.TabIndex = 0;
            this.tpTaoKyHoc.Text = "Tạo kỳ học";
            this.tpTaoKyHoc.UseVisualStyleBackColor = true;
            // 
            // btnUseKyHoc
            // 
            this.btnUseKyHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseKyHoc.Image = global::ASM.Properties.Resources.Kính_Lúp1;
            this.btnUseKyHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUseKyHoc.Location = new System.Drawing.Point(835, 449);
            this.btnUseKyHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnUseKyHoc.Name = "btnUseKyHoc";
            this.btnUseKyHoc.Size = new System.Drawing.Size(125, 79);
            this.btnUseKyHoc.TabIndex = 51;
            this.btnUseKyHoc.Text = "Sử dụng";
            this.btnUseKyHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUseKyHoc.UseVisualStyleBackColor = true;
            this.btnUseKyHoc.Click += new System.EventHandler(this.btnUseKyHoc_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::ASM.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(583, 449);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 79);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::ASM.Properties.Resources.butchi1;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(315, 449);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 79);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(74, 449);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 78);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpNamKetThuc
            // 
            this.dtpNamKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNamKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNamKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamKetThuc.Location = new System.Drawing.Point(401, 161);
            this.dtpNamKetThuc.Name = "dtpNamKetThuc";
            this.dtpNamKetThuc.Size = new System.Drawing.Size(227, 26);
            this.dtpNamKetThuc.TabIndex = 21;
            // 
            // dtpNamBatDau
            // 
            this.dtpNamBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNamBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNamBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamBatDau.Location = new System.Drawing.Point(401, 113);
            this.dtpNamBatDau.Name = "dtpNamBatDau";
            this.dtpNamBatDau.Size = new System.Drawing.Size(227, 26);
            this.dtpNamBatDau.TabIndex = 21;
            // 
            // txtTenKy
            // 
            this.txtTenKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKy.Location = new System.Drawing.Point(401, 66);
            this.txtTenKy.Name = "txtTenKy";
            this.txtTenKy.Size = new System.Drawing.Size(227, 26);
            this.txtTenKy.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(428, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tạo Kỳ Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Năm kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Năm bắt đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên kỳ:";
            // 
            // dgvDsKyHoc
            // 
            this.dgvDsKyHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsKyHoc.Location = new System.Drawing.Point(40, 204);
            this.dgvDsKyHoc.Name = "dgvDsKyHoc";
            this.dgvDsKyHoc.Size = new System.Drawing.Size(953, 231);
            this.dgvDsKyHoc.TabIndex = 0;
            this.dgvDsKyHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsKyHoc_CellClick);
            // 
            // tpChiDinhMonHoc
            // 
            this.tpChiDinhMonHoc.Controls.Add(this.btnLockOrUnlockMonHoc);
            this.tpChiDinhMonHoc.Controls.Add(this.dgvChiDinhMHtoKyhoc);
            this.tpChiDinhMonHoc.Controls.Add(this.btnSaveChiDinhMHtoKyhoc);
            this.tpChiDinhMonHoc.Controls.Add(this.btnUpdateSetMHtoKyHoc);
            this.tpChiDinhMonHoc.Controls.Add(this.btnNew);
            this.tpChiDinhMonHoc.Controls.Add(this.label7);
            this.tpChiDinhMonHoc.Controls.Add(this.label6);
            this.tpChiDinhMonHoc.Controls.Add(this.cbChonKyHoc);
            this.tpChiDinhMonHoc.Controls.Add(this.label5);
            this.tpChiDinhMonHoc.Controls.Add(this.dgvDsKyHocMonHoc);
            this.tpChiDinhMonHoc.Location = new System.Drawing.Point(4, 22);
            this.tpChiDinhMonHoc.Name = "tpChiDinhMonHoc";
            this.tpChiDinhMonHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tpChiDinhMonHoc.Size = new System.Drawing.Size(1025, 535);
            this.tpChiDinhMonHoc.TabIndex = 1;
            this.tpChiDinhMonHoc.Text = "Chỉ định môn học";
            this.tpChiDinhMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnLockOrUnlockMonHoc
            // 
            this.btnLockOrUnlockMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockOrUnlockMonHoc.Image = global::ASM.Properties.Resources.Kính_Lúp1;
            this.btnLockOrUnlockMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLockOrUnlockMonHoc.Location = new System.Drawing.Point(801, 436);
            this.btnLockOrUnlockMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLockOrUnlockMonHoc.Name = "btnLockOrUnlockMonHoc";
            this.btnLockOrUnlockMonHoc.Size = new System.Drawing.Size(172, 79);
            this.btnLockOrUnlockMonHoc.TabIndex = 56;
            this.btnLockOrUnlockMonHoc.Text = "Khóa/Mở Khóa";
            this.btnLockOrUnlockMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLockOrUnlockMonHoc.UseVisualStyleBackColor = true;
            this.btnLockOrUnlockMonHoc.Click += new System.EventHandler(this.btnLockOrUnlockMonHoc_Click);
            // 
            // dgvChiDinhMHtoKyhoc
            // 
            this.dgvChiDinhMHtoKyhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiDinhMHtoKyhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckColumn});
            this.dgvChiDinhMHtoKyhoc.Location = new System.Drawing.Point(639, 50);
            this.dgvChiDinhMHtoKyhoc.Name = "dgvChiDinhMHtoKyhoc";
            this.dgvChiDinhMHtoKyhoc.Size = new System.Drawing.Size(310, 150);
            this.dgvChiDinhMHtoKyhoc.TabIndex = 55;
            // 
            // CheckColumn
            // 
            this.CheckColumn.HeaderText = "MonHoc";
            this.CheckColumn.Name = "CheckColumn";
            // 
            // btnSaveChiDinhMHtoKyhoc
            // 
            this.btnSaveChiDinhMHtoKyhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChiDinhMHtoKyhoc.Image = global::ASM.Properties.Resources.save1;
            this.btnSaveChiDinhMHtoKyhoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChiDinhMHtoKyhoc.Location = new System.Drawing.Point(565, 435);
            this.btnSaveChiDinhMHtoKyhoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChiDinhMHtoKyhoc.Name = "btnSaveChiDinhMHtoKyhoc";
            this.btnSaveChiDinhMHtoKyhoc.Size = new System.Drawing.Size(104, 79);
            this.btnSaveChiDinhMHtoKyhoc.TabIndex = 54;
            this.btnSaveChiDinhMHtoKyhoc.Text = "Lưu";
            this.btnSaveChiDinhMHtoKyhoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChiDinhMHtoKyhoc.UseVisualStyleBackColor = true;
            this.btnSaveChiDinhMHtoKyhoc.Click += new System.EventHandler(this.btnSaveChiDinhMHtoKyhoc_Click);
            // 
            // btnUpdateSetMHtoKyHoc
            // 
            this.btnUpdateSetMHtoKyHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSetMHtoKyHoc.Image = global::ASM.Properties.Resources.butchi1;
            this.btnUpdateSetMHtoKyHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSetMHtoKyHoc.Location = new System.Drawing.Point(312, 436);
            this.btnUpdateSetMHtoKyHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSetMHtoKyHoc.Name = "btnUpdateSetMHtoKyHoc";
            this.btnUpdateSetMHtoKyHoc.Size = new System.Drawing.Size(105, 79);
            this.btnUpdateSetMHtoKyHoc.TabIndex = 53;
            this.btnUpdateSetMHtoKyHoc.Text = "Sửa";
            this.btnUpdateSetMHtoKyHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSetMHtoKyHoc.UseVisualStyleBackColor = true;
            this.btnUpdateSetMHtoKyHoc.Click += new System.EventHandler(this.btnUpdateSetMHtoKyHoc_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(67, 435);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 78);
            this.btnNew.TabIndex = 52;
            this.btnNew.Text = "Thêm";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Chọn môn học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Chọn kỳ học:";
            // 
            // cbChonKyHoc
            // 
            this.cbChonKyHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonKyHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChonKyHoc.FormattingEnabled = true;
            this.cbChonKyHoc.Location = new System.Drawing.Point(230, 117);
            this.cbChonKyHoc.Name = "cbChonKyHoc";
            this.cbChonKyHoc.Size = new System.Drawing.Size(121, 28);
            this.cbChonKyHoc.TabIndex = 21;
            this.cbChonKyHoc.SelectedIndexChanged += new System.EventHandler(this.cbChonKyHoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(346, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chỉ Định Môn Học";
            // 
            // dgvDsKyHocMonHoc
            // 
            this.dgvDsKyHocMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsKyHocMonHoc.Location = new System.Drawing.Point(67, 222);
            this.dgvDsKyHocMonHoc.Name = "dgvDsKyHocMonHoc";
            this.dgvDsKyHocMonHoc.Size = new System.Drawing.Size(906, 195);
            this.dgvDsKyHocMonHoc.TabIndex = 0;
            this.dgvDsKyHocMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsKyHocMonHoc_CellClick);
            // 
            // FormQuanLyKyHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 561);
            this.Controls.Add(this.tcQlyKyHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyKyHoc";
            this.Text = "FormQuanLyKyHoc";
            this.tcQlyKyHoc.ResumeLayout(false);
            this.tpTaoKyHoc.ResumeLayout(false);
            this.tpTaoKyHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKyHoc)).EndInit();
            this.tpChiDinhMonHoc.ResumeLayout(false);
            this.tpChiDinhMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiDinhMHtoKyhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKyHocMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQlyKyHoc;
        private System.Windows.Forms.TabPage tpTaoKyHoc;
        private System.Windows.Forms.TabPage tpChiDinhMonHoc;
        private System.Windows.Forms.DataGridView dgvDsKyHoc;
        private System.Windows.Forms.DataGridView dgvDsKyHocMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNamBatDau;
        private System.Windows.Forms.TextBox txtTenKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNamKetThuc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbChonKyHoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUseKyHoc;
        private System.Windows.Forms.Button btnSaveChiDinhMHtoKyhoc;
        private System.Windows.Forms.Button btnUpdateSetMHtoKyHoc;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvChiDinhMHtoKyhoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckColumn;
        private System.Windows.Forms.Button btnLockOrUnlockMonHoc;
    }
}