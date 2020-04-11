using ATINTimekeeping.Manager;
using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATINTimekeeping.FormHeThong
{
    public partial class KhaiBaoTrinhDoHocVan : DevExpress.XtraEditors.XtraForm
    {
        public KhaiBaoTrinhDoHocVan()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<DanToc> listDanToc = DanTocManager.Instance.GetAllDanToc();
            dgvTrinhDoHocVan.DataSource = listDanToc;
        }

        private void dgvTrinhDoHocVan_SelectionChanged(object sender, EventArgs e)
        {
            TrinhDoHocVan trinhDoHocVan = getRowLeSelected();
            if (trinhDoHocVan != null)
            {
                fillForm(trinhDoHocVan);
            }
        }

        private TrinhDoHocVan getRowLeSelected()
        {
            var rowsCount = dgvTrinhDoHocVan.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return null;

            var row = dgvTrinhDoHocVan.SelectedRows[0];
            if (row == null) return null;

            return (TrinhDoHocVan)row.DataBoundItem;
        }

        private void fillForm(TrinhDoHocVan trinhDoHocVan)
        {
            txtTrinhDoHocVan.Text = trinhDoHocVan.TenTrinhDoHocVan;
        }

        private TrinhDoHocVan GetInputForm()
        {
            TrinhDoHocVan trinhDoHocVan = new TrinhDoHocVan();
            trinhDoHocVan.TenTrinhDoHocVan = txtTrinhDoHocVan.Text;
            return trinhDoHocVan;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TrinhDoHocVan trinhDoHocVan = GetInputForm();
            TrinhDoHocVanManager.Instance.AddTrinhDoHocVan(trinhDoHocVan);
            RefreshForm();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TrinhDoHocVan trinhDoHocVan = getRowLeSelected();
            if (trinhDoHocVan == null)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi cần sửa.");
                return;
            }

            int maTrinhDoHocVan = trinhDoHocVan.MaTrinhDoHocVan;
            if (maTrinhDoHocVan == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi cần sửa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn lưu thông tin đã sửa?", "ATIN Smartface - Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                TrinhDoHocVan trinhDoHocVanUpdate = GetInputForm();
                trinhDoHocVanUpdate.MaTrinhDoHocVan = maTrinhDoHocVan;
                TrinhDoHocVanManager.Instance.UpdateTrinhDoHocVan(trinhDoHocVanUpdate);
                RefreshForm();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TrinhDoHocVan trinhDoHocVan = getRowLeSelected();
            if (trinhDoHocVan == null)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi cần xóa.");
                return;
            }

            int maTrinhDoHocVan = trinhDoHocVan.MaTrinhDoHocVan;
            if (maTrinhDoHocVan == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi cần xóa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn xóa bản ghi đã chọn?", "ATIN Smartface - Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                TrinhDoHocVanManager.Instance.DeleteTrinhDoHocVan(maTrinhDoHocVan);
                RefreshForm();
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshForm();
        }
    }
}