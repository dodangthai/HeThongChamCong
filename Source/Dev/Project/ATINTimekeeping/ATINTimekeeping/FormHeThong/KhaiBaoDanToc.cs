using ATINTimekeeping.Manager;
using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATINTimekeeping.FormHeThong
{
    public partial class KhaiBaoDanToc : DevExpress.XtraEditors.XtraForm
    {
        public KhaiBaoDanToc()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<DanToc> listDanToc = DanTocManager.Instance.GetAllDanToc();
            dgvDanToc.DataSource = listDanToc;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanToc danToc = GetInputForm();
            DanTocManager.Instance.AddDanToc(danToc);
            RefreshForm();
        }

        private void dgvDanToc_SelectionChanged(object sender, EventArgs e)
        {
            DanToc danToc = getRowLeSelected();
            if (danToc != null)
            {
                fillForm(danToc);
            }
        }

        private DanToc getRowLeSelected()
        {
            var rowsCount = dgvDanToc.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return null;

            var row = dgvDanToc.SelectedRows[0];
            if (row == null) return null;

            return (DanToc)row.DataBoundItem;
        }

        private void fillForm(DanToc danToc)
        {
            txtDanToc.Text = danToc.TenDanToc;
        }

        private DanToc GetInputForm()
        {
            DanToc danToc = new DanToc();
            danToc.TenDanToc = txtDanToc.Text;
            return danToc;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanToc danToc = getRowLeSelected();
            if (danToc == null)
            {
                MessageBox.Show("Bạn chưa chọn dân tộc cần xóa.");
                return;
            }

            int maDanToc = danToc.MaDanToc;
            if (maDanToc == 0)
            {
                MessageBox.Show("Bạn chưa chọn dân tộc cần xóa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn xóa dân tộc đã chọn?", "ATIN Smartface - Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DanTocManager.Instance.DeleteDanToc(maDanToc);
                RefreshForm();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanToc danToc = getRowLeSelected();
            if (danToc == null)
            {
                MessageBox.Show("Bạn chưa chọn dân tộc cần sửa.");
                return;
            }

            int maDanToc = danToc.MaDanToc;
            if (maDanToc == 0)
            {
                MessageBox.Show("Bạn chưa chọn dân tộc cần sửa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn lưu thông tin đã sửa?", "ATIN Smartface - Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DanToc danTocUpdate = GetInputForm();
                danTocUpdate.MaDanToc = maDanToc;

                DanTocManager.Instance.UpdateDanToc(danTocUpdate);
                RefreshForm(); ;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshForm();
        }
    }
}