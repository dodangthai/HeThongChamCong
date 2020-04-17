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
    public partial class AddTimeMutliple : Form
    {
        public AddTimeMutliple()
        {
            InitializeComponent();
            TreeView1Config();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            timeEdit1.Time = DateTime.Now;
            timeEdit2.Time = DateTime.Now;
            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "Checkbox";
            checkCol.DataPropertyName = "Checkbox";
            checkCol.HeaderText = "";
            checkCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkCol.Width = 120;
            checkCol.DefaultCellStyle.NullValue = false;
            checkCol.DefaultCellStyle.DataSourceNullValue = false;
            dataGridView1.Columns.Add(checkCol);
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
        private void DataGridView1Config(TreeNode node)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            textBox5.Text = "0";
            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "Nhân viên mới")
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => x.TrangThaiHoatDong == 2).ToList();
                dataGridView1.DataSource = lstNguoi;
                textBox5.Text = lstNguoi.Count.ToString();
                if (lstNguoi.Count < 1)
                    return;
            }
            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "ATI")
            {
                var lstNguoi = context.spGetAllNguoi().ToList();
                dataGridView1.DataSource = lstNguoi;
                textBox5.Text = lstNguoi.Count.ToString();
                if (lstNguoi.Count < 1)
                    return;
            }

            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "Văn phòng")
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => x.TrangThaiHoatDong == 1).ToList();
                dataGridView1.DataSource = lstNguoi;
                textBox5.Text = lstNguoi.Count.ToString();
                if (lstNguoi.Count < 1)
                    return;
            }
            else if ((node.Tag as PhongBan).MaPhongBan != 0)
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => (x.TrangThaiHoatDong == 1) && (x.MaPhongBan == (node.Tag as PhongBan).MaPhongBan)).ToList();
                dataGridView1.DataSource = lstNguoi;
                textBox5.Text = lstNguoi.Count.ToString();
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataGridView1Config(treeView1.SelectedNode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString() == textBox3.Text.Trim())
                    dataGridView1.Rows[row.Index].Selected = true;
            }
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex < 0)
                return;
            ListView1Config(comboBox2.SelectedIndex, comboBox3.SelectedIndex + 1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex < 0)
                return;
            ListView1Config(comboBox2.SelectedIndex, comboBox3.SelectedIndex + 1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                timeEdit1.Enabled = true;
            else
                timeEdit1.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                timeEdit2.Enabled = true;
            else
                timeEdit2.Enabled = false;
        }

        // add time
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
