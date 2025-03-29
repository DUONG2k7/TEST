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
            this.dgvChiDinhGVtoMH = new System.Windows.Forms.DataGridView();
            this.btnSaveChiDinhGVtoMH = new System.Windows.Forms.Button();
            this.btnUpdateSetGVtoMH = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbChonMonHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDsMonHocGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKyhoc = new System.Windows.Forms.TextBox();
            this.CheckColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayChotViec = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiDinhGVtoMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMonHocGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiDinhGVtoMH
            // 
            this.dgvChiDinhGVtoMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiDinhGVtoMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckColumn});
            this.dgvChiDinhGVtoMH.Location = new System.Drawing.Point(580, 84);
            this.dgvChiDinhGVtoMH.Name = "dgvChiDinhGVtoMH";
            this.dgvChiDinhGVtoMH.Size = new System.Drawing.Size(374, 132);
            this.dgvChiDinhGVtoMH.TabIndex = 64;
            // 
            // btnSaveChiDinhGVtoMH
            // 
            this.btnSaveChiDinhGVtoMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChiDinhGVtoMH.Image = global::ASM.Properties.Resources.save1;
            this.btnSaveChiDinhGVtoMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChiDinhGVtoMH.Location = new System.Drawing.Point(685, 449);
            this.btnSaveChiDinhGVtoMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChiDinhGVtoMH.Name = "btnSaveChiDinhGVtoMH";
            this.btnSaveChiDinhGVtoMH.Size = new System.Drawing.Size(104, 79);
            this.btnSaveChiDinhGVtoMH.TabIndex = 63;
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
            this.btnUpdateSetGVtoMH.Location = new System.Drawing.Point(438, 449);
            this.btnUpdateSetGVtoMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSetGVtoMH.Name = "btnUpdateSetGVtoMH";
            this.btnUpdateSetGVtoMH.Size = new System.Drawing.Size(105, 79);
            this.btnUpdateSetGVtoMH.TabIndex = 62;
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
            this.btnNew.Location = new System.Drawing.Point(176, 449);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 78);
            this.btnNew.TabIndex = 61;
            this.btnNew.Text = "Thêm";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(495, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Chọn GV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Chọn môn học:";
            // 
            // cbChonMonHoc
            // 
            this.cbChonMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChonMonHoc.FormattingEnabled = true;
            this.cbChonMonHoc.Location = new System.Drawing.Point(214, 137);
            this.cbChonMonHoc.Name = "cbChonMonHoc";
            this.cbChonMonHoc.Size = new System.Drawing.Size(147, 28);
            this.cbChonMonHoc.TabIndex = 58;
            this.cbChonMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbChonMonHoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(327, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 31);
            this.label5.TabIndex = 57;
            this.label5.Text = "Chỉ Định Môn Học";
            // 
            // dgvDsMonHocGV
            // 
            this.dgvDsMonHocGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsMonHocGV.Location = new System.Drawing.Point(48, 235);
            this.dgvDsMonHocGV.Name = "dgvDsMonHocGV";
            this.dgvDsMonHocGV.Size = new System.Drawing.Size(906, 195);
            this.dgvDsMonHocGV.TabIndex = 56;
            this.dgvDsMonHocGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsMonHocGV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Kỳ học:";
            // 
            // txtKyhoc
            // 
            this.txtKyhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyhoc.Location = new System.Drawing.Point(214, 89);
            this.txtKyhoc.Name = "txtKyhoc";
            this.txtKyhoc.ReadOnly = true;
            this.txtKyhoc.Size = new System.Drawing.Size(147, 26);
            this.txtKyhoc.TabIndex = 65;
            // 
            // CheckColumn
            // 
            this.CheckColumn.HeaderText = "GVChuaDuocPhanVaoMon";
            this.CheckColumn.Name = "CheckColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ngày chốt việc:";
            // 
            // dtpNgayChotViec
            // 
            this.dtpNgayChotViec.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChotViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChotViec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChotViec.Location = new System.Drawing.Point(214, 182);
            this.dtpNgayChotViec.Name = "dtpNgayChotViec";
            this.dtpNgayChotViec.Size = new System.Drawing.Size(147, 26);
            this.dtpNgayChotViec.TabIndex = 66;
            // 
            // FormQuanLyCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 561);
            this.Controls.Add(this.dtpNgayChotViec);
            this.Controls.Add(this.txtKyhoc);
            this.Controls.Add(this.dgvChiDinhGVtoMH);
            this.Controls.Add(this.btnSaveChiDinhGVtoMH);
            this.Controls.Add(this.btnUpdateSetGVtoMH);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbChonMonHoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDsMonHocGV);
            this.Name = "FormQuanLyCongViec";
            this.Text = "FormQuanLyCongViec";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiDinhGVtoMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMonHocGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiDinhGVtoMH;
        private System.Windows.Forms.Button btnSaveChiDinhGVtoMH;
        private System.Windows.Forms.Button btnUpdateSetGVtoMH;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbChonMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDsMonHocGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKyhoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayChotViec;
    }
}