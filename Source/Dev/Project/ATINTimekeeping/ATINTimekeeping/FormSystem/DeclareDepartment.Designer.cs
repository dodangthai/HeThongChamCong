namespace ATINTimekeeping.FormSystem
{
    partial class DeclareDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeclareDepartment));
            DevExpress.Utils.SimpleContextButton simpleContextButton1 = new DevExpress.Utils.SimpleContextButton();
            DevExpress.Utils.SimpleContextButton simpleContextButton2 = new DevExpress.Utils.SimpleContextButton();
            DevExpress.Utils.SimpleContextButton simpleContextButton3 = new DevExpress.Utils.SimpleContextButton();
            DevExpress.Utils.SimpleContextButton simpleContextButton4 = new DevExpress.Utils.SimpleContextButton();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Khai báo phòng ban");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Văn phòng");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ATI", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnModifyDepartment = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteDepartment = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemPageNumberEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddDepartment = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.ribbonStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonStatusBar.ItemLinks.Add(this.btnAddDepartment);
            this.ribbonStatusBar.ItemLinks.Add(this.btnModifyDepartment);
            this.ribbonStatusBar.ItemLinks.Add(this.btnDeleteDepartment);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 0);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar.Size = new System.Drawing.Size(815, 27);
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.Sorted = true;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // btnModifyDepartment
            // 
            this.btnModifyDepartment.Caption = "Sửa";
            this.btnModifyDepartment.Id = 17;
            this.btnModifyDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnModifyDepartment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnModifyDepartment.Name = "btnModifyDepartment";
            this.btnModifyDepartment.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Caption = "Xóa";
            this.btnDeleteDepartment.Id = 18;
            this.btnDeleteDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btnDeleteDepartment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barStaticItem1,
            this.btnModifyDepartment,
            this.btnDeleteDepartment,
            this.btnAddDepartment});
            this.ribbonControl1.Location = new System.Drawing.Point(747, 294);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemPageNumberEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.ribbonControl1.Size = new System.Drawing.Size(56, 150);
            this.ribbonControl1.Visible = false;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
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
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton1.Caption = "simpleContextButton1";
            simpleContextButton1.Id = new System.Guid("26c621ca-edf5-493d-87c0-d493bb8971e8");
            simpleContextButton1.Name = "simpleContextButton1";
            simpleContextButton2.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton2.Caption = "simpleContextButton2";
            simpleContextButton2.Id = new System.Guid("4c88a00b-7ab8-4e37-ac1a-4dfda8e9f417");
            simpleContextButton2.Name = "simpleContextButton2";
            simpleContextButton3.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton3.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton3.Caption = "simpleContextButton3";
            simpleContextButton3.Id = new System.Guid("a1061c1d-5c86-4b5b-bd65-709fd272856b");
            simpleContextButton3.Name = "simpleContextButton3";
            simpleContextButton4.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton4.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton4.Caption = "simpleContextButton4";
            simpleContextButton4.Id = new System.Guid("3b699355-9cdc-4ad4-ae31-227fab1ed25c");
            simpleContextButton4.Name = "simpleContextButton4";
            this.repositoryItemComboBox1.ContextButtons.Add(simpleContextButton1);
            this.repositoryItemComboBox1.ContextButtons.Add(simpleContextButton2);
            this.repositoryItemComboBox1.ContextButtons.Add(simpleContextButton3);
            this.repositoryItemComboBox1.ContextButtons.Add(simpleContextButton4);
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // repositoryItemPageNumberEdit1
            // 
            this.repositoryItemPageNumberEdit1.AutoHeight = false;
            this.repositoryItemPageNumberEdit1.Mask.EditMask = "########;";
            this.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "Chọn lịch trình";
            this.barEditItem4.Edit = this.repositoryItemComboBox2;
            this.barEditItem4.EditWidth = 150;
            this.barEditItem4.Id = 7;
            this.barEditItem4.Name = "barEditItem4";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thực hiện";
            this.barButtonItem4.Id = 15;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Caption = "Thêm";
            this.btnAddDepartment.Id = 19;
            this.btnAddDepartment.Name = "btnAddDepartment";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(815, 473);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(540, 473);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Khai báo phòng ban";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Văn phòng";
            treeNode3.Name = "Node1";
            treeNode3.Text = "ATI";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(271, 473);
            this.treeView1.TabIndex = 1;
            // 
            // DeclareDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 500);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeclareDepartment";
            this.Text = "PrepareEmployeeCalenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeclareDepartment_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem btnModifyDepartment;
        private DevExpress.XtraBars.BarButtonItem btnDeleteDepartment;
        private DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit repositoryItemPageNumberEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnAddDepartment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}