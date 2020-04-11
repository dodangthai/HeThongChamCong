using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ATINTimekeeping.FormTimeKeepingSetting;
using ATINTimekeeping.ChamCongVaBaoBieu;
using ATINTimekeeping.FormHeThong;
using ATINTimekeeping.FormNhanVien;

namespace ATINTimekeeping
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void btnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnThongTinCongTy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongTinCongTy form = new ThongTinCongTy();
            form.MdiParent = this;
            form.Show();
        }

        private void btnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhaiBaoPhongBan form = new KhaiBaoPhongBan();
            form.MdiParent = this;
            form.Show();
        }

        private void btnChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhaiBaoChucVu form = new KhaiBaoChucVu();
            form.MdiParent = this;
            form.Show();
        }

        private void btnDanToc_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhaiBaoDanToc form = new KhaiBaoDanToc();
            form.MdiParent = this;
            form.Show();
        }

        private void btnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhaiBaoTonGiao form = new KhaiBaoTonGiao();
            form.MdiParent = this;
            form.Show();
        }

        private void btnTrinhDo_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhaiBaoTrinhDoHocVan form = new KhaiBaoTrinhDoHocVan();
            form.MdiParent = this;
            form.Show();
        }

        private void btnNgayLe_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhaiBaoNgayLe form = new KhaiBaoNgayLe();
            form.MdiParent = this;
            form.Show();
        }

        private void btnQuocTich_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhaiBaoQuocTich form = new KhaiBaoQuocTich();
            form.MdiParent = this;
            form.Show();
        }

        private void btnDatabase_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnManagerEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyNhanVien form = new QuanLyNhanVien();
            form.MdiParent = this;
            form.Show();
        }
    }
}