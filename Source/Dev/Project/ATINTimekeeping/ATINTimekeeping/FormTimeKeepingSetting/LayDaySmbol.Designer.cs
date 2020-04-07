namespace ATINTimekeeping.FormTimeKeepingSetting
{
    partial class LayDaySmbol
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaKyHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKyHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuDung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TinhCong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKyHieu,
            this.MoTa,
            this.TenKyHieu,
            this.SuDung,
            this.TinhCong});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 353);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // MaKyHieu
            // 
            this.MaKyHieu.DataPropertyName = "MaKyHieu";
            this.MaKyHieu.HeaderText = "Mã";
            this.MaKyHieu.MinimumWidth = 6;
            this.MaKyHieu.Name = "MaKyHieu";
            this.MaKyHieu.ReadOnly = true;
            this.MaKyHieu.Width = 80;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 165;
            // 
            // TenKyHieu
            // 
            this.TenKyHieu.DataPropertyName = "TenKyHieu";
            this.TenKyHieu.HeaderText = "Kí hiệu";
            this.TenKyHieu.MinimumWidth = 6;
            this.TenKyHieu.Name = "TenKyHieu";
            this.TenKyHieu.ReadOnly = true;
            this.TenKyHieu.Width = 80;
            // 
            // SuDung
            // 
            this.SuDung.DataPropertyName = "SuDung";
            this.SuDung.HeaderText = "Sử dụng";
            this.SuDung.MinimumWidth = 6;
            this.SuDung.Name = "SuDung";
            this.SuDung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SuDung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SuDung.Width = 125;
            // 
            // TinhCong
            // 
            this.TinhCong.DataPropertyName = "TinhCong";
            this.TinhCong.HeaderText = "Tính công";
            this.TinhCong.MinimumWidth = 6;
            this.TinhCong.Name = "TinhCong";
            this.TinhCong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhCong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TinhCong.Width = 125;
            // 
            // LayDaySmbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "LayDaySmbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ký hiệu các loại vắng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LayDaySmbol_FormClosing);
            this.Load += new System.EventHandler(this.LayDaySmbol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKyHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKyHieu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SuDung;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhCong;
    }
}