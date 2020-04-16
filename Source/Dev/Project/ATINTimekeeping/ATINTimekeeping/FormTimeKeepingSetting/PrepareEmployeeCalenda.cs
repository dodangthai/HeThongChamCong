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
using System.Reflection;

namespace ATINTimekeeping.FormTimeKeepingSetting
{
    public partial class PrepareEmployeeCalenda : Form
    {
        private static PrepareEmployeeCalenda obj;


        //using Singleton to create only one Instance of form
        private PrepareEmployeeCalenda()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            SetDoubleBuffer(dataGridView1, true);
            SetDoubleBuffer(dataGridView2, true);
            TreeView1Config();
            ATINChamCongEntities context = new ATINChamCongEntities();
            var lstLichTrinh = context.spGetAllLichTrinh().ToList();
            LichTrinh lichTrinhEmpty = new LichTrinh { MaLichTrinh = null, TenLichTrinh = "Chưa Xếp", LoaiChuKy = null };
            lstLichTrinh.Add(lichTrinhEmpty);
            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.DataSource = lstLichTrinh;
            col.Name = "col";
            col.DisplayMember = "TenLichTrinh";
            col.DataPropertyName = "MaLichTrinh";
            col.ValueMember = "MaLichTrinh";
            col.HeaderText = "Lịch trình";
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            col.DefaultCellStyle.NullValue = lichTrinhEmpty.TenLichTrinh;
            col.DefaultCellStyle.DataSourceNullValue = lichTrinhEmpty.MaLichTrinh;
            dataGridView1.Columns.Add(col);

            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "Checkbox";
            checkCol.DataPropertyName = "Checkbox";
            checkCol.HeaderText = "";
            checkCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkCol.Width = 120;
            checkCol.DefaultCellStyle.NullValue = false;
            checkCol.DefaultCellStyle.DataSourceNullValue = false;
            dataGridView1.Columns.Add(checkCol);

