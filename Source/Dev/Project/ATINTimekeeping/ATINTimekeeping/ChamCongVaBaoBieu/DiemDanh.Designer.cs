namespace ATINTimekeeping.ChamCongVaBaoBieu
{
    partial class DiemDanh
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateChonNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(59, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn ngày:";
            // 
            // dateChonNgay
            // 
            this.dateChonNgay.CustomFormat = "dd/MM/yyyy";
            this.dateChonNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateChonNgay.Location = new System.Drawing.Point(152, 56);
            this.dateChonNgay.Name = "dateChonNgay";
            this.dateChonNgay.Size = new System.Drawing.Size(200, 23);
            this.dateChonNgay.TabIndex = 1;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(162, 132);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(125, 35);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 218);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.dateChonNgay);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm danh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dateChonNgay;
        private System.Windows.Forms.Button btnThucHien;
    }
}