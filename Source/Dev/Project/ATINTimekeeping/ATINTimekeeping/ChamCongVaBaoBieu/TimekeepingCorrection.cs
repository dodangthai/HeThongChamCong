using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATINTimekeeping.Model;

namespace ATINTimekeeping.ChamCongVaBaoBieu
{
    public partial class TimekeepingCorrection : Form
    {
        public TimekeepingCorrection()
        {
            InitializeComponent();
            barEditItem1.EditValue = repositoryItemComboBox1.Items[0];
            TreeView1Config();
        }
        private void TreeView1Config()
        {
            treeView1.Nodes[1].Nodes[0].Nodes.Clear();
            ATINChamCongEntities context = new ATINChamCongEntities();
            var phongBans = context.spGetAllPhongBan().ToList();

            treeView1.Nodes[0].Tag = new PhongBan();
            treeView1.Nodes[1].Tag = new PhongBan();
            treeView1.Nodes[1].Nodes[0].Tag = new PhongBan();
            foreach (var phong in phongBans)
            {
                TreeNode node = new TreeNode(phong.TenPhongBan);
                node.Tag = phong;
                treeView1.Nodes[1].Nodes[0].Nodes.Add(node);
            }
            treeView1.ExpandAll();
        }
        private void DataGridView1Config(TreeNode node)
        {
            barEditItem3.EditValue = 0;
            ATINChamCongEntities context = new ATINChamCongEntities();
            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "Nhân viên mới")
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => x.TrangThaiHoatDong == 2).ToList();
                dataGridView1.DataSource = lstNguoi;
                barEditItem3.EditValue = lstNguoi.Count;
                if (lstNguoi.Count < 1)
                    return;
            }
            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "ATI")
            {
                var lstNguoi = context.spGetAllNguoi().ToList();
                dataGridView1.DataSource = lstNguoi;
                barEditItem3.EditValue = lstNguoi.Count;
                if (lstNguoi.Count < 1)
                    return;
            }

            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "Văn phòng")
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => x.TrangThaiHoatDong == 1).ToList();
                dataGridView1.DataSource = lstNguoi;
                barEditItem3.EditValue = lstNguoi.Count;
                if (lstNguoi.Count < 1)
                    return;
            }
            else if ((node.Tag as PhongBan).MaPhongBan != 0)
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => (x.TrangThaiHoatDong == 1) && (x.MaPhongBan == (node.Tag as PhongBan).MaPhongBan)).ToList();
                dataGridView1.DataSource = lstNguoi;
                barEditItem3.EditValue = lstNguoi.Count;
                if (lstNguoi.Count < 1)
                    return;
            }
            dataGridView1.Columns["MaDinhDanh"].Visible = false;
            dataGridView1.Columns["MaPhongBan"].Visible = false;
            dataGridView1.Columns["MaChucVu"].Visible = false;
            dataGridView1.Columns["MaKhuVuc"].Visible = false;
            dataGridView1.Columns["NgaySinh"].Visible = false;
            dataGridView1.Columns["MaGioiTinh"].Visible = false;
            dataGridView1.Columns["SoDienThoai"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["AnhDaiDien"].Visible = false;
            dataGridView1.Columns["MaTrinhDo"].Visible = false;
            dataGridView1.Columns["SoTheCanCuoc"].Visible = false;
            dataGridView1.Columns["NgayCapTCC"].Visible = false;
            dataGridView1.Columns["NoiCapTCC"].Visible = false;
            dataGridView1.Columns["MaDanToc"].Visible = false;
            dataGridView1.Columns["MaTonGiao"].Visible = false;
            dataGridView1.Columns["MaQuocTich"].Visible = false;
            dataGridView1.Columns["TinhTrangHonNhan"].Visible = false;
            dataGridView1.Columns["DiaChiThuongTru"].Visible = false;
            dataGridView1.Columns["DiaChiTamTru"].Visible = false;
            dataGridView1.Columns["NgayNhanViec"].Visible = false;
            dataGridView1.Columns["NgayThoiViec"].Visible = false;
            dataGridView1.Columns["SuDungVanTay"].Visible = false;
            dataGridView1.Columns["SuDungTheTu"].Visible = false;
            dataGridView1.Columns["SuDungKhuonMat"].Visible = false;
            dataGridView1.Columns["ThoiGianDangKy"].Visible = false;
            dataGridView1.Columns["ThoiGianCapNhat"].Visible = false;
            dataGridView1.Columns["GhiChu"].Visible = false;
            dataGridView1.Columns["TrangThaiHoatDong"].Visible = false;
            dataGridView1.Columns["ChamCongs"].Visible = false;
            dataGridView1.Columns["ChucVu"].Visible = false;
            dataGridView1.Columns["DangKyNghiPheps"].Visible = false;
            dataGridView1.Columns["DangKyTangCas"].Visible = false;
            dataGridView1.Columns["KhuonMats"].Visible = false;
            dataGridView1.Columns["PhongBan"].Visible = false;
            dataGridView1.Columns["NhatKies"].Visible = false;
            dataGridView1.Columns["SapXepLichTrinhs"].Visible = false;
            dataGridView1.Columns["TheTus"].Visible = false;
            dataGridView1.Columns["VanTays"].Visible = false;
            dataGridView1.Columns["SapXepLichTrinhTams"].Visible = false;

            dataGridView1.Columns["MaNguoi"].DisplayIndex = 0;
            dataGridView1.Columns["HoTen"].DisplayIndex = 1;

        }

        private void DataGridView2Config(Nguoi nguoi)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            var views = context.spGetViewSuaGioChamCongByNguoiByTime(nguoi.MaNguoi, (DateTime)barEditItem4.EditValue).ToList();
            dataGridView2.DataSource = views;
            dataGridView2.Columns["MaNhanVien"].Visible = false;
            dataGridView2.Columns["MaChamCongChiTiet"].Visible = false;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataGridView1Config(treeView1.SelectedNode);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >0)
            {
                var nguoi = dataGridView1.SelectedRows[0].DataBoundItem as Nguoi;
                DataGridView2Config(nguoi);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == barEditItem2.EditValue.ToString().Trim())
                    dataGridView1.Rows[row.Index].Selected = true;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TreeView1Config();
        }

        private void barEditItem4_EditValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var nguoi = dataGridView1.SelectedRows[0].DataBoundItem as Nguoi;
                DataGridView2Config(nguoi);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var nguoi = dataGridView1.SelectedRows[0].DataBoundItem as Nguoi;
                Form f = new SubAddCCCT(nguoi.MaNguoi);
                f.ShowDialog();
                DataGridView2Config(nguoi);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView2.SelectedRows.Count > 0)
            {
                var nguoi = dataGridView1.SelectedRows[0].DataBoundItem as Nguoi;
                var view = (dataGridView2.SelectedRows[0].DataBoundItem as ViewSuaGioChamCong);
                Form f = new SubEditCCCT(view.MaChamCong, view.MaChamCongChiTiet, view.GioChamCong);
                f.ShowDialog();
                DataGridView2Config(nguoi);
            }
        }
    }
}
