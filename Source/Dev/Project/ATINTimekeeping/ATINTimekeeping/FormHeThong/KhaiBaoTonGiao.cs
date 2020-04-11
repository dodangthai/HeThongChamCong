using ATINTimekeeping.Manager;
using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATINTimekeeping.FormHeThong
{
    public partial class KhaiBaoTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public KhaiBaoTonGiao()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void dgvTonGiao_SelectionChanged(object sender, EventArgs e)
        {
            TonGiao tonGiao = getRowLeSelected();
            if (tonGiao != null)
            {
                fillForm(tonGiao);
            }
        }

        private TonGiao getRowLeSelected()
        {
            var rowsCount = dgvTonGiao.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return null;

            var row = dgvTonGiao.SelectedRows[0];
            if (row == null) return null;

            return (TonGiao) row.DataBoundItem;
        }

        private void fillForm(TonGiao tonGiao)
        {
            txtTonGiao.Text = tonGiao.TenTonGiao;
        }

        private TonGiao GetInputForm()
        {
            TonGiao tonGiao = new TonGiao();
            tonGiao.TenTonGiao = txtTonGiao.Text;
            return tonGiao;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TonGiao tonGiao = GetInputForm();
            TonGiaoManager.Instance.AddTonGiao(tonGiao);
            RefreshForm();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TonGiao tonGiao = getRowLeSelected();
            if (tonGiao == null)
            {
                MessageBox.Show("Bạn chưa chọn tôn giáo cần sửa.");
                return;
            }

            int maTonGiao = tonGiao.MaTonGiao;
            if (maTonGiao == 0)
            {
                MessageBox.Show("Bạn chưa chọn tôn giáo cần sửa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn lưu thông tin đã sửa?", "ATIN Smartface - Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                TonGiao tonGiaoUpdate = GetInputForm();
                tonGiaoUpdate.MaTonGiao = maTonGiao;

                TonGiaoManager.Instance.UpdateTonGiao(tonGiaoUpdate);
                RefreshForm(); ;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TonGiao tonGiao = getRowLeSelected();
            if (tonGiao == null)
            {
                MessageBox.Show("Bạn chưa chọn tôn giáo cần xóa.");
                return;
            }

            int maTonGiao = tonGiao.MaTonGiao;
            if (maTonGiao == 0)
            {
                MessageBox.Show("Bạn chưa chọn tôn giáo cần xóa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn xóa bản ghi đã chọn?", "ATIN Smartface - Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                TonGiaoManager.Instance.DeleteTonGiao(maTonGiao);
                RefreshForm();
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<TonGiao> listTonGiao = TonGiaoManager.Instance.GetAllTonGiao();
            dgvTonGiao.DataSource = listTonGiao;
        }
    }
}