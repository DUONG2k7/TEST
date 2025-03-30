namespace ASM
{
    partial class FormSvXemLichHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLichHoc = new System.Windows.Forms.DataGridView();
            this.lblLichHoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.AllowUserToAddRows = false;
            this.dgvLichHoc.AllowUserToDeleteRows = false;
            this.dgvLichHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichHoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichHoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichHoc.Location = new System.Drawing.Point(12, 86);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.RowHeadersWidth = 51;
            this.dgvLichHoc.Size = new System.Drawing.Size(940, 460);
            this.dgvLichHoc.TabIndex = 53;
            // 
            // lblLichHoc
            // 
            this.lblLichHoc.AutoSize = true;
            this.lblLichHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichHoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLichHoc.Location = new System.Drawing.Point(425, 9);
            this.lblLichHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLichHoc.Name = "lblLichHoc";
            this.lblLichHoc.Size = new System.Drawing.Size(128, 31);
            this.lblLichHoc.TabIndex = 52;
            this.lblLichHoc.Text = "Lịch Học";
            // 
            // FormSvXemLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 558);
            this.Controls.Add(this.dgvLichHoc);
            this.Controls.Add(this.lblLichHoc);
            this.Name = "FormSvXemLichHoc";
            this.Text = "FormSvXemLichHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichHoc;
        private System.Windows.Forms.Label lblLichHoc;
    }
}