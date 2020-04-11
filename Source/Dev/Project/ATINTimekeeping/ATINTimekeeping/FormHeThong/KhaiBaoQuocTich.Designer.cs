namespace ATINTimekeeping.FormHeThong
{
    partial class KhaiBaoQuocTich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhaiBaoQuocTich));
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.dgvQuocTich = new System.Windows.Forms.DataGridView();
            this.MaQuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new DevExpress.XtraEditors.PanelControl();
            this.txtQuocTich = new DevExpress.XtraEditors.TextEdit();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuocTich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuocTich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dgvQuocTich);
            this.panelBody.Controls.Add(this.panelHeader);
            this.panelBody.Controls.Add(this.ribbonStatusBar1);
            this.panelBody.Controls.Add(this.ribbonControl1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(950, 629);
            this.panelBody.TabIndex = 9;
            // 
            // dgvQuocTich
            // 
            this.dgvQuocTich.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQuocTich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuocTich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuocTich,
            this.TenQuocTich});
            this.dgvQuocTich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuocTich.Location = new System.Drawing.Point(2, 76);
            this.dgvQuocTich.Name = "dgvQuocTich";
            this.dgvQuocTich.Size = new System.Drawing.Size(946, 551);
            this.dgvQuocTich.TabIndex = 0;
            this.dgvQuocTich.SelectionChanged += new System.EventHandler(this.dgvQuocTich_SelectionChanged);
            // 
            // MaQuocTich
            // 
            this.MaQuocTich.DataPropertyName = "MaQuocTich";
            this.MaQuocTich.HeaderText = "Mã quốc tịch";
            this.MaQuocTich.Name = "MaQuocTich";
            this.MaQuocTich.Visible = false;
            // 
            // TenQuocTich
            // 
            this.TenQuocTich.DataPropertyName = "TenQuocTich";
            this.TenQuocTich.HeaderText = "Tên quốc tịch";
            this.TenQuocTich.Name = "TenQuocTich";
            this.TenQuocTich.Width = 400;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.txtQuocTich);
            this.panelHeader.Controls.Add(this.textBox4);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(2, 29);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(946, 47);
            this.panelHeader.TabIndex = 4;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.EditValue = "";
            this.txtQuocTich.Location = new System.Drawing.Point(77, 13);
            this.txtQuocTich.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(366, 20);
            this.txtQuocTich.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(10, 16);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 14);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Quốc tịch";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonStatusBar1.ItemLinks.Add(this.btnThem);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnSua);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnXoa);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnLamMoi);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(2, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(946, 27);
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
            this.ribbonControl1.Location = new System.Drawing.Point(448, 254);
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
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // KhaiBaoQuocTich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 629);
            this.Controls.Add(this.panelBody);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhaiBaoQuocTich";
            this.Text = "KhaiBaoDanToc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuocTich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuocTich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraEditors.PanelControl panelHeader;
        private DevExpress.XtraEditors.TextEdit txtQuocTich;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgvQuocTich;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuocTich;
    }
}