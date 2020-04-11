using ATINTimekeeping.Manager;
using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATINTimekeeping.FormHeThong
{
    public partial class KhaiBaoQuocTich : DevExpress.XtraEditors.XtraForm
    {
        public KhaiBaoQuocTich()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<QuocTich> listQuocTich = QuocTichManager.Instance.GetAllQuocTich();
            dgvQuocTich.DataSource = listQuocTich;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuocTich quocTich = GetInputForm();
            QuocTichManager.Instance.AddQuocTich(quocTich);
            RefreshForm();
        }

        private void dgvQuocTich_SelectionChanged(object sender, EventArgs e)
        {
            QuocTich quocTich = getRowLeSelected();
            if (quocTich != null)
            {
                fillForm(quocTich);
            }
        }

        private QuocTich getRowLeSelected()
        {
            var rowsCount = dgvQuocTich.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return null;

            var row = dgvQuocTich.SelectedRows[0];
            if (row == null) return null;

            return (QuocTich) row.DataBoundItem;
        }

        private void fillForm(QuocTich quocTich)
        {
            txtQuocTich.Text = quocTich.TenQuocTich;
        }

        private QuocTich GetInputForm()
        {
            QuocTich quocTich = new QuocTich();
            quocTich.TenQuocTich = txtQuocTich.Text;
            return quocTich;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuocTich quocTich = getRowLeSelected();
            if (quocTich == null)
            {
                MessageBox.Show("Bạn chưa chọn quốc tịch cần xóa.");
                return;
            }

            int maMaQuocTich = quocTich.MaQuocTich;
            if (maMaQuocTich == 0)
            {
                MessageBox.Show("Bạn chưa chọn quốc tịch cần xóa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn xóa quốc tịch đã chọn?", "ATIN Smartface - Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                QuocTichManager.Instance.DeleteQuocTich(maMaQuocTich);
                RefreshForm();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuocTich quocTich = getRowLeSelected();
            if (quocTich == null)
            {
                MessageBox.Show("Bạn chưa chọn quốc tịch cần sửa.");
                return;
            }

            int maQuocTich = quocTich.MaQuocTich;
            if (maQuocTich == 0)
            {
                MessageBox.Show("Bạn chưa chọn quốc tịch cần sửa.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn lưu thông tin đã sửa?", "ATIN Smartface - Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                QuocTich quocTichUpdate = GetInputForm();
                quocTichUpdate.MaQuocTich = maQuocTich;

                QuocTichManager.Instance.UpdateQuocTich(quocTichUpdate);
                RefreshForm(); ;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshForm();
        }
    }
}