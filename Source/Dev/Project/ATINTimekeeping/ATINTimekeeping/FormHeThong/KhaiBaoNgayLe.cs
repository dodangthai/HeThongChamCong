using ATINTimekeeping.Common;
using ATINTimekeeping.Manager;
using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATINTimekeeping.FormHeThong
{
    public partial class KhaiBaoNgayLe : DevExpress.XtraEditors.XtraForm
    {
        private static KhaiBaoNgayLe _instance;

        public static KhaiBaoNgayLe Instance
        {
            get
            {
                return _instance ?? (_instance = new KhaiBaoNgayLe());
            }
        }

        public KhaiBaoNgayLe()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<NgayNghiLe> listNgayNghiLe = NgayNghiLeManager.Instance.GetAllNgayNghiLe();
            gvNgayLe.DataSource = listNgayNghiLe;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NgayNghiLe ngayNghiLe = GetInputForm();
            NgayNghiLeManager.Instance.AddNgayNghiLe(ngayNghiLe);
            RefreshForm();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshForm();
        }

        private void gvNgayLe_SelectionChanged(object sender, EventArgs e)
        {
            NgayNghiLe ngayNghiLe = getRowLeSelected();
            if (ngayNghiLe != null)
            {
                fillForm(ngayNghiLe);
            }
        }

        private NgayNghiLe getRowLeSelected()
        {
            var rowsCount = gvNgayLe.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return null;

            var row = gvNgayLe.SelectedRows[0];
            if (row == null) return null;

            return (NgayNghiLe)row.DataBoundItem;
        }

        private void fillForm(NgayNghiLe ngayNghiLe)
        {
            txtTenNgayLe.Text = ngayNghiLe.TenNgayNghiLe;
            dpkNgayLe.Value = ngayNghiLe.NgayLe;
        }

        private NgayNghiLe GetInputForm()
        {
            NgayNghiLe ngayNghiLe = new NgayNghiLe();
            ngayNghiLe.TenNgayNghiLe = txtTenNgayLe.Text;
            ngayNghiLe.NgayLe = dpkNgayLe.Value.Date;
            return ngayNghiLe;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NgayNghiLe ngayNghiLe = getRowLeSelected();
            if (ngayNghiLe == null)
            {
                MessageBox.Show("Bạn chưa chọn ngày lễ cần xóa.");
                return;
            }

            int maNgayNghiLe = ngayNghiLe.MaNgayNghiLe;
            if (maNgayNghiLe == 0)
            {
                MessageBox.Show("Bạn chưa chọn ngày lễ cần xóa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn xóa ngày lễ đã chọn?", "ATIN Smartface - Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                NgayNghiLeManager.Instance.DeleteNgayNghiLe(maNgayNghiLe);
                RefreshForm();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NgayNghiLe ngayNghiLe = getRowLeSelected();
            if (ngayNghiLe == null)
            {
                MessageBox.Show("Bạn chưa chọn ngày lễ cần sửa.");
                return;
            }

            int maNgayNghiLe = ngayNghiLe.MaNgayNghiLe;
            if (maNgayNghiLe == 0)
            {
                MessageBox.Show("Bạn chưa chọn ngày lễ cần sửa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn lưu thông tin đã sửa?", "ATIN Smartface - Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                NgayNghiLe ngayNghiLeUpdate = GetInputForm();
                ngayNghiLeUpdate.MaNgayNghiLe = maNgayNghiLe;

                NgayNghiLeManager.Instance.UpdateNgayNghiLe(ngayNghiLeUpdate);
                RefreshForm(); ;
            }
        }
    }
}