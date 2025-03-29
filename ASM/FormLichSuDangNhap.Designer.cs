namespace ASM
{
    partial class FormLichSuDangNhap
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
            this.dgvLichSuDangNhap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuDangNhap
            // 
            this.dgvLichSuDangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuDangNhap.Location = new System.Drawing.Point(23, 68);
            this.dgvLichSuDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLichSuDangNhap.Name = "dgvLichSuDangNhap";
            this.dgvLichSuDangNhap.RowHeadersWidth = 51;
            this.dgvLichSuDangNhap.RowTemplate.Height = 24;
            this.dgvLichSuDangNhap.Size = new System.Drawing.Size(683, 245);
            this.dgvLichSuDangNhap.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(237, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lịch Sử Đăng Nhập";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(23, 327);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 34);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Thoát";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormLichSuDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 367);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvLichSuDangNhap);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLichSuDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLichSuDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}