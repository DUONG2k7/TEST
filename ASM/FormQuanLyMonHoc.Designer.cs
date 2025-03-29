namespace ASM
{
    partial class FormQuanLyMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyMonHoc));
            this.tcQlyKyHoc = new System.Windows.Forms.TabControl();
            this.CheckColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvDsMonHoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtSotiet = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tpTaoMonHoc = new System.Windows.Forms.TabPage();
            this.tcQlyKyHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMonHoc)).BeginInit();
            this.tpTaoMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQlyKyHoc
            // 
            this.tcQlyKyHoc.Controls.Add(this.tpTaoMonHoc);
            this.tcQlyKyHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQlyKyHoc.Location = new System.Drawing.Point(0, 0);
            this.tcQlyKyHoc.Name = "tcQlyKyHoc";
            this.tcQlyKyHoc.SelectedIndex = 0;
            this.tcQlyKyHoc.Size = new System.Drawing.Size(1033, 561);
            this.tcQlyKyHoc.TabIndex = 1;
            // 
            // CheckColumn
            // 
            this.CheckColumn.HeaderText = "GVChuaCoMonHoc";
            this.CheckColumn.Name = "CheckColumn";
            // 
            // dgvDsMonHoc
            // 
            this.dgvDsMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsMonHoc.Location = new System.Drawing.Point(40, 204);
            this.dgvDsMonHoc.Name = "dgvDsMonHoc";
            this.dgvDsMonHoc.Size = new System.Drawing.Size(953, 231);
            this.dgvDsMonHoc.TabIndex = 0;
            this.dgvDsMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsMonHoc_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên môn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(428, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tạo môn học";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(401, 81);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(227, 26);
            this.txtTenMon.TabIndex = 20;
            // 
            // txtSotiet
            // 
            this.txtSotiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSotiet.Location = new System.Drawing.Point(401, 130);
            this.txtSotiet.Name = "txtSotiet";
            this.txtSotiet.Size = new System.Drawing.Size(227, 26);
            this.txtSotiet.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(199, 449);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 78);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::ASM.Properties.Resources.butchi1;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(440, 449);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 79);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::ASM.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(708, 449);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 79);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tpTaoMonHoc
            // 
            this.tpTaoMonHoc.Controls.Add(this.btnSave);
            this.tpTaoMonHoc.Controls.Add(this.btnUpdate);
            this.tpTaoMonHoc.Controls.Add(this.btnAdd);
            this.tpTaoMonHoc.Controls.Add(this.txtSotiet);
            this.tpTaoMonHoc.Controls.Add(this.txtTenMon);
            this.tpTaoMonHoc.Controls.Add(this.label2);
            this.tpTaoMonHoc.Controls.Add(this.label3);
            this.tpTaoMonHoc.Controls.Add(this.label1);
            this.tpTaoMonHoc.Controls.Add(this.dgvDsMonHoc);
            this.tpTaoMonHoc.Location = new System.Drawing.Point(4, 22);
            this.tpTaoMonHoc.Name = "tpTaoMonHoc";
            this.tpTaoMonHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaoMonHoc.Size = new System.Drawing.Size(1025, 535);
            this.tpTaoMonHoc.TabIndex = 0;
            this.tpTaoMonHoc.Text = "Tạo môn học";
            this.tpTaoMonHoc.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 561);
            this.Controls.Add(this.tcQlyKyHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyMonHoc";
            this.Text = "FormQuanLyMonHoc";
            this.tcQlyKyHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMonHoc)).EndInit();
            this.tpTaoMonHoc.ResumeLayout(false);
            this.tpTaoMonHoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcQlyKyHoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckColumn;
        private System.Windows.Forms.TabPage tpTaoMonHoc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSotiet;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDsMonHoc;
    }
}