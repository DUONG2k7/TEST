namespace ASM
{
    partial class FormDanhSachHienThi
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.cbDanhSach = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(383, 11);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(641, 469);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // cbDanhSach
            // 
            this.cbDanhSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhSach.FormattingEnabled = true;
            this.cbDanhSach.Items.AddRange(new object[] {
            "Mặc định",
            "Top 3 sinh viên cao nhất",
            "Tăng dần theo mã sinh viên",
            "Giảm dần theo mã sinh viên",
            "Tăng dần theo giới tính",
            "Giảm dần theo giới tính"});
            this.cbDanhSach.Location = new System.Drawing.Point(19, 149);
            this.cbDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.cbDanhSach.Name = "cbDanhSach";
            this.cbDanhSach.Size = new System.Drawing.Size(337, 33);
            this.cbDanhSach.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ASM.Properties.Resources.image_170_1024x440;
            this.pictureBox6.Location = new System.Drawing.Point(19, 279);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(327, 130);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ASM.Properties.Resources._2020_FPTPolytechic;
            this.pictureBox4.Location = new System.Drawing.Point(88, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(197, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Image = global::ASM.Properties.Resources.Untitled_11;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(110, 199);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(147, 63);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FormDanhSachHienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 491);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbDanhSach);
            this.Controls.Add(this.dgvDanhSach);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDanhSachHienThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDanhSachHienThi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.ComboBox cbDanhSach;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}