            Set();
        }
        public static PrepareEmployeeCalenda CreateInstance()
        {
            if (obj == null)
                return obj = new PrepareEmployeeCalenda();
            else
                return obj;
        }
        public static PrepareEmployeeCalenda GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
                obj = null;
        }

        private void PrepareEmployeeCalenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
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

        private void Set()
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            var lstLichTrinh = context.spGetAllLichTrinh().ToList();
            LichTrinh lichTrinhNuLL = new LichTrinh { MaLichTrinh = null, TenLichTrinh = "Chưa Xếp" };
            lstLichTrinh.Add(lichTrinhNuLL);
            List<LichTrinh> lstLichTrinh2 = new List<LichTrinh>(lstLichTrinh);
            comboBox1.DataSource = lstLichTrinh;
            comboBox2.DataSource = lstLichTrinh2;
            comboBox1.DisplayMember = "TenLichTrinh";
            comboBox2.DisplayMember = "TenLichTrinh";
            comboBox1.ValueMember = "MaLichTrinh";
            comboBox2.ValueMember = "MaLichTrinh";
            dateEditFromDate.DateTime = DateTime.Now;
            dateEditToDate.DateTime = DateTime.Now;
        }

        private void DataGridView1Config(TreeNode node)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "Nhân viên mới")
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => x.TrangThaiHoatDong == 2).ToList();
                List<ViewSapXepLichTrinh> viewSapXepLichTrinhs = new List<ViewSapXepLichTrinh>();
                foreach (var nguoi in lstNguoi)
                {
                    viewSapXepLichTrinhs.Add(context.spGetViewSapXepLichTrinhByNguoi(nguoi.MaNguoi).FirstOrDefault());
                }
                dataGridView1.DataSource = viewSapXepLichTrinhs;
                if (viewSapXepLichTrinhs.Count < 1)
                    return;
                barEditItem3.EditValue = viewSapXepLichTrinhs.Count.ToString();
            }

            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "ATI")
            {
                var lstNguoi = context.spGetAllNguoi().ToList();
                List<ViewSapXepLichTrinh> viewSapXepLichTrinhs = new List<ViewSapXepLichTrinh>();
                foreach (var nguoi in lstNguoi)
                {
                    viewSapXepLichTrinhs.Add(context.spGetViewSapXepLichTrinhByNguoi(nguoi.MaNguoi).FirstOrDefault());
                }
                dataGridView1.DataSource = viewSapXepLichTrinhs;
                if (viewSapXepLichTrinhs.Count < 1)
                    return;
                barEditItem3.EditValue = viewSapXepLichTrinhs.Count.ToString();
            }

            if ((node.Tag as PhongBan).MaPhongBan == 0 && node.Text.Trim() == "Văn phòng")
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => x.TrangThaiHoatDong == 1).ToList();
                List<ViewSapXepLichTrinh> viewSapXepLichTrinhs = new List<ViewSapXepLichTrinh>();
                foreach (var nguoi in lstNguoi)
                {
                    viewSapXepLichTrinhs.Add(context.spGetViewSapXepLichTrinhByNguoi(nguoi.MaNguoi).FirstOrDefault());
                }
                dataGridView1.DataSource = viewSapXepLichTrinhs;
                if (viewSapXepLichTrinhs.Count < 1)
                    return;
                barEditItem3.EditValue = viewSapXepLichTrinhs.Count.ToString();
            }

            else if ((node.Tag as PhongBan).MaPhongBan != 0)
            {
                var lstNguoi = context.spGetAllNguoi().Where(x => (x.TrangThaiHoatDong == 1) && (x.MaPhongBan == (node.Tag as PhongBan).MaPhongBan)).ToList();
                List<ViewSapXepLichTrinh> viewSapXepLichTrinhs = new List<ViewSapXepLichTrinh>();
                foreach (var nguoi in lstNguoi)
                {
                    viewSapXepLichTrinhs.Add(context.spGetViewSapXepLichTrinhByNguoi(nguoi.MaNguoi).FirstOrDefault());
                }
                dataGridView1.DataSource = viewSapXepLichTrinhs;
                if (viewSapXepLichTrinhs.Count < 1)
                    return;
                barEditItem3.EditValue = viewSapXepLichTrinhs.Count.ToString();
            }
            dataGridView1.Columns["MaSapXep"].Visible = false;
            dataGridView1.Columns["Checkbox"].DisplayIndex = 0;
            dataGridView1.Columns["MaNguoi"].DisplayIndex = 1;
            dataGridView1.Columns["MaChamCong"].DisplayIndex = 2;
            dataGridView1.Columns["HoTen"].DisplayIndex = 3;
            //dataGridView1.Columns["MaLichTrinh"].Visible = false;
            dataGridView1.Columns["col"].DisplayIndex = 4;
            dataGridView1.Refresh();
        }
        private void DataGridView2Config(ViewSapXepLichTrinh viewSapXepLichTrinh)
        {
            //dataGridView2.Refresh();
            ATINChamCongEntities context = new ATINChamCongEntities();
            var lstSapXepLTT = context.spGetSapXepLichTrinhTamByNguoi(viewSapXepLichTrinh.MaNguoi).ToList();
            var lstLichTrinh = context.spGetAllLichTrinh().ToList();
            dataGridView2.DataSource = lstSapXepLTT;
            if (lstSapXepLTT.Count < 1)
                return;
            dataGridView2.Columns["TuNgay"].DisplayIndex = 0;
            dataGridView2.Columns["DenNgay"].DisplayIndex = 1;
            dataGridView2.Columns["TenLichTrinh"].DisplayIndex = 2;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (var lichtrinh in lstLichTrinh)
                {
                    if ((row.DataBoundItem as SapXepLichTrinhTam).MaLichTrinh == lichtrinh.MaLichTrinh)
                        row.Cells["TenLichTrinh"].Value = lichtrinh.TenLichTrinh;
                }
            }

            dataGridView2.Columns["LichTrinh"].Visible = false;
            dataGridView2.Columns["Nguoi"].Visible = false;
            dataGridView2.Columns["MaNguoi"].Visible = false;
            dataGridView2.Columns["MaLichTrinh"].Visible = false;
            dataGridView2.Columns["MaLichTrinhTam"].Visible = false;

        }


        //prevent datagridview flickering
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctl, new object[] { DoubleBuffered });
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataGridView1Config(treeView1.SelectedNode);
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TreeView1Config();
        }

        private void barButtonItemDeleeAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                context.spDeleteSapXepLichTrinhTam((row.DataBoundItem as SapXepLichTrinhTam).MaLichTrinhTam);
            }
            var viewSapXepLichTrinh = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as ViewSapXepLichTrinh;
            DataGridView2Config(viewSapXepLichTrinh);
        }

        private void barButtonItemSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(barEditItemSearchType.EditValue.ToString().Trim()))
            {
                MessageBox.Show("Chọn loại tìm kiếm trước", "Thông báo!");
            }
            else
            {
                switch (barEditItemSearchType.EditValue.ToString().Trim())
                {
                    case "Theo tên nhân viên":
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["HoTen"].Value.ToString().Trim() == barEditItemSearchValue.EditValue.ToString().Trim())
                            {
                                dataGridView1.CurrentCell = row.Cells["HoTen"];
                                return;
                            }
                        }
                        MessageBox.Show("Không tìm được!", "Thông báo!");
                        return;
                    case "Theo mã nhân viên":
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["MaNguoi"].Value.ToString().Trim() == barEditItemSearchValue.EditValue.ToString().Trim())
                            {
                                dataGridView1.CurrentCell = row.Cells["MaNguoi"];
                                return;
                            }
                        }
                        MessageBox.Show("Không tìm được!", "Thông báo!");
                        return;
                    case "Theo mã chấm công":
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["MaChamCong"].Value.ToString().Trim() == barEditItemSearchValue.EditValue.ToString().Trim())
                            {
                                dataGridView1.CurrentCell = row.Cells["MaChamCong"];
                                return;
                            }
                            MessageBox.Show("Không tìm được!", "Thông báo!");
                        }
                        MessageBox.Show("Không tìm được!", "Thông báo!");
                        return;
                }
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                var viewSapXepLichTrinh = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as ViewSapXepLichTrinh;
                DataGridView2Config(viewSapXepLichTrinh);
            }
        }

        private void buttonAddSapXepTam_Click(object sender, EventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            if (checkBoxUpdateBySelectedEmployee.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;
                    if ((bool)row.Cells[0].Value == true)
                    {
                        context.spInsertSapxepLichTrinhTam(
                            dateEditFromDate.DateTime,
                            dateEditToDate.DateTime,
                            (string)comboBox2.SelectedValue,
                            (row.DataBoundItem as ViewSapXepLichTrinh).MaNguoi
                            );
                    }
                }
            }
            else
            {
                if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem != null)
                {
                    context.spInsertSapxepLichTrinhTam(
                        dateEditFromDate.DateTime,
                        dateEditToDate.DateTime,
                        (string)comboBox2.SelectedValue,
                        (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as ViewSapXepLichTrinh).MaNguoi
                        );
                }
            }
            var viewSapXepLichTrinh = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as ViewSapXepLichTrinh;
            DataGridView2Config(viewSapXepLichTrinh);
        }

        private void buttonDeleteSapXepTam_Click(object sender, EventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            if (dataGridView2.SelectedRows.Count > 0)
                context.spDeleteSapXepLichTrinhTam((dataGridView2.SelectedRows[0].DataBoundItem as SapXepLichTrinhTam).MaLichTrinhTam);
            var viewSapXepLichTrinh = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as ViewSapXepLichTrinh;
            DataGridView2Config(viewSapXepLichTrinh);
        }

        //Insert & update SapXepLichTrinh when changed combobox value

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                ATINChamCongEntities context = new ATINChamCongEntities();
                if (dataGridView1.CurrentCell.GetType() == typeof(DataGridViewComboBoxCell))
                {
                    var viewsapxeplichtrinh = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as ViewSapXepLichTrinh;
                    if (dataGridView1.CurrentCell.Value == null)
                    {
                        context.spDeleteSapXepLichTrinh(viewsapxeplichtrinh.MaSapXep);
                    }
                    else
                    {
                        context.spDeleteSapXepLichTrinh(viewsapxeplichtrinh.MaSapXep);
                        context.spInsertSapXepLichTrinh(viewsapxeplichtrinh.MaNguoi, viewsapxeplichtrinh.MaLichTrinh);
                    }
                }
            }
        }

        private void barButtonItemActive_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells.Count > 0)
                {
                    if (row.Cells[0].Value == null)
                        continue;
                    if ((bool)row.Cells[0].Value == true)
                    {
                        var viewsapxeplichtrinh = row.DataBoundItem as ViewSapXepLichTrinh;
                        if (comboBox1.SelectedValue == null)
                        {
                            context.spDeleteSapXepLichTrinh(viewsapxeplichtrinh.MaSapXep);
                        }
                        else
                        {
                            context.spDeleteSapXepLichTrinh(viewsapxeplichtrinh.MaSapXep);
                            context.spInsertSapXepLichTrinh(viewsapxeplichtrinh.MaNguoi, comboBox1.SelectedValue.ToString().Trim());
                        }

                    }
                }
            }
            DataGridView1Config(treeView1.SelectedNode);
        }
    }
}
