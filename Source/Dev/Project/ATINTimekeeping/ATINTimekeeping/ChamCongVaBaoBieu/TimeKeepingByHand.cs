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
    public partial class TimeKeepingByHand : Form
    {
        public TimeKeepingByHand()
        {
            InitializeComponent();
            comboBox5.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            this.Dock = DockStyle.Fill;
            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "Checkbox";
            checkCol.DataPropertyName = "Checkbox";
            checkCol.HeaderText = "";
            checkCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkCol.Width = 80;
            checkCol.DefaultCellStyle.NullValue = false;
            checkCol.DefaultCellStyle.DataSourceNullValue = false;
            dataGridView1.Columns.Add(checkCol);
            TreeView1Config();
            Set();
        }
        private void Set()
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            var lstLoaiVang = context.spGetAllKyHieuCacLoaiVang().ToList();
            var lstCaLamViec = context.spGetAllCaLamViec().ToList();
            comboBox1.DataSource = lstLoaiVang;
            comboBox2.DataSource = lstCaLamViec;
            comboBox1.DisplayMember = "MoTa";
            comboBox1.ValueMember = "MaKyHieu";
            comboBox2.DisplayMember = "MaCaLamViec";
            comboBox2.ValueMember = "MaCaLamViec";
            if (lstLoaiVang.Count > 0)
                comboBox1.SelectedIndex = 0;
            if (lstCaLamViec.Count > 0)
                comboBox2.SelectedIndex = 0;

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
            ATINChamCongEntities context = new ATINChamCongEntities();
            barEditItem2.EditValue = "0";
            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "Nhân viên mới")
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => x.TrangThaiHoatDong == 2).ToList();
                dataGridView1.DataSource = lstNguoi;
                barEditItem2.EditValue = lstNguoi.Count.ToString();
                if (lstNguoi.Count < 1)
                    return;
            }
            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "ATI")
            {
                var lstNguoi = context.spGetAllNguoi().ToList();
                dataGridView1.DataSource = lstNguoi;
                barEditItem2.EditValue = lstNguoi.Count.ToString();
                if (lstNguoi.Count < 1)
                    return;
            }

            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "Văn phòng")
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => x.TrangThaiHoatDong == 1).ToList();
                dataGridView1.DataSource = lstNguoi;
                barEditItem2.EditValue = lstNguoi.Count.ToString();
                if (lstNguoi.Count < 1)
                    return;
            }
            else if ((node.Tag as PhongBan).MaPhongBan != 0)
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => (x.TrangThaiHoatDong == 1) && (x.MaPhongBan == (node.Tag as PhongBan).MaPhongBan)).ToList();
                dataGridView1.DataSource = lstNguoi;
                barEditItem2.EditValue = lstNguoi.Count.ToString();
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

            dataGridView1.Columns["Checkbox"].DisplayIndex = 0;
            dataGridView1.Columns["MaNguoi"].DisplayIndex = 1;
            dataGridView1.Columns["HoTen"].DisplayIndex = 2;

        }
        private void ListView1Config(int year, int month)
        {
            listView1.Items.Clear();
            int dayInMonth = DateTime.DaysInMonth(2020 + year, month);
            for (int i = 1; i <= dayInMonth; i++)
            {
                ListViewItem day = new ListViewItem("Ngày " + i.ToString());
                day.Tag = i;
                listView1.Items.Add(day);

            }
        }

        private void DataGridView2Config(Nguoi nguoi)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();

            dataGridView2.DataSource = context.spGetViewDanhSachVangByNguoi(nguoi.MaNguoi);
            dataGridView2.Columns["NgayChamCong"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView2.Columns["MaNhanVien"].Visible = false;
            dataGridView2.Columns["MaChamCong"].Visible = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataGridView1Config(treeView1.SelectedNode);
        }

        private void checkBoxCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheckAll.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = false;
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (treeView1.SelectedNode != null)
                DataGridView1Config(treeView1.SelectedNode);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString() == barEditItem1.EditValue.ToString().Trim())
                    dataGridView1.Rows[row.Index].Selected = true;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex < 0)
                return;
            ListView1Config(comboBox5.SelectedIndex, comboBox4.SelectedIndex + 1);
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            DataGridView2Config(dataGridView1.SelectedRows[0].DataBoundItem as Nguoi);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex < 0)
                return;
            ListView1Config(comboBox5.SelectedIndex, comboBox4.SelectedIndex + 1);
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            DataGridView2Config(dataGridView1.SelectedRows[0].DataBoundItem as Nguoi);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Checked = true;
                }
            else
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Checked = false;
                }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex < 0)
                return;
            ATINChamCongEntities context = new ATINChamCongEntities();
            var calamviec = context.spGetCaLamViec((comboBox2.SelectedItem as CaLamViec).MaCaLamViec).FirstOrDefault();
            textBox10.Text = calamviec.TongGio.ToString();
            textBox11.Text = calamviec.DiemCong.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;
            if (comboBox1.SelectedIndex<0||comboBox2.SelectedIndex<0)
                return;
            Cursor.Current = Cursors.WaitCursor;
            button1.Enabled = false;
            ATINChamCongEntities context = new ATINChamCongEntities();

            DateTime datetmp = DateTime.MinValue;
            int i = 0;
            int y = 0;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    y = 0;
                    if (row.Cells[0].Value == null)
                        continue;
                    if ((bool)row.Cells[0].Value == true)
                    {
                        if (true)
                        {
                            foreach (ListViewItem lvItem in listView1.Items)
                            {
                                y++;
                                if (lvItem.Checked == true)
                                {
                                    string s = (lvItem.Tag as int?).ToString() + "/" + (comboBox4.SelectedIndex + 1).ToString() + "/" + (2020 + comboBox5.SelectedIndex).ToString();
                                    datetmp = Convert.ToDateTime(s, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
                                    var x = context.spInsertChamCongLoaiVang(datetmp, (row.DataBoundItem as Nguoi).MaNguoi, (comboBox2.SelectedItem as CaLamViec).MaCaLamViec, (comboBox1.SelectedItem as KyHieuCacLoaiVang).MaKyHieu, textBox9.Text.Trim());
                                }
                            }
                        }
                    }
                    i++;
                }
                MessageBox.Show("Thêm công vắng thành công!");
            }
            catch (Exception ex)
            {
                if (ex.Message == "An error occurred while executing the command definition. See the inner exception for details.")
                {
                    Nguoi loi = (dataGridView1.Rows[i].DataBoundItem as Nguoi);
                    MessageBox.Show("Thêm vắng bị dừng giữa chừng \nKhông thể thêm vắng cho "+loi.HoTen + "("+loi.MaNguoi.ToString()+")" +"\n"+(comboBox2.SelectedItem as CaLamViec).MaCaLamViec +" Ngày "+y.ToString() + "/" + (comboBox4.SelectedIndex + 1).ToString() + "/" + (2020 + comboBox5.SelectedIndex).ToString() + " Đã tồn tại!", "Cảnh báo!");
                }
                else
                    MessageBox.Show(ex.Message);
            }
            DataGridView2Config(dataGridView1.SelectedRows[0].DataBoundItem as Nguoi);
            Cursor.Current = Cursors.Default;
            button1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            if (dataGridView2.SelectedRows.Count > 0)
                context.spDeleteChamCongLoaiVang((int)dataGridView2.SelectedRows[0].Cells["MaChamCong"].Value, dataGridView2.SelectedRows[0].Cells["MaCaLamViec"].Value.ToString());
            DataGridView2Config(dataGridView1.SelectedRows[0].DataBoundItem as Nguoi);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                DataGridView2Config(dataGridView1.SelectedRows[0].DataBoundItem as Nguoi);
        }
    }
}
