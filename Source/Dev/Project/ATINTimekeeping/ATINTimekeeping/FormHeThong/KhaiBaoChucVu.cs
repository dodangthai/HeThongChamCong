using ATINTimekeeping.Manager;
using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATINTimekeeping.FormHeThong
{
    public partial class KhaiBaoChucVu : DevExpress.XtraEditors.XtraForm
    {

        public KhaiBaoChucVu()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<ChucVu> listChucVu = ChucVuManager.Instance.GetAllChucVu();
            gvChucVu.DataSource = listChucVu;
        }

        private void gvChucVu_SelectionChanged(object sender, EventArgs e)
        {
            ChucVu chucVu = getRowLeSelected();
            if (chucVu != null)
            {
                fillForm(chucVu);
            }
        }

        private void fillForm(ChucVu chucVu)
        {
            txtTenChucVu.Text = chucVu.TenChucVu;
        }

        private ChucVu getRowLeSelected()
        {
            var rowsCount = gvChucVu.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return null;

            var row = gvChucVu.SelectedRows[0];
            if (row == null) return null;

            return (ChucVu) row.DataBoundItem;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChucVu chucVuMoi = GetFormInput();
            ChucVuManager.Instance.AddChucVu(chucVuMoi);
            RefreshForm();
        }

        private ChucVu GetFormInput()
        {
            ChucVu chucVu = new ChucVu();
            chucVu.TenChucVu = txtTenChucVu.Text;
            return chucVu;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChucVu chucVu = getRowLeSelected();
            if (chucVu == null)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ cần sửa.");
                return;
            }

            int maChucVu = chucVu.MaChucVu;
            if (maChucVu == 0)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ cần sửa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn lưu thông tin đã sửa?", "ATIN Smartface - Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                ChucVu ChucVuUpdate = GetFormInput();
                ChucVuUpdate.MaChucVu = maChucVu;

                ChucVuManager.Instance.UpdateChuVu(ChucVuUpdate);
                RefreshForm(); ;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChucVu chucVu = getRowLeSelected();
            if (chucVu == null)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ cần xóa.");
                return;
            }

            int maChucVu = chucVu.MaChucVu;
            if (maChucVu == 0)
            {
                MessageBox.Show("Bạn chưa chọn chức vụcần xóa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn xóa chức vụ đã chọn?", "ATIN Smartface - Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                ChucVuManager.Instance.DeleteChucVu(maChucVu);
                RefreshForm();
            }
        }
    }
}