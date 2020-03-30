namespace QuanLyNhanSu.CT
{
    partial class TinhLuong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLCB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHeSoLuong = new System.Windows.Forms.ComboBox();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.lbTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btXem = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbChucVu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtLCB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbHeSoLuong);
            this.panel1.Controls.Add(this.btCapNhat);
            this.panel1.Controls.Add(this.lbTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(17, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 431);
            this.panel1.TabIndex = 0;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.Location = new System.Drawing.Point(97, 112);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(59, 13);
            this.lbChucVu.TabIndex = 8;
            this.lbChucVu.Text = "Chức Vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chức Vụ:";
            // 
            // txtLCB
            // 
            this.txtLCB.Location = new System.Drawing.Point(606, 76);
            this.txtLCB.Name = "txtLCB";
            this.txtLCB.Size = new System.Drawing.Size(93, 20);
            this.txtLCB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lương Cơ Bản";
            // 
            // cbHeSoLuong
            // 
            this.cbHeSoLuong.FormattingEnabled = true;
            this.cbHeSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbHeSoLuong.Location = new System.Drawing.Point(334, 76);
            this.cbHeSoLuong.Name = "cbHeSoLuong";
            this.cbHeSoLuong.Size = new System.Drawing.Size(153, 21);
            this.cbHeSoLuong.TabIndex = 5;
            this.cbHeSoLuong.SelectedIndexChanged += new System.EventHandler(this.cbHeSoLuong_SelectedIndexChanged);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(758, 71);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(181, 28);
            this.btCapNhat.TabIndex = 4;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(100, 79);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(41, 13);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ số lương";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Lương Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.TenNV,
            this.HeSoLuong,
            this.SNL,
            this.T,
            this.P,
            this.PhuCap,
            this.TL});
            this.dataGridView1.Location = new System.Drawing.Point(0, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(955, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MaNhanVien";
            this.Ma.HeaderText = "Mã Nhân Viên";
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "Hệ Số Lương";
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.ReadOnly = true;
            // 
            // SNL
            // 
            this.SNL.DataPropertyName = "NL";
            this.SNL.HeaderText = "Số Ngày Làm";
            this.SNL.Name = "SNL";
            this.SNL.ReadOnly = true;
            // 
            // T
            // 
            this.T.DataPropertyName = "T";
            this.T.HeaderText = "Tiền Thưởng";
            this.T.Name = "T";
            this.T.ReadOnly = true;
            // 
            // P
            // 
            this.P.DataPropertyName = "P";
            this.P.HeaderText = "Tiền Phạt";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "Tien";
            this.PhuCap.HeaderText = "Phụ Cấp";
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.ReadOnly = true;
            // 
            // TL
            // 
            this.TL.DataPropertyName = "TL";
            this.TL.HeaderText = "Tổng Lương";
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(807, 469);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(69, 20);
            this.txtNam.TabIndex = 1;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bảng lương theo tháng";
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(882, 467);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(90, 23);
            this.btXem.TabIndex = 9;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(758, 469);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(35, 20);
            this.txtThang.TabIndex = 1;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(793, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "/";
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.ForeColor = System.Drawing.Color.Red;
            this.lbTB.Location = new System.Drawing.Point(478, 472);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(10, 13);
            this.lbTB.TabIndex = 2;
            this.lbTB.Text = ".";
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.label7);
            this.Name = "TinhLuong";
            this.Size = new System.Drawing.Size(990, 502);
            this.Load += new System.EventHandler(this.TinhLuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbHeSoLuong;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTB;
    }
}
