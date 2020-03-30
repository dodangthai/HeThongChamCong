namespace ATINTimekeeping
{
    partial class TaiDuLieuChamCongFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiDuLieuChamCongFrm));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnLoc = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnLuuTapTin = new System.Windows.Forms.Button();
            this.btnLuuVaoCoSoDuLieu = new System.Windows.Forms.Button();
            this.btnDuyetTapTin = new System.Windows.Forms.Button();
            this.btnDuyetTuMayChamCong = new System.Windows.Forms.Button();
            this.cbTatCaCacMay = new System.Windows.Forms.ComboBox();
            this.cbKieuTaiThongThuong = new System.Windows.Forms.ComboBox();
            this.cbLuuNgaySauKhiTai = new System.Windows.Forms.CheckBox();
            this.dateEdit3 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clMaChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.ribbonStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonStatusBar.ItemLinks.Add(this.barEditItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 0);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1276, 33);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Chọn máy";
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.EditWidth = 150;
            this.barEditItem1.Id = 1;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barEditItem1,
            this.barButtonItem1,
            this.barStaticItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(1044, 414);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.ribbonControl1.Size = new System.Drawing.Size(75, 183);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar;
            this.ribbonControl1.Visible = false;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 889);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl3);
            this.panel1.Controls.Add(this.btnLuuTapTin);
            this.panel1.Controls.Add(this.btnLuuVaoCoSoDuLieu);
            this.panel1.Controls.Add(this.btnDuyetTapTin);
            this.panel1.Controls.Add(this.btnDuyetTuMayChamCong);
            this.panel1.Controls.Add(this.cbTatCaCacMay);
            this.panel1.Controls.Add(this.cbKieuTaiThongThuong);
            this.panel1.Controls.Add(this.cbLuuNgaySauKhiTai);
            this.panel1.Controls.Add(this.dateEdit3);
            this.panel1.Controls.Add(this.dateEdit2);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 144);
            this.panel1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnLoc);
            this.groupControl3.Controls.Add(this.textBox8);
            this.groupControl3.Controls.Add(this.label22);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl3.Location = new System.Drawing.Point(551, 10);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(207, 111);
            this.groupControl3.TabIndex = 23;
            this.groupControl3.Text = "Lọc";
            // 
            // btnLoc
            // 
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.Location = new System.Drawing.Point(145, 51);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(33, 25);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(5, 52);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(132, 23);
            this.textBox8.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 28);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 17);
            this.label22.TabIndex = 0;
            this.label22.Text = "Mã chấm công";
            // 
            // btnLuuTapTin
            // 
            this.btnLuuTapTin.Location = new System.Drawing.Point(785, 91);
            this.btnLuuTapTin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuTapTin.Name = "btnLuuTapTin";
            this.btnLuuTapTin.Size = new System.Drawing.Size(201, 31);
            this.btnLuuTapTin.TabIndex = 22;
            this.btnLuuTapTin.Text = "Lưu tập tin";
            this.btnLuuTapTin.UseVisualStyleBackColor = true;
            // 
            // btnLuuVaoCoSoDuLieu
            // 
            this.btnLuuVaoCoSoDuLieu.Location = new System.Drawing.Point(785, 56);
            this.btnLuuVaoCoSoDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuVaoCoSoDuLieu.Name = "btnLuuVaoCoSoDuLieu";
            this.btnLuuVaoCoSoDuLieu.Size = new System.Drawing.Size(201, 27);
            this.btnLuuVaoCoSoDuLieu.TabIndex = 21;
            this.btnLuuVaoCoSoDuLieu.Text = "Lưu vào cơ sở dữ liệu";
            this.btnLuuVaoCoSoDuLieu.UseVisualStyleBackColor = true;
            // 
            // btnDuyetTapTin
            // 
            this.btnDuyetTapTin.Location = new System.Drawing.Point(785, 20);
            this.btnDuyetTapTin.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuyetTapTin.Name = "btnDuyetTapTin";
            this.btnDuyetTapTin.Size = new System.Drawing.Size(201, 28);
            this.btnDuyetTapTin.TabIndex = 20;
            this.btnDuyetTapTin.Text = "Duyệt tập tin";
            this.btnDuyetTapTin.UseVisualStyleBackColor = true;
            // 
            // btnDuyetTuMayChamCong
            // 
            this.btnDuyetTuMayChamCong.Location = new System.Drawing.Point(343, 84);
            this.btnDuyetTuMayChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuyetTuMayChamCong.Name = "btnDuyetTuMayChamCong";
            this.btnDuyetTuMayChamCong.Size = new System.Drawing.Size(201, 37);
            this.btnDuyetTuMayChamCong.TabIndex = 19;
            this.btnDuyetTuMayChamCong.Text = "Duyệt từ máy chấm công";
            this.btnDuyetTuMayChamCong.UseVisualStyleBackColor = true;
            // 
            // cbTatCaCacMay
            // 
            this.cbTatCaCacMay.FormattingEnabled = true;
            this.cbTatCaCacMay.Location = new System.Drawing.Point(343, 51);
            this.cbTatCaCacMay.Margin = new System.Windows.Forms.Padding(4);
            this.cbTatCaCacMay.Name = "cbTatCaCacMay";
            this.cbTatCaCacMay.Size = new System.Drawing.Size(200, 24);
            this.cbTatCaCacMay.TabIndex = 18;
            // 
            // cbKieuTaiThongThuong
            // 
            this.cbKieuTaiThongThuong.FormattingEnabled = true;
            this.cbKieuTaiThongThuong.Location = new System.Drawing.Point(343, 22);
            this.cbKieuTaiThongThuong.Margin = new System.Windows.Forms.Padding(4);
            this.cbKieuTaiThongThuong.Name = "cbKieuTaiThongThuong";
            this.cbKieuTaiThongThuong.Size = new System.Drawing.Size(200, 24);
            this.cbKieuTaiThongThuong.TabIndex = 17;
            // 
            // cbLuuNgaySauKhiTai
            // 
            this.cbLuuNgaySauKhiTai.AutoSize = true;
            this.cbLuuNgaySauKhiTai.Location = new System.Drawing.Point(14, 100);
            this.cbLuuNgaySauKhiTai.Margin = new System.Windows.Forms.Padding(4);
            this.cbLuuNgaySauKhiTai.Name = "cbLuuNgaySauKhiTai";
            this.cbLuuNgaySauKhiTai.Size = new System.Drawing.Size(157, 21);
            this.cbLuuNgaySauKhiTai.TabIndex = 16;
            this.cbLuuNgaySauKhiTai.Text = "Lưu ngay sau khi tải";
            this.cbLuuNgaySauKhiTai.UseVisualStyleBackColor = true;
            // 
            // dateEdit3
            // 
            this.dateEdit3.EditValue = null;
            this.dateEdit3.Location = new System.Drawing.Point(91, 52);
            this.dateEdit3.Margin = new System.Windows.Forms.Padding(4);
            this.dateEdit3.Name = "dateEdit3";
            this.dateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit3.Size = new System.Drawing.Size(228, 22);
            this.dateEdit3.TabIndex = 15;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(91, 23);
            this.dateEdit2.Margin = new System.Windows.Forms.Padding(4);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(228, 22);
            this.dateEdit2.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 55);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "Đến ngày";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 26);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 17);
            this.label20.TabIndex = 12;
            this.label20.Text = "Từ ngày";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1270, 733);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaChamCong,
            this.clNgay,
            this.clGio,
            this.clLoai,
            this.clNguon,
            this.clTenMay,
            this.clMaLV});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(304, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(962, 725);
            this.dataGridView2.TabIndex = 1;
            // 
            // clMaChamCong
            // 
            this.clMaChamCong.HeaderText = "Mã chấm công";
            this.clMaChamCong.MinimumWidth = 6;
            this.clMaChamCong.Name = "clMaChamCong";
            this.clMaChamCong.Width = 80;
            // 
            // clNgay
            // 
            this.clNgay.HeaderText = "Ngày";
            this.clNgay.MinimumWidth = 6;
            this.clNgay.Name = "clNgay";
            this.clNgay.Width = 80;
            // 
            // clGio
            // 
            this.clGio.HeaderText = "Giờ";
            this.clGio.MinimumWidth = 6;
            this.clGio.Name = "clGio";
            this.clGio.Width = 80;
            // 
            // clLoai
            // 
            this.clLoai.HeaderText = "Loại";
            this.clLoai.MinimumWidth = 6;
            this.clLoai.Name = "clLoai";
            this.clLoai.Width = 50;
            // 
            // clNguon
            // 
            this.clNguon.HeaderText = "Nguồn";
            this.clNguon.MinimumWidth = 6;
            this.clNguon.Name = "clNguon";
            this.clNguon.Width = 50;
            // 
            // clTenMay
            // 
            this.clTenMay.HeaderText = "Tên máy";
            this.clTenMay.MinimumWidth = 6;
            this.clTenMay.Name = "clTenMay";
            this.clTenMay.Width = 125;
            // 
            // clMaLV
            // 
            this.clMaLV.HeaderText = "Mã LV";
            this.clMaLV.MinimumWidth = 6;
            this.clMaLV.Name = "clMaLV";
            this.clMaLV.Width = 80;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 727);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Làm tươi";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "| Phiên bản SDK : ???????";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // TaiDuLieuChamCongFrm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 922);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaiDuLieuChamCongFrm";
            this.Text = "TaiDuLieuChamCongFrm";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnLuuTapTin;
        private System.Windows.Forms.Button btnLuuVaoCoSoDuLieu;
        private System.Windows.Forms.Button btnDuyetTapTin;
        private System.Windows.Forms.Button btnDuyetTuMayChamCong;
        private System.Windows.Forms.ComboBox cbTatCaCacMay;
        private System.Windows.Forms.ComboBox cbKieuTaiThongThuong;
        private System.Windows.Forms.CheckBox cbLuuNgaySauKhiTai;
        private DevExpress.XtraEditors.DateEdit dateEdit3;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLV;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}