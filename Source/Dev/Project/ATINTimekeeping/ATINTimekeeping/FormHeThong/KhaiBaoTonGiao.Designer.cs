namespace ATINTimekeeping.FormHeThong
{
    partial class KhaiBaoTonGiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhaiBaoTonGiao));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtTonGiao = new DevExpress.XtraEditors.TextEdit();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dgvTonGiao = new System.Windows.Forms.DataGridView();
            this.MaTonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonGiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonGiao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtTonGiao);
            this.panelControl2.Controls.Add(this.textBox4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 27);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1000, 54);
            this.panelControl2.TabIndex = 4;
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.EditValue = "";
            this.txtTonGiao.Location = new System.Drawing.Point(91, 17);
            this.txtTonGiao.Margin = new System.Windows.Forms.Padding(2);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.Size = new System.Drawing.Size(351, 20);
            this.txtTonGiao.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(10, 20);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 14);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Tên tôn giáo";
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
            this.ribbonControl1.Location = new System.Drawing.Point(453, 163);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(75, 150);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonStatusBar1.ItemLinks.Add(this.btnThem);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnSua);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnXoa);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnLamMoi);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1000, 27);
            // 
            // dgvTonGiao
            // 
            this.dgvTonGiao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTonGiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonGiao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTonGiao,
            this.TenTonGiao});
            this.dgvTonGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTonGiao.Location = new System.Drawing.Point(0, 81);
            this.dgvTonGiao.Name = "dgvTonGiao";
            this.dgvTonGiao.Size = new System.Drawing.Size(1000, 469);
            this.dgvTonGiao.TabIndex = 7;
            this.dgvTonGiao.SelectionChanged += new System.EventHandler(this.dgvTonGiao_SelectionChanged);
            // 
            // MaTonGiao
            // 
            this.MaTonGiao.DataPropertyName = "MaTonGiao";
            this.MaTonGiao.HeaderText = "Mã tôn giáo";
            this.MaTonGiao.Name = "MaTonGiao";
            this.MaTonGiao.Visible = false;
            // 
            // TenTonGiao
            // 
            this.TenTonGiao.DataPropertyName = "TenTonGiao";
            this.TenTonGiao.HeaderText = "Tên tôn giáo";
            this.TenTonGiao.Name = "TenTonGiao";
            this.TenTonGiao.Width = 400;
            // 
            // KhaiBaoTonGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.dgvTonGiao);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhaiBaoTonGiao";
            this.Text = "KhaiBaoTonGiao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonGiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonGiao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtTonGiao;
        private System.Windows.Forms.TextBox textBox4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.DataGridView dgvTonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
    }
}