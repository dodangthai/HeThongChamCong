using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.Design;
using ATINTimekeeping.FormTimeKeepingSetting;
using ATINTimekeeping.ChamCongVaBaoBieu;

namespace ATINTimekeeping
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            //EmployeeManagementForm form = new EmployeeManagementForm();
            //form.TopLevel = false;
            //DevExpress.XtraTab.XtraTabPage tab = new DevExpress.XtraTab.XtraTabPage();
            //tab.Text = form.Text;
            //form.Parent = tab;
            //xtraTabControl1.TabPages.Add(tab);
            //form.Show();

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("KhaiBaoMayChamCongFrm"))
            {
                KhaiBaoMayChamCongFrm form = new KhaiBaoMayChamCongFrm();
                form.MdiParent = this;
                form.Show();
            }
        }

        //public void themTabPage()
        //{
        //    KhaiBaoMayChamCongFrm khaiBaoMayChamCongFrm = new KhaiBaoMayChamCongFrm();
        //    TabPage tabPage = new TabPage { Text = khaiBaoMayChamCongFrm.Text };
        //    ribbonPageMayChamCong..Add(tabPage);
        //}

        private void xtraTabKhaiBaoMayChamCong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelKhaiBaoMayChamCong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtGwDanhSachMayChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRefreshTaiDuLieuChamCong_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiNhanVienVeMayTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("TaiNhanVienVeMayTinhFrm"))
            {
                TaiNhanVienVeMayTinhFrm form = new TaiNhanVienVeMayTinhFrm();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTaiDuLieuChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            //TaiDuLieuChamCongFrm taiDuLieuChamCongFrm = new TaiDuLieuChamCongFrm();


            //taiDuLieuChamCongFrm.Show();
            if (!CheckExistForm("TaiDuLieuChamCongFrm"))
            {
                TaiDuLieuChamCongFrm form = new TaiDuLieuChamCongFrm();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTaiNhanVienLenMayChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("TaiNhanVienTuMayTinhLenFrm"))
            {
                TaiNhanVienTuMayTinhLenFrm form = new TaiNhanVienTuMayTinhLenFrm();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnSelectTIme_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("SelectTime"))
            {
                SelectTime form = SelectTime.CreateInstance();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDeclareTheShift_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("DeclareTheShift"))
            {
                DeclareTheShift form = DeclareTheShift.CreateInstance();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDeclareWorkCalenda_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("DeclareWorkCalenda"))
            {
                DeclareWorkCalenda form = DeclareWorkCalenda.CreateInstance();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnPrepareEmployeeCalenda_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("PrepareEmployeeCalenda"))
            {
                PrepareEmployeeCalenda form = PrepareEmployeeCalenda.CreateInstance();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTimeKeepingSymbolcs_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("TimeKeepingSymbolcs"))
            {
                TimeKeepingSymbolcs form = TimeKeepingSymbolcs.CreateInstance();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnLayDaySmbol_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (LayDaySmbol.GetInstance() != null)
            {
                return;
            }
            else
            {
                LayDaySmbol.CreateInstance().ShowDialog();
            }
        }

        private void barButtonItem14_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("ChamCongTheoCa"))
            {
                ChamCongTheoCa form = new ChamCongTheoCa();
                form.MdiParent = this;
                form.Show();
            }
        }

        private Boolean CheckExistForm(String name)
        {
            bool check = false;
            foreach (Form form in this.MdiChildren)
            {
                if(form.Name == name)
                {
                    check = true;
                    form.Activate();
                }
            }
            return check;
        }

        private void barBtnDiemDanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            DiemDanh form = new DiemDanh();
            form.ShowDialog();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("ViewImage"))
            {
                ViewImage form = new ViewImage();
                form.MdiParent = this;
                form.Show();
            }
        }
    }


}