namespace ASM
{
    partial class FormQuanLyCongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyCongViec));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpNgayChotViecKM = new System.Windows.Forms.DateTimePicker();
            this.txtKyhoc = new System.Windows.Forms.TextBox();
            this.dgvChiDinhGVtoMH = new System.Windows.Forms.DataGridView();
            this.CheckColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSaveChiDinhGVtoMH = new System.Windows.Forms.Button();
            this.btnUpdateSetGVtoMH = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbChonMonHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDsMonHocGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpNgayLopGV = new System.Windows.Forms.DateTimePicker();
            this.txtKyhocFormGVCLass = new System.Windows.Forms.TextBox();
            this.dgvDsGvFormGvClass = new System.Windows.Forms.DataGridView();
            this.btnSaveGvtoClass = new System.Windows.Forms.Button();
            this.btnUpdateGvtoClass = new System.Windows.Forms.Button();
            this.btnNewGvToClass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDsGvClass = new System.Windows.Forms.DataGridView();
            this.CCo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiDinhGVtoMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMonHocGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsGvFormGvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsGvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpNgayChotViecKM);
            this.tabPage1.Controls.Add(this.txtKyhoc);
            this.tabPage1.Controls.Add(this.dgvChiDinhGVtoMH);
            this.tabPage1.Controls.Add(this.btnSaveChiDinhGVtoMH);
            this.tabPage1.Controls.Add(this.btnUpdateSetGVtoMH);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbChonMonHoc);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dgvDsMonHocGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1025, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phân Công GV vào Môn học";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpNgayChotViecKM
            // 
            this.dtpNgayChotViecKM.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChotViecKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChotViecKM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChotViecKM.Location = new System.Drawing.Point(225, 169);
            this.dtpNgayChotViecKM.Name = "dtpNgayChotViecKM";
            this.dtpNgayChotViecKM.Size = new System.Drawing.Size(147, 26);
            this.dtpNgayChotViecKM.TabIndex = 79;
            // 
            // txtKyhoc
            // 
            this.txtKyhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyhoc.Location = new System.Drawing.Point(225, 76);
            this.txtKyhoc.Name = "txtKyhoc";
            this.txtKyhoc.ReadOnly = true;
            this.txtKyhoc.Size = new System.Drawing.Size(147, 26);
            this.txtKyhoc.TabIndex = 78;
            // 
            // dgvChiDinhGVtoMH
            // 
            this.dgvChiDinhGVtoMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiDinhGVtoMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckColumn});
            this.dgvChiDinhGVtoMH.Location = new System.Drawing.Point(591, 71);
            this.dgvChiDinhGVtoMH.Name = "dgvChiDinhGVtoMH";
            this.dgvChiDinhGVtoMH.Size = new System.Drawing.Size(374, 132);
            this.dgvChiDinhGVtoMH.TabIndex = 77;
            // 
            // CheckColumn
            // 
            this.CheckColumn.HeaderText = "GVChuaDuocPhanVaoMon";
            this.CheckColumn.Name = "CheckColumn";
            // 
            // btnSaveChiDinhGVtoMH
            // 
            this.btnSaveChiDinhGVtoMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChiDinhGVtoMH.Image = global::ASM.Properties.Resources.save1;
            this.btnSaveChiDinhGVtoMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChiDinhGVtoMH.Location = new System.Drawing.Point(696, 436);
            this.btnSaveChiDinhGVtoMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChiDinhGVtoMH.Name = "btnSaveChiDinhGVtoMH";
            this.btnSaveChiDinhGVtoMH.Size = new System.Drawing.Size(104, 79);
            this.btnSaveChiDinhGVtoMH.TabIndex = 76;
            this.btnSaveChiDinhGVtoMH.Text = "Lưu";
            this.btnSaveChiDinhGVtoMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChiDinhGVtoMH.UseVisualStyleBackColor = true;
            this.btnSaveChiDinhGVtoMH.Click += new System.EventHandler(this.btnSaveChiDinhGVtoMH_Click);
            // 
            // btnUpdateSetGVtoMH
            // 
            this.btnUpdateSetGVtoMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSetGVtoMH.Image = global::ASM.Properties.Resources.butchi1;
            this.btnUpdateSetGVtoMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSetGVtoMH.Location = new System.Drawing.Point(437, 436);
            this.btnUpdateSetGVtoMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSetGVtoMH.Name = "btnUpdateSetGVtoMH";
            this.btnUpdateSetGVtoMH.Size = new System.Drawing.Size(105, 79);
            this.btnUpdateSetGVtoMH.TabIndex = 75;
            this.btnUpdateSetGVtoMH.Text = "Sửa";
            this.btnUpdateSetGVtoMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSetGVtoMH.UseVisualStyleBackColor = true;
            this.btnUpdateSetGVtoMH.Click += new System.EventHandler(this.btnUpdateSetGVtoMH_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(187, 436);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 78);
            this.btnNew.TabIndex = 74;
            this.btnNew.Text = "Thêm";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Chọn GV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Kỳ học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Ngày chốt việc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Chọn môn học:";
            // 
            // cbChonMonHoc
            // 
            this.cbChonMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChonMonHoc.FormattingEnabled = true;
            this.cbChonMonHoc.Location = new System.Drawing.Point(225, 124);
            this.cbChonMonHoc.Name = "cbChonMonHoc";
            this.cbChonMonHoc.Size = new System.Drawing.Size(147, 28);
            this.cbChonMonHoc.TabIndex = 69;
            this.cbChonMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbChonMonHoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(280, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 31);
            this.label5.TabIndex = 68;
            this.label5.Text = "Chỉ Định GV cho Môn Học";
            // 
            // dgvDsMonHocGV
            // 
            this.dgvDsMonHocGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsMonHocGV.Location = new System.Drawing.Point(59, 222);
            this.dgvDsMonHocGV.Name = "dgvDsMonHocGV";
            this.dgvDsMonHocGV.Size = new System.Drawing.Size(906, 195);
            this.dgvDsMonHocGV.TabIndex = 67;
            this.dgvDsMonHocGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsMonHocGV_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpNgayLopGV);
            this.tabPage2.Controls.Add(this.txtKyhocFormGVCLass);
            this.tabPage2.Controls.Add(this.dgvDsGvFormGvClass);
            this.tabPage2.Controls.Add(this.btnSaveGvtoClass);
            this.tabPage2.Controls.Add(this.btnUpdateGvtoClass);
            this.tabPage2.Controls.Add(this.btnNewGvToClass);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cbLop);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dgvDsGvClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1025, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phân công GV vào lớp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpNgayLopGV
            // 
            this.dtpNgayLopGV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLopGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLopGV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLopGV.Location = new System.Drawing.Point(225, 169);
            this.dtpNgayLopGV.Name = "dtpNgayLopGV";
            this.dtpNgayLopGV.Size = new System.Drawing.Size(147, 26);
            this.dtpNgayLopGV.TabIndex = 79;
            // 
            // txtKyhocFormGVCLass
            // 
            this.txtKyhocFormGVCLass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyhocFormGVCLass.Location = new System.Drawing.Point(225, 76);
            this.txtKyhocFormGVCLass.Name = "txtKyhocFormGVCLass";
            this.txtKyhocFormGVCLass.ReadOnly = true;
            this.txtKyhocFormGVCLass.Size = new System.Drawing.Size(147, 26);
            this.txtKyhocFormGVCLass.TabIndex = 78;
            // 
            // dgvDsGvFormGvClass
            // 
            this.dgvDsGvFormGvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsGvFormGvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCo});
            this.dgvDsGvFormGvClass.Location = new System.Drawing.Point(591, 71);
            this.dgvDsGvFormGvClass.Name = "dgvDsGvFormGvClass";
            this.dgvDsGvFormGvClass.Size = new System.Drawing.Size(374, 132);
            this.dgvDsGvFormGvClass.TabIndex = 77;
            // 
            // btnSaveGvtoClass
            // 
            this.btnSaveGvtoClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGvtoClass.Image = global::ASM.Properties.Resources.save1;
            this.btnSaveGvtoClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveGvtoClass.Location = new System.Drawing.Point(696, 436);
            this.btnSaveGvtoClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveGvtoClass.Name = "btnSaveGvtoClass";
            this.btnSaveGvtoClass.Size = new System.Drawing.Size(104, 79);
            this.btnSaveGvtoClass.TabIndex = 76;
            this.btnSaveGvtoClass.Text = "Lưu";
            this.btnSaveGvtoClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveGvtoClass.UseVisualStyleBackColor = true;
            this.btnSaveGvtoClass.Click += new System.EventHandler(this.btnSaveGvtoClass_Click);
            // 
            // btnUpdateGvtoClass
            // 
            this.btnUpdateGvtoClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGvtoClass.Image = global::ASM.Properties.Resources.butchi1;
            this.btnUpdateGvtoClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGvtoClass.Location = new System.Drawing.Point(449, 436);
            this.btnUpdateGvtoClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateGvtoClass.Name = "btnUpdateGvtoClass";
            this.btnUpdateGvtoClass.Size = new System.Drawing.Size(105, 79);
            this.btnUpdateGvtoClass.TabIndex = 75;
            this.btnUpdateGvtoClass.Text = "Sửa";
            this.btnUpdateGvtoClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateGvtoClass.UseVisualStyleBackColor = true;
            this.btnUpdateGvtoClass.Click += new System.EventHandler(this.btnUpdateGvtoClass_Click);
            // 
            // btnNewGvToClass
            // 
            this.btnNewGvToClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGvToClass.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGvToClass.Image")));
            this.btnNewGvToClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGvToClass.Location = new System.Drawing.Point(187, 436);
            this.btnNewGvToClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGvToClass.Name = "btnNewGvToClass";
            this.btnNewGvToClass.Size = new System.Drawing.Size(112, 78);
            this.btnNewGvToClass.TabIndex = 74;
            this.btnNewGvToClass.Text = "Thêm";
            this.btnNewGvToClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewGvToClass.UseVisualStyleBackColor = true;
            this.btnNewGvToClass.Click += new System.EventHandler(this.btnNewGvToClass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Chọn GV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Kỳ học:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Ngày chốt việc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 73;
            this.label9.Text = "Chọn lớp học:";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(225, 124);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(147, 28);
            this.cbLop.TabIndex = 69;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(338, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 31);
            this.label10.TabIndex = 68;
            this.label10.Text = "Chỉ Định GV cho lớp";
            // 
            // dgvDsGvClass
            // 
            this.dgvDsGvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsGvClass.Location = new System.Drawing.Point(59, 222);
            this.dgvDsGvClass.Name = "dgvDsGvClass";
            this.dgvDsGvClass.Size = new System.Drawing.Size(906, 195);
            this.dgvDsGvClass.TabIndex = 67;
            this.dgvDsGvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsGvClass_CellClick);
            // 
            // CCo
            // 
            this.CCo.HeaderText = "GVChuaDuocPhanVaoLop";
            this.CCo.Name = "CCo";
            // 
            // FormQuanLyCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormQuanLyCongViec";
            this.Text = "FormQuanLyCongViec";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiDinhGVtoMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMonHocGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsGvFormGvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsGvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpNgayChotViecKM;
        private System.Windows.Forms.TextBox txtKyhoc;
        private System.Windows.Forms.DataGridView dgvChiDinhGVtoMH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckColumn;
        private System.Windows.Forms.Button btnSaveChiDinhGVtoMH;
        private System.Windows.Forms.Button btnUpdateSetGVtoMH;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbChonMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDsMonHocGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpNgayLopGV;
        private System.Windows.Forms.TextBox txtKyhocFormGVCLass;
        private System.Windows.Forms.DataGridView dgvDsGvFormGvClass;
        private System.Windows.Forms.Button btnSaveGvtoClass;
        private System.Windows.Forms.Button btnUpdateGvtoClass;
        private System.Windows.Forms.Button btnNewGvToClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDsGvClass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CCo;
    }
}