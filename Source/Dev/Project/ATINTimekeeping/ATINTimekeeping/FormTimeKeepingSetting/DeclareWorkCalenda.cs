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
    public partial class DeclareWorkCalenda : Form
    {

        private bool allowInsert = false;
        private string WorkCalendarShowType = null;
        private static DeclareWorkCalenda obj;
        
        //using Singleton to create only one Instance of form
        private DeclareWorkCalenda()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            SetDoubleBuffer(dataGridView2, true);
        }
        public static DeclareWorkCalenda CreateInstance()
        {
            if (obj == null)
                return obj = new DeclareWorkCalenda();
            else
                return obj;
        }
        public static DeclareWorkCalenda GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
                obj = null;
        }
        //prevent datagridview flickering
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctl, new object[] { DoubleBuffered });
        }
        private void SetLichTrinh(LichTrinh lichTrinh)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            var lstMap = context.spGetMapLichTrinhNangCaoByLichTrinh(lichTrinh.MaLichTrinh).ToList();
            textEdit1.Text = lichTrinh.MaLichTrinh;
            textEdit2.Text = lichTrinh.TenLichTrinh;
            foreach(var map in lstMap)
            {
                switch (map.MaLichTrinhNangCao)
                {
                    case "NC1": checkBox1.Checked = true; break;
                    case "NC2": checkBox2.Checked = true; break;
                    case "NC3": checkBox3.Checked = true; break;
                    case "NC4": checkBox4.Checked = true; break;
                    case "NC5": checkBox5.Checked = true; break;
                }
            }
            switch (lichTrinh.LoaiChuKy)
            {
                case "week": 
                    radioButton1.Checked = true;
                    WorkCalendarShowType = "week";
                    break;
                case "month":
                    radioButton2.Checked = true;
                    WorkCalendarShowType = "monh";
                    break;
                case "year":
                    radioButton3.Checked = true;
                    WorkCalendarShowType = "year";
                    break;
            }
            RefreshGrid2(lichTrinh.MaLichTrinh);
            
        }
        private LichTrinh GetLichTrinh()
        {
            LichTrinh lichTrinh = new LichTrinh();
            lichTrinh.MaLichTrinh = textEdit1.Text;
            lichTrinh.TenLichTrinh = textEdit2.Text;
            if (radioButton1.Checked)
                lichTrinh.LoaiChuKy = "week";
            if (radioButton2.Checked)
                lichTrinh.LoaiChuKy = "month";
            if (radioButton3.Checked)
                lichTrinh.LoaiChuKy = "year";
            else
                lichTrinh.LoaiChuKy = "week";
            return lichTrinh;
        }
        private void Save(string MaLichTrinhChon, LichTrinh lichTrinh, ref bool allowInsert)
        {
            try
            {
                //insert
                if (allowInsert)
                {
                    ATINChamCongEntities context = new ATINChamCongEntities();
                    context.spInsertLichTrinh(
                     lichTrinh.MaLichTrinh,
                     lichTrinh.TenLichTrinh,
                     lichTrinh.LoaiChuKy
                     );
                    if(checkBox1.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC1");
                    if(checkBox2.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC2");
                    if (checkBox3.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC3");
                    if (checkBox4.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC4");
                    if (checkBox5.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC5");

                }
                //update
                else
                {
                    ATINChamCongEntities context = new ATINChamCongEntities();
                    context.spUpdateLichTrinh(
                     MaLichTrinhChon,
                     lichTrinh.MaLichTrinh,
                     lichTrinh.TenLichTrinh,
                     lichTrinh.LoaiChuKy
                     );
                    if (checkBox1.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC1");
                    else
                        context.spDeleteMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC1");
                    if (checkBox2.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC2");
                    else
                        context.spDeleteMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC2");
                    if (checkBox3.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC3");
                    else
                        context.spDeleteMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC3");
                    if (checkBox4.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC4");
                    else
                        context.spDeleteMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC4");
                    if (checkBox5.Checked)
                        context.spInsertMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC5");
                    else
                        context.spDeleteMapLichTrinhNangCao(lichTrinh.MaLichTrinh, "NC5");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static List<LichTrinh> LoadAllLichTrinhs()
        {
            List<LichTrinh> lichTrinhs = new List<LichTrinh>();
            try
            {
                ATINChamCongEntities context = new ATINChamCongEntities();
                lichTrinhs = context.spGetAllLichTrinh().ToList();
                return lichTrinhs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        private void DeleteLichTrinh(string MaLichTrinh)
        {
            try
            {
                var context = new ATINChamCongEntities();
                context.spDeleteLichTrinh(MaLichTrinh);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void RefreshGrid1()
        {
            List<LichTrinh> lichTrinhs = LoadAllLichTrinhs();
            dataGridView1.DataSource = lichTrinhs;
        }
        private void RefreshGrid2(string MaLichTrinh)
        {
            dataGridView2.Columns.Clear();
            ATINChamCongEntities context = new ATINChamCongEntities();
            switch(WorkCalendarShowType)
            {
                case "week":
                    dataGridView2.Columns.Add("", "Ngày");
                    dataGridView2.Rows.Add("Chủ Nhật");
                    for(int i = 2; i < 8; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dataGridView2.Rows.Add("Thứ " + i);
                            dataGridView2.Rows[i - 1].DefaultCellStyle.BackColor = SystemColors.Control;
                            continue;
                        }
                        dataGridView2.Rows.Add("Thứ " + i);
                    }
                    dataGridView2.Rows.Add("Ngày Lễ");
                    dataGridView2.Rows[7].DefaultCellStyle.BackColor = SystemColors.Control;
                    dataGridView2.Rows[0].DefaultCellStyle.ForeColor = Color.Red;
                    dataGridView2.Rows[7].DefaultCellStyle.ForeColor = Color.Blue;
                    List<LichTrinhTuan> lichTrinhTuans = context.spGetLichTrinhTuanByLichTrinh(MaLichTrinh).OrderBy(c => c.DateInWeek).ToList();
                    int maxcol = context.spGetAllCaLamViec().ToList().Count;
                    for(int i = 1; i <= maxcol; i++)
                    {
                        dataGridView2.Columns.Add("", "Ca Thứ " + i);
                    }
                    int count = 0;
                    int tmp = 0;
                    foreach (var lictrinhtuan in lichTrinhTuans)
                    {
                        if (tmp != lictrinhtuan.DateInWeek) 
                        { 
                            tmp = lictrinhtuan.DateInWeek;
                            dataGridView2.Rows[lictrinhtuan.DateInWeek-1].Cells[1].Value = lictrinhtuan.MaCaLamViec;
                            count = 1;
                            continue;
                        }
                        count++;
                        dataGridView2.Rows[lictrinhtuan.DateInWeek-1].Cells[count].Value = lictrinhtuan.MaCaLamViec;
                    }
                    break;
                case "month":
                    dataGridView2.Columns.Add("", "Ngày");
                    for (int i = 1; i < 32; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dataGridView2.Rows.Add("Ngày " + i);
                            dataGridView2.Rows[i - 1].DefaultCellStyle.BackColor = SystemColors.Control;
                            continue;
                        }
                        dataGridView2.Rows.Add("Ngày " + i);
                    }
                    dataGridView2.Rows.Add("Ngày Lễ");
                    dataGridView2.Rows[31].DefaultCellStyle.BackColor = SystemColors.Control;
                    dataGridView2.Rows[31].DefaultCellStyle.ForeColor = Color.Blue;
                    List<LichTrinhThang> lichTrinhThangs = context.spGetLichTrinhThangByLichTrinh(MaLichTrinh).OrderBy(c => c.Date).ToList(); ;
                    int maxcol2 = context.spGetAllCaLamViec().ToList().Count;
                    for (int i = 1; i <= maxcol2; i++)
                    {
                        dataGridView2.Columns.Add("", "Ca Thứ " + i);
                    }
                    int count2 = 0;
                    int tmp2 = 0;
                    foreach (var lichTrinhThang in lichTrinhThangs)
                    {
                        if (tmp2 != lichTrinhThang.Date)
                        {
                            tmp2 = lichTrinhThang.Date;
                            dataGridView2.Rows[lichTrinhThang.Date-1].Cells[1].Value = lichTrinhThang.MaCaLamViec;
                            count2 = 1;
                            continue;
                        }
                        count2++;
                        dataGridView2.Rows[lichTrinhThang.Date-1].Cells[count2].Value = lichTrinhThang.MaCaLamViec;
                    }
                    break;
                //case "year":
                //    dataGridView2.Columns.Add("", "Tháng");
                //    for (int i = 1; i < 13; i++)
                //    {
                //        if (i % 2 == 0)
                //        {
                //            dataGridView2.Rows.Add("Tháng " + i);
                //            dataGridView2.Rows[i - 1].DefaultCellStyle.BackColor = SystemColors.Control;
                //            continue;
                //        }
                //        dataGridView2.Rows.Add("Tháng " + i);
                //    }
                //    List<LichTrinhNam> lichTrinhNams = context.spGetLichTrinhNamByLichTrinh(MaLichTrinh).OrderBy(c => c.Month).ThenBy(c=>c.Date).ToList(); ;
                //    for (int i = 1; i <= 31; i++)
                //    {
                //        dataGridView2.Columns.Add("", "Ngày " + i);
                //    }
                //    dataGridView2.Columns.Add("", "Ngày Lễ");
                //    dataGridView2.Columns[31].DefaultCellStyle.ForeColor = Color.Blue;
                //    int count3 = 0;
                //    int tmp3 = 0;
                //    string Ca = "";
                //    foreach (var lichTrinhNam in lichTrinhNams)
                //    {
                //        if (tmp3 != lichTrinhNam.Month)
                //        {
                //            foreach(var obj in lichTrinhNams) 
                //            {
                //                if (obj.Month == lichTrinhNam.Month && obj.Date == 1)
                //                    Ca += obj.MaCaLamViec + @"/";
                //            }
                //            tmp3 = lichTrinhNam.Month;
                //            dataGridView2.Rows[lichTrinhNam.Month-1].Cells[1].Value = Ca;
                //            Ca = "";
                //            count3 = 1;
                //            continue;
                //        }
                //        count3++;
                //        foreach (var obj in lichTrinhNams)
                //        {
                //            if (obj.Month == lichTrinhNam.Month && obj.Date == count3)
                //                Ca += obj.MaCaLamViec + @"/";
                //        }
                //        dataGridView2.Rows[lichTrinhNam.Date-1].Cells[count3].Value = Ca;
                //        Ca = "";
                //    }
                //    break;
            }
        }

        private void DeclareWorkCalenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }

        //show dialog
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;
            Form f = new SubDeclareWorkCalendar(dataGridView1.SelectedRows[0].DataBoundItem as LichTrinh, WorkCalendarShowType);
            if (f.ShowDialog() == DialogResult.OK)
                if (dataGridView1.SelectedRows.Count > 0)
                    RefreshGrid2((dataGridView1.SelectedRows[0].DataBoundItem as LichTrinh).MaLichTrinh);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var lichTrinh = dataGridView1.SelectedRows[0].DataBoundItem as LichTrinh;
                SetLichTrinh(lichTrinh);
            }
            allowInsert = false;
            barButtonItemAddNew.Enabled = true;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                WorkCalendarShowType = "week";
            if(dataGridView1.SelectedRows.Count>0)
            RefreshGrid2((dataGridView1.SelectedRows[0].DataBoundItem as LichTrinh).MaLichTrinh);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                WorkCalendarShowType = "month";
            if (dataGridView1.SelectedRows.Count > 0)
                RefreshGrid2((dataGridView1.SelectedRows[0].DataBoundItem as LichTrinh).MaLichTrinh);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                WorkCalendarShowType = "year";
            if (dataGridView1.SelectedRows.Count > 0)
                RefreshGrid2((dataGridView1.SelectedRows[0].DataBoundItem as LichTrinh).MaLichTrinh);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked)
            checkBox3.Checked = false;
        }

        private void barButtonItemAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            allowInsert = true;
            barButtonItemAddNew.Enabled = false;
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit1.Text.Trim()))
            {
                MessageBox.Show("Mã lịch trình không được để trống", "Thông báo!");
                return;
            }
            if (string.IsNullOrEmpty(textEdit2.Text.Trim()))
            {
                MessageBox.Show("Tên lịch trình không được để trống", "Thông báo!");
                return;
            }
            if (dataGridView1.Rows.Count > 0)
                Save((dataGridView1.SelectedRows[0].DataBoundItem as LichTrinh).MaLichTrinh, GetLichTrinh(), ref allowInsert);
            else
            {
                allowInsert = true;
                Save(null, GetLichTrinh(), ref allowInsert);
            }

            allowInsert = false;
            barButtonItemAddNew.Enabled = true;
            RefreshGrid1();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn muốn xóa lịch trình: " + (dataGridView1.SelectedRows[0].DataBoundItem as LichTrinh).TenLichTrinh + " Phải không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                DeleteLichTrinh((dataGridView1.SelectedRows[0].DataBoundItem as LichTrinh).MaLichTrinh);
            allowInsert = false;
            barButtonItemAddNew.Enabled = true;
            RefreshGrid1();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            allowInsert = false;
            barButtonItemAddNew.Enabled = true;
            LichTrinh lichtrinh = new LichTrinh();
            SetLichTrinh(lichtrinh);
            RefreshGrid1();

        }

        private void DeclareWorkCalenda_Load(object sender, EventArgs e)
        {
            List<LichTrinh> lichTrinhs = LoadAllLichTrinhs();
            dataGridView1.DataSource = lichTrinhs;
            //dataGridView1.Columns["TenLichTrinh"].Visible = false;
            dataGridView1.Columns["MaLichTrinh"].Visible = false;
            dataGridView1.Columns["MapLichTrinhNangCaos"].Visible = false;
            dataGridView1.Columns["SapXepLichTrinhs"].Visible = false;
            dataGridView1.Columns["SapXepLichTrinhTams"].Visible = false;
            dataGridView1.Columns["LichTrinhNams"].Visible = false;
            dataGridView1.Columns["LichTrinhThangs"].Visible = false;
            dataGridView1.Columns["LichTrinhTuans"].Visible = false;
            dataGridView1.Columns["LoaiChuKy"].Visible = false;
            
        }
    }

}
