using ATINTimekeeping.Common;
using ATINTimekeeping.Manager;
using ATINTimekeeping.Model;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ATINTimekeeping.FormNhanVien
{
    public partial class QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private string mHoTen = "";
        private int mMaNguoi = 0;
        private int mMaPhongBan = 0;

        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadPhongBanTimKiem();
            LoadPhongBanChiTietNV();
            LoadChucVuNV();
            LoadGioiTinhNV();
            LoadTrangThaiNV();
            LoadTinhTrangHonNhanNV();
        }

        private void treeListLookUpPhongBan_EditValueChanged(object sender, EventArgs e)
        {
            var maPhongBan = treeListPhongBan.FocusedNode.GetValue("MaPhongBan").ToString();
            mMaPhongBan = Utils.StringToInt(maPhongBan);
            treeListPhongBan.FocusedNode.StateImageIndex = 0;
            treeListLookUpPhongBan.RefreshEditValue();
            TimKiemNhanVien();
        }

        private void treeListLookUpPhongBanNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var maPhongBan = treeListPhongBan.FocusedNode.GetValue("MaPhongBan").ToString();            
            mMaPhongBan = Utils.StringToInt(maPhongBan);
            mHoTen = txtMaDinhDanh.Text;
            TimKiemNhanVien();
        }


        /*
         * Icon cho dropdow treeview
         **/
        private void treeListPhongBan_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            TreeListNode treeListNode = treeListPhongBan.FocusedNode;
            if (treeListNode == null)
            {
                e.NodeImageIndex = 1;
                return;
            }

            int maPhongBan = Utils.StringToInt(treeListNode.GetValue("MaPhongBan").ToString());
            int index = int.Parse(e.Node.GetValue("MaPhongBan").ToString());
            if (maPhongBan == index)
                e.NodeImageIndex = 0;
            else
                e.NodeImageIndex = 1;
        }

        private void LoadPhongBanTimKiem()
        {
            List<PhongBan> listPhongBan = PhongBanManager.Instance.GetAllPhongBan();
            DataTable tblPhongBan = Utils.ToDataTable(listPhongBan);

            treeListLookUpPhongBan.Properties.AutoExpandAllNodes = true;
            treeListLookUpPhongBan.Properties.DataSource = tblPhongBan;
            treeListLookUpPhongBan.Properties.ValueMember = "MaPhongBan";
            treeListLookUpPhongBan.Properties.DisplayMember = "TenPhongBan";

            treeListPhongBan.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView;
            treeListPhongBan.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.True;
            treeListPhongBan.ExpandAll();

            ////Test
            //treeListPhongBan.BeginUpdate();
            //try
            //{
            //    List<TreeListNode> listTreeNode = treeListLookUpPhongBanTreeList.GetNodeList();
            //    listTreeNode.ForEach(node => {
            //        if (node.GetValue("MaPhongBan").ToString() == "12")
            //            treeListLookUpPhongBanTreeList.FocusedNode = node;
            //    }) ;
            //    treeListLookUpPhongBan.RefreshEditValue();
            //}
            //finally
            //{
            //    treeListPhongBan.EndUpdate();
            //}
        }

        private void LoadPhongBanChiTietNV()
        {
            List<PhongBan> listPhongBan = PhongBanManager.Instance.GetAllPhongBan();
            DataTable tblPhongBan = Utils.ToDataTable(listPhongBan);

            treeListLookUpPhongBanNV.Properties.AutoExpandAllNodes = true;
            treeListLookUpPhongBanNV.Properties.DataSource = tblPhongBan;
            treeListLookUpPhongBanNV.Properties.ValueMember = "MaPhongBan";
            treeListLookUpPhongBanNV.Properties.DisplayMember = "TenPhongBan";

            treeListPhongBanNV.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView;
            treeListPhongBanNV.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.True;
            treeListPhongBanNV.ExpandAll();
        }

        private void TimKiemNhanVien()
        {
            try
            {
                lvNhanVien.Clear();

                List<Nguoi> listNguoi = new List<Nguoi>();
                listNguoi = NguoiManager.Instance.GetNguoi(mMaNguoi, mHoTen, mMaPhongBan);
                listNguoi.ForEach(nguoi => {
                    ListViewItem item = new ListViewItem();
                    item.Tag = nguoi.MaNguoi;
                    item.Text = nguoi.HoTen;
                    lvNhanVien.Items.Add(item);
                });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void lvNhanVien_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvNhanVien.SelectedItems)
            {
                int maNguoi = (int) item.Tag;
                MessageBox.Show("" + maNguoi);
            }            
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            getNguoiTuForm();
        }

        private void getNguoiTuForm()
        {
            string maDinhDanh = txtMaDinhDanh.Text;
            string hoTen = txtHoTen.Text;
            int maPhongBan = getMaPhongBanNV();
            //int maChucVu = Utils.GetComboboxValue(cbxChucVu.SelectedValue);
            DateTime ngayNhanViec = dpkNgayNhanViec.Value.Date;
            DateTime ngaySinh = dpkNgaySinh.Value.Date;
            string soTheCanCuoc = txtSoTheCanCuoc.Text;
            DateTime ngayCapTCC = dpkNgayCapTCC.Value.Date;
            string noiCapTCC = txtNoiCapTCC.Text;
            //int maGioiTinh = Utils.GetComboboxValue(cbxGioiTinh.SelectedValue);
            //int maTinhTrangHonNhan = Utils.GetComboboxValue(cbxTTHonNhan.SelectedValue);
            //int maTrinhDoHocVan = Utils.GetComboboxValue(cbxTrinhDoHocVan.SelectedValue);
            //int maDanToc = Utils.GetComboboxValue(cbxDanToc.SelectedValue);
            //int maTonGiao = Utils.GetComboboxValue(cbxTonGiao.SelectedValue);
            //int maQuocTich = Utils.GetComboboxValue(cbxQuocTich.SelectedValue);
            string diaChiThuongTru = txtDiaChiThuongTru.Text;
            string diaChiTamTru = txtDiaChiTamTru.Text;
            string email = txtDiaChiEmail.Text;
            string soDienThoai = txtSoDienThoai.Text;
            bool suDungKhuonMat = Utils.GetRadidoCheckboxValue(radSuDungKhuonMat.Checked);
            bool suDungTheTu = Utils.GetRadidoCheckboxValue(radSuDungTheTu.Checked);
            bool suDungVanTay = Utils.GetRadidoCheckboxValue(radSuDungVanTay.Checked);
            string ghiChu = txtGhiChu.Text;
            int trangThaoHoatDong = Utils.GetComboboxValue(cbxTrangThai.SelectedValue);

            Nguoi nguoi = new Nguoi();
            nguoi.HoTen = hoTen;
            nguoi.MaDinhDanh = maDinhDanh;
            nguoi.MaPhongBan = maPhongBan;
            //nguoi.MaChucVu = maChucVu;
            //nguoi.NgayNhanViec = ngayNhanViec;
            //nguoi.NgaySinh = ngaySinh;
            //nguoi.SoTheCanCuoc = soTheCanCuoc;
            //nguoi.NgayCapTCC = ngayCapTCC;
            //nguoi.NoiCapTCC = noiCapTCC;
            //nguoi.MaGioiTinh = maGioiTinh;
            //nguoi.TinhTrangHonNhan = maTinhTrangHonNhan;
            //nguoi.MaTrinhDo = maTrinhDoHocVan;
            //nguoi.MaDanToc = maDanToc;
            //nguoi.MaTonGiao = maTonGiao;
            //nguoi.MaQuocTich = maQuocTich;
            nguoi.DiaChiThuongTru = diaChiThuongTru;
            nguoi.DiaChiTamTru = diaChiTamTru;
            nguoi.Email = email;
            nguoi.SoDienThoai = soDienThoai;
            nguoi.SuDungKhuonMat = suDungKhuonMat;
            nguoi.SuDungTheTu = suDungTheTu;
            nguoi.SuDungVanTay = suDungVanTay;
            nguoi.GhiChu = ghiChu;
            nguoi.TrangThaiHoatDong = trangThaoHoatDong;

            int maNguoi = NguoiManager.Instance.AddNguoi(nguoi);
        }

        private int getMaPhongBanNV()
        {
            var maPhongBanNV = treeListPhongBanNV.FocusedNode.GetValue("MaPhongBan").ToString();
            return Utils.StringToInt(maPhongBanNV);
        }

        private void LoadChucVuNV()
        {
            List<ChucVu> listChucVu = ChucVuManager.Instance.GetAllChucVu();
            cbxChucVu.DataSource = listChucVu;
            cbxChucVu.ValueMember = "MaChucVu";
            cbxChucVu.DisplayMember = "TenChucVu";
        }

        private void LoadGioiTinhNV()
        {
            List<GioiTinh> listGioiTinh = GioiTinhManager.Instance.GetAllGioiTinh();
            cbxGioiTinh.DataSource = listGioiTinh;
            cbxGioiTinh.ValueMember = "MaGioiTinh";
            cbxGioiTinh.DisplayMember = "TenGioiTinh";
        }

        private void LoadTrangThaiNV()
        {
            List<TrangThai> listTrangThai = TrangThaiManager.Instance.GetAllTrangThai("PERSON_AVAILABLE_STATUS");
            cbxTrangThai.DataSource = listTrangThai;
            cbxTrangThai.ValueMember = "GiaTri";
            cbxTrangThai.DisplayMember = "TenTrangThai";
        }

        private void LoadTinhTrangHonNhanNV()
        {
            List<TrangThai> listTrangThai = TrangThaiManager.Instance.GetAllTrangThai("PERSON_MARITAL_STATUS");
            //cbxTTHonNhan.DataSource = listTrangThai;
            //cbxTTHonNhan.ValueMember = "GiaTri";
            //cbxTTHonNhan.DisplayMember = "TenTrangThai";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDiaChiThuongTru_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void pboxFace1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pboxFace1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void txtDiaChiEmail_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pbxAnhDaiDien_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbxAnhDaiDien.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void pboxFace2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pboxFace2.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void pboxFace3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pboxFace3.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
