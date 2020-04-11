using System;

namespace ATINTimekeeping.FormHeThong
{
    partial class KhaiBaoNgayLe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhaiBaoNgayLe));
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.gvNgayLe = new System.Windows.Forms.DataGridView();
            this.MaNgayNghiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNgayNghiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dpkNgayLe = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTenNgayLe = new DevExpress.XtraEditors.TextEdit();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNgayLe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNgayLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.gvNgayLe);
            this.panelBody.Controls.Add(this.panelControl2);
            this.panelBody.Controls.Add(this.ribbonStatusBar1);
            this.panelBody.Controls.Add(this.ribbonControl1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1000, 550);
            this.panelBody.TabIndex = 9;
            // 
            // gvNgayLe
            // 
            this.gvNgayLe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvNgayLe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNgayLe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNgayNghiLe,
            this.NgayLe,
            this.TenNgayNghiLe,
            this.MoTa});
            this.gvNgayLe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvNgayLe.Location = new System.Drawing.Point(2, 100);
            this.gvNgayLe.Name = "gvNgayLe";
            this.gvNgayLe.Size = new System.Drawing.Size(996, 448);
            this.gvNgayLe.TabIndex = 0;
            this.gvNgayLe.SelectionChanged += new System.EventHandler(this.gvNgayLe_SelectionChanged);
            // 
            // MaNgayNghiLe
            // 
            this.MaNgayNghiLe.DataPropertyName = "MaNgayNghiLe";
            this.MaNgayNghiLe.HeaderText = "Mã ngày lễ";
            this.MaNgayNghiLe.Name = "MaNgayNghiLe";
            this.MaNgayNghiLe.ReadOnly = true;
            this.MaNgayNghiLe.Visible = false;
            // 
            // NgayLe
            // 
            this.NgayLe.DataPropertyName = "NgayLe";
            this.NgayLe.HeaderText = "Ngày";
            this.NgayLe.Name = "NgayLe";
            // 
            // TenNgayNghiLe
            // 
            this.TenNgayNghiLe.DataPropertyName = "TenNgayNghiLe";
            this.TenNgayNghiLe.HeaderText = "Tên ngày lễ";
            this.TenNgayNghiLe.Name = "TenNgayNghiLe";
            this.TenNgayNghiLe.Width = 300;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.Visible = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.AutoSize = true;
            this.panelControl2.Controls.Add(this.dpkNgayLe);
            this.panelControl2.Controls.Add(this.textBox1);
            this.panelControl2.Controls.Add(this.txtTenNgayLe);
            this.panelControl2.Controls.Add(this.textBox4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 29);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(996, 71);
            this.panelControl2.TabIndex = 4;
            // 
            // dpkNgayLe
            // 
            this.dpkNgayLe.CustomFormat = "dd/MM/yyyy";
            this.dpkNgayLe.Location = new System.Drawing.Point(90, 14);
            this.dpkNgayLe.Name = "dpkNgayLe";
            this.dpkNgayLe.Size = new System.Drawing.Size(352, 21);
            this.dpkNgayLe.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(11, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 14);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Tên ngày lễ";
            // 
            // txtTenNgayLe
            // 
            this.txtTenNgayLe.EditValue = "";
            this.txtTenNgayLe.Location = new System.Drawing.Point(90, 45);
            this.txtTenNgayLe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNgayLe.Name = "txtTenNgayLe";
            this.txtTenNgayLe.Size = new System.Drawing.Size(352, 20);
            this.txtTenNgayLe.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(11, 20);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(59, 14);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Ngày lễ";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.BackColor = System.Drawing.Color.DodgerBlue;
            this.ribbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonStatusBar1.ItemLinks.Add(this.btnThem);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnSua);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnXoa);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnLamMoi);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(2, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(996, 27);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 4;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLamMoi});
            this.ribbonControl1.Location = new System.Drawing.Point(733, 399);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(75, 150);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // KhaiBaoNgayLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelBody);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhaiBaoNgayLe";
            this.Text = "KhaiBaoNgayLe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNgayLe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNgayLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenNgayLe;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dpkNgayLe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView gvNgayLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNgayNghiLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNgayNghiLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
    }
}