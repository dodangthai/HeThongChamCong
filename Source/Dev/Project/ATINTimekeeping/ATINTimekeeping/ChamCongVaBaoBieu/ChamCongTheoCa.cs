using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using ATINTimekeeping.Model;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ATINTimekeeping.ChamCongVaBaoBieu
{
    public partial class ChamCongTheoCa : DevExpress.XtraEditors.XtraForm
    {
        public ChamCongTheoCa()
        {
            InitializeComponent();
            SetDoubleBuffer(dataGridViewNhanVien, true);
            SetDoubleBuffer(dataGridView0, true);
            SetDoubleBuffer(dataGridView1, true);
            SetDoubleBuffer(dataGridView2, true);
            //SetDoubleBuffer(dataGridView3, true);
            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "Checkbox";
            checkCol.DataPropertyName = "Checkbox";
            checkCol.HeaderText = "";
            checkCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkCol.Width = 120;
            checkCol.DefaultCellStyle.NullValue = false;
            checkCol.DefaultCellStyle.DataSourceNullValue = false;
            checkCol.ReadOnly = false;
            dataGridViewNhanVien.Columns.Add(checkCol);
            Set();
            ATINChamCongEntities context = new ATINChamCongEntities();
            GridViewNhanVienConfig(context.spGetPhongBan(10).ToList()[0]);
        }


        private void Set()
        {
            //barEditItem17.Edit = treeListLookUpEdit;
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("parentid", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("value", typeof(int));

            table.Rows.Add(1, 0, "Christoff", 56465);
            table.Rows.Add(2, 0, "Christoff", 56465);
            table.Rows.Add(3, 1, "Christoff", 56465);
            table.Rows.Add(4, 2, "Christoff", 56465);
            table.Rows.Add(5, 1, "Christoff", 56465);
            table.Rows.Add(6, 1, "Christoff", 56465);
            table.Rows.Add(7, 3, "Christoff", 56465);
            table.Rows.Add(8, 1, "Christoff", 56465);
            table.Rows.Add(9, 1, "Christoff", 56465);

            // Có thể thay thế TreeListInTreeList bằng TreeListEdit1.TreeList
            TreeListEdit1.TreeList.ParentFieldName = "parentid";
            TreeListInTreeList.KeyFieldName = "id";
            TreeListInTreeList.RootValue = 0;
            TreeListEdit1.DataSource = table;
            TreeListEdit1.DisplayMember = "name";
            TreeListEdit1.NullText = "";
            //TreeListInTreeList.ForceInitialize();
            //TreeListInTreeList.CollapseAll();
            //TreeListInTreeList.BestFitColumns();
            //DevExpress.XtraTreeList.Columns.TreeListColumn col = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            //col.Caption = "wtf";
            //col.FieldName = "id";
            //col.Visible = true;
            //TreeListInTreeList.Columns.Add(col);
            //TreeListInTreeList.Columns["value"].Visible = false;

        }

        private void GridViewNhanVienConfig(PhongBan phongban)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            List<ViewThongTinNhanVien1> viewThongTinNhanVien1s = context.spGetViewThongTinNhanVien1ByPhongBan(phongban.MaPhongBan).Distinct().ToList();
            if (viewThongTinNhanVien1s.Count < 1)
                return;
            foreach (var view in viewThongTinNhanVien1s)
            {
                if (view.MaLichTrinh == null)
                    view.TenLichTrinh = "Chưa Xếp";
                if (view.MaPhongBan == null)
                    view.TenPhongBan = "Chưa Xếp";
                if (view.MaChucVu == null)
                    view.TenChucVu = "Chưa Xếp";
                if (view.NgayNhanViec == null)
                    view.NgayNhanViec = DateTime.MaxValue;
            }
            barEditItem8.EditValue = viewThongTinNhanVien1s.Count.ToString();
            dataGridViewNhanVien.DataSource = viewThongTinNhanVien1s;
            dataGridViewNhanVien.Columns["MaLichTrinh"].Visible = false;
            dataGridViewNhanVien.Columns["MaChucVu"].Visible = false;
            dataGridViewNhanVien.Columns["MaPhongBan"].Visible = false;
            //dataGridViewNhanVien.Columns["MaChamCong"].Visible = false;


            dataGridViewNhanVien.Columns["Checkbox"].DisplayIndex = 0;
            dataGridViewNhanVien.Columns["MaLichTrinh"].DisplayIndex = 1;
            dataGridViewNhanVien.Columns["HoTen"].DisplayIndex = 2;
            dataGridViewNhanVien.Columns["MaChamCong"].DisplayIndex = 3;
            dataGridViewNhanVien.Columns["TenLichTrinh"].DisplayIndex = 4;
            dataGridViewNhanVien.Columns["TenChucVu"].DisplayIndex = 5;
            dataGridViewNhanVien.Columns["TenPhongBan"].DisplayIndex = 6;
            dataGridViewNhanVien.Columns["NgayNhanViec"].DisplayIndex = 7;


        }
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctl, new object[] { DoubleBuffered });
        }
        private void DataGridView0Config()
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            List<ViewGioNguon> lstGioNguon = new List<ViewGioNguon>();
            if (dataGridViewNhanVien.Rows.Count < 1)
                return;

            else
            {
                foreach (DataGridViewRow row in dataGridViewNhanVien.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;
                    if ((bool)row.Cells[0].Value == true)
                    {
                        lstGioNguon.AddRange(context.spGetAllViewGioNguonOrderByNgayGio((row.DataBoundItem as ViewThongTinNhanVien1).MaNguoi, dateTuNgay.Value, dateDenNgay.Value).ToList());
                    }
                }
            }

            dataGridView0.DataSource = lstGioNguon;
            if (lstGioNguon.Count < 1)
                return;
            dataGridView0.Columns["NgayChamCong"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView0.Columns["GioChamCong"].DefaultCellStyle.Format = "hh:mm:ss";

            dataGridView0.Columns["HoTen"].Visible = false;

            dataGridView0.Columns["MaNhanVien"].DisplayIndex = 0;
            dataGridView0.Columns["MaDinhDanh"].DisplayIndex = 1;
            dataGridView0.Columns["NgayChamCong"].DisplayIndex = 2;
            dataGridView0.Columns["GioChamCong"].DisplayIndex = 3;
            dataGridView0.Columns["MaLoaiChamCong"].DisplayIndex = 4;
            dataGridView0.Columns["MaThietBi"].DisplayIndex = 5;
            dataGridView0.Columns["NguonThucHien"].DisplayIndex = 6;
            dataGridView0.Columns["MChamCong"].DisplayIndex = 7;
        }

        private void DataGridView1Config()
        {
            ATINChamCongEntities context = new ATINChamCongEntities();

            System.Data.DataTable table = new System.Data.DataTable("ViewGioChia2Cot");
            table.Columns.Add(new DataColumn("MaNhanVienGrid1", typeof(int)));
            table.Columns.Add(new DataColumn("HoTen", typeof(string)));
            table.Columns.Add(new DataColumn("MaDinhDanhGrid1", typeof(int)));
            table.Columns.Add(new DataColumn("NgayChamCongGrid1", typeof(DateTime)));
            table.Columns.Add(new DataColumn("GioVaoGrid1", typeof(DateTime)));
            table.Columns.Add(new DataColumn("GioRaGrid1", typeof(DateTime)));
            table.Columns.Add(new DataColumn("QuaDem", typeof(string)));
            table.Columns.Add(new DataColumn("MaChamCongGrid1", typeof(int)));
            table.Columns.Add(new DataColumn("TenMayGrid1", typeof(string)));


            if (dataGridViewNhanVien.Rows.Count < 1)
                return;

            else
            {
                //int count = 0;
                DateTime tmp;
                foreach (DataGridViewRow row in dataGridViewNhanVien.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;
                    if ((bool)row.Cells[0].Value == true)
                    {
                        var lstGioNguon1Cot = context.spGetAllViewGioChiaHaiCot((row.DataBoundItem as ViewThongTinNhanVien1).MaNguoi, dateTuNgay.Value, dateDenNgay.Value).ToList();
                        tmp = DateTime.MinValue;
                        for (int i = 0; i < lstGioNguon1Cot.Count; i++)
                        {
                            // Kiểm tra chuyển ngày
                            if (tmp != lstGioNguon1Cot[i].NgayChamCong)
                            {
                                tmp = lstGioNguon1Cot[i].NgayChamCong;
                                if (lstGioNguon1Cot[i].MaLoaiChamCong == "IN")
                                {
                                    if (i + 1 == lstGioNguon1Cot.Count)
                                    {
                                        addTableGrid1(lstGioNguon1Cot[i], null, ref table);
                                    }
                                    if (i + 1 < lstGioNguon1Cot.Count && lstGioNguon1Cot[i + 1].NgayChamCong == tmp)
                                    {
                                        if (lstGioNguon1Cot[i + 1].MaLoaiChamCong == "IN")

                                        {
                                            addTableGrid1(lstGioNguon1Cot[i], null, ref table);
                                        }
                                        else if (lstGioNguon1Cot[i + 1].MaLoaiChamCong == "OUT")
                                        {
                                            addTableGrid1(lstGioNguon1Cot[i], lstGioNguon1Cot[i + 1], ref table);
                                            i += 1;
                                            continue;
                                        }
                                    }
                                    if (i + 1 < lstGioNguon1Cot.Count && lstGioNguon1Cot[i + 1].NgayChamCong != tmp)
                                    {
                                        addTableGrid1(lstGioNguon1Cot[i], null, ref table);
                                    }

                                }

                                else if (lstGioNguon1Cot[i].MaLoaiChamCong == "OUT")
                                {
                                    addTableGrid1(null, lstGioNguon1Cot[i], ref table);
                                }
                                continue;
                            }
                            if (lstGioNguon1Cot[i].MaLoaiChamCong == "IN")
                            {
                                if (i + 1 == lstGioNguon1Cot.Count)
                                {
                                    addTableGrid1(lstGioNguon1Cot[i], null, ref table);
                                }

                                else if (i + 1 < lstGioNguon1Cot.Count && lstGioNguon1Cot[i + 1].NgayChamCong != tmp)
                                {
                                    addTableGrid1(lstGioNguon1Cot[i], null, ref table);
                                }
                                else if (i + 1 < lstGioNguon1Cot.Count && lstGioNguon1Cot[i + 1].NgayChamCong == tmp)
                                {
                                    if (lstGioNguon1Cot[i + 1].MaLoaiChamCong == "IN")
                                    {
                                        addTableGrid1(lstGioNguon1Cot[i], null, ref table);
                                    }
                                    else if (lstGioNguon1Cot[i + 1].MaLoaiChamCong == "OUT")
                                    {
                                        addTableGrid1(lstGioNguon1Cot[i], lstGioNguon1Cot[i + 1], ref table);
                                        i += 1;
                                        continue;
                                    }
                                }
                            }
                            else if (lstGioNguon1Cot[i].MaLoaiChamCong == "OUT")
                            {
                                if (i - 1 < lstGioNguon1Cot.Count && lstGioNguon1Cot[i - 1].NgayChamCong == tmp)
                                {
                                    if (lstGioNguon1Cot[i - 1].MaLoaiChamCong == "OUT")
                                    {
                                        addTableGrid1(null, lstGioNguon1Cot[i], ref table);
                                    }
                                }
                            }

                        }
                    }
                }
            }

            dataGridView1.DataSource = table;
            dataGridView1.Columns["NgayChamCongGrid1"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGridView0.Columns["GioVaoGrid1"].DefaultCellStyle.Format = "hh:mm:ss";
            //dataGridView0.Columns["GioRaGrid1"].DefaultCellStyle.Format = "hh:mm:ss";
            dataGridView1.Columns["HoTen"].Visible = false
                ;
            dataGridView1.Columns["MaNhanVienGrid1"].DisplayIndex = 0;
            dataGridView1.Columns["NgayChamCongGrid1"].DisplayIndex = 1;
            dataGridView1.Columns["GioVaoGrid1"].DisplayIndex = 2;
            dataGridView1.Columns["GioRaGrid1"].DisplayIndex = 3;
            dataGridView1.Columns["QuaDem"].DisplayIndex = 4;
            dataGridView1.Columns["MaChamCongGrid1"].DisplayIndex = 5;
            dataGridView1.Columns["TenMayGrid1"].DisplayIndex = 6;

        }
        private void addTableGrid1(ViewGioChiaHaiCot viewGioChiaHaiCotIN, ViewGioChiaHaiCot viewGioChiaHaiCotOUT, ref System.Data.DataTable Table)
        {
            if (viewGioChiaHaiCotIN == null && viewGioChiaHaiCotOUT != null)
            {
                Table.Rows.Add(
                    viewGioChiaHaiCotOUT.MaNhanVien.GetValueOrDefault(0),
                    viewGioChiaHaiCotOUT.HoTen,
                    viewGioChiaHaiCotOUT.MaDinhDanh.GetValueOrDefault(0),
                    viewGioChiaHaiCotOUT.NgayChamCong,
                    DateTime.MinValue,
                    viewGioChiaHaiCotOUT.GioChamCong,
                    null,
                    viewGioChiaHaiCotOUT.MaChamCong,
                    viewGioChiaHaiCotOUT.TenMay
                    );
            }
            else if (viewGioChiaHaiCotIN != null && viewGioChiaHaiCotOUT == null)
            {
                Table.Rows.Add(
                    viewGioChiaHaiCotIN.MaNhanVien.GetValueOrDefault(0),
                    viewGioChiaHaiCotIN.HoTen,
                    viewGioChiaHaiCotIN.MaDinhDanh.GetValueOrDefault(0),
                    viewGioChiaHaiCotIN.NgayChamCong,
                    viewGioChiaHaiCotIN.GioChamCong,
                    DateTime.MinValue,
                    null,
                    viewGioChiaHaiCotIN.MaChamCong,
                    viewGioChiaHaiCotIN.TenMay
                    );
            }
            else
                Table.Rows.Add(
                       viewGioChiaHaiCotIN.MaNhanVien.GetValueOrDefault(0),
                       viewGioChiaHaiCotIN.HoTen,
                       viewGioChiaHaiCotIN.MaDinhDanh.GetValueOrDefault(0),
                       viewGioChiaHaiCotIN.NgayChamCong,
                       viewGioChiaHaiCotIN.GioChamCong,
                       viewGioChiaHaiCotOUT.GioChamCong,
                       null,
                       viewGioChiaHaiCotIN.MaChamCong,
                       viewGioChiaHaiCotIN.TenMay
                       );
        }
        private void addTableGrid2(ViewGioChiaHaiCot viewGioChiaHaiCotIN, ViewGioChiaHaiCot viewGioChiaHaiCotOUT, ref System.Data.DataTable Table)
        {
            if (viewGioChiaHaiCotIN == null && viewGioChiaHaiCotOUT != null)
            {
                Table.Rows.Add(
                    viewGioChiaHaiCotOUT.MaNhanVien.GetValueOrDefault(0),
                    viewGioChiaHaiCotOUT.MaChamCong,
                    viewGioChiaHaiCotOUT.HoTen,
                    viewGioChiaHaiCotOUT.NgayChamCong,
                    DateTime.MinValue,
                    viewGioChiaHaiCotOUT.GioChamCong
                    );
            }
            else if (viewGioChiaHaiCotIN != null && viewGioChiaHaiCotOUT == null)
            {
                Table.Rows.Add(
                    viewGioChiaHaiCotIN.MaNhanVien.GetValueOrDefault(0),
                    viewGioChiaHaiCotIN.MaChamCong,
                    viewGioChiaHaiCotIN.HoTen,
                    viewGioChiaHaiCotIN.NgayChamCong,
                    viewGioChiaHaiCotIN.GioChamCong,
                    DateTime.MinValue
                    );
            }
            else
                Table.Rows.Add(
                    viewGioChiaHaiCotIN.MaNhanVien.GetValueOrDefault(0),
                    viewGioChiaHaiCotIN.MaChamCong,
                    viewGioChiaHaiCotIN.HoTen,
                    viewGioChiaHaiCotIN.NgayChamCong,
                    viewGioChiaHaiCotIN.GioChamCong,
                    viewGioChiaHaiCotOUT.GioChamCong
                    );
        }
        private void DataGridView2Config()
        {
            ATINChamCongEntities context = new ATINChamCongEntities();

            System.Data.DataTable table = new System.Data.DataTable("ViewGioChia2Cot");
            table.Columns.Add(new DataColumn("MaNhanVienGrid2", typeof(int)));
            table.Columns.Add(new DataColumn("MaChamCongGrid2", typeof(int)));
            table.Columns.Add(new DataColumn("HoTenGrid2", typeof(string)));
            table.Columns.Add(new DataColumn("NgayChamCongGrid2", typeof(DateTime)));
            table.Columns.Add(new DataColumn("GioVaoGrid2", typeof(DateTime)));
            table.Columns.Add(new DataColumn("GioRaGrid2", typeof(DateTime)));


            if (dataGridViewNhanVien.Rows.Count < 1)
                return;

            else
            {
                //int count = 0;
                DateTime tmp;
                ViewGioChiaHaiCot GioVaoSomNhat;
                foreach (DataGridViewRow row in dataGridViewNhanVien.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;
                    if ((bool)row.Cells[0].Value == true)
                    {
                        var lstGioNguon1Cot = context.spGetAllViewGioChiaHaiCot((row.DataBoundItem as ViewThongTinNhanVien1).MaNguoi, dateTuNgay.Value, dateDenNgay.Value).ToList();
                        tmp = DateTime.MinValue;
                        GioVaoSomNhat = null;
                        for (int i = 0; i < lstGioNguon1Cot.Count; i++)
                        {
                            // Kiểm tra chuyển ngày
                            if (tmp != lstGioNguon1Cot[i].NgayChamCong)
                            {
                                tmp = lstGioNguon1Cot[i].NgayChamCong;
                                GioVaoSomNhat = lstGioNguon1Cot[i];
                                if (i + 1 >= lstGioNguon1Cot.Count)
                                {
                                    addTableGrid2(GioVaoSomNhat, null, ref table);
                                }
                                else if(i+1<lstGioNguon1Cot.Count && lstGioNguon1Cot[i+1].NgayChamCong != tmp)
                                    addTableGrid2(GioVaoSomNhat, null, ref table);
                                continue;
                            }
                            if (i + 1 >= lstGioNguon1Cot.Count)
                            {
                                addTableGrid2(GioVaoSomNhat, lstGioNguon1Cot[i], ref table);
                            }
                            else if (i + 1 < lstGioNguon1Cot.Count && lstGioNguon1Cot[i + 1].NgayChamCong != tmp)
                            {
                                addTableGrid2(GioVaoSomNhat, lstGioNguon1Cot[i], ref table);
                            }

                        }
                    }
                }
            }

            dataGridView2.DataSource = table;
            dataGridView2.Columns["NgayChamCongGrid2"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGridView0.Columns["GioVaoGrid1"].DefaultCellStyle.Format = "hh:mm:ss";
            //dataGridView0.Columns["GioRaGrid1"].DefaultCellStyle.Format = "hh:mm:ss";
                ;
            dataGridView2.Columns["MaNhanVienGrid2"].DisplayIndex = 0;
            dataGridView2.Columns["MaChamCongGrid2"].DisplayIndex = 1;
            dataGridView2.Columns["HoTenGrid2"].DisplayIndex = 2;
            dataGridView2.Columns["NgayChamCongGrid2"].DisplayIndex = 3;
            dataGridView2.Columns["GioVaoGrid2"].DisplayIndex = 4;
            dataGridView2.Columns["GioRaGrid2"].DisplayIndex = 5;
        }
        private void DataGridView3Config()
        {

        }
        private void barEditItem17_EditValueChanged(object sender, EventArgs e)
        {
            var x = barEditItem17.EditValue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (DataGridViewRow row in dataGridViewNhanVien.Rows)
                {
                    row.Cells[0].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewNhanVien.Rows)
                {
                    row.Cells[0].Value = false;
                }
            }
        }

        private void btnXemCong_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnXemCong.Enabled = false;
            DataGridView0Config();
            DataGridView1Config();
            DataGridView2Config();

            Cursor.Current = Cursors.Default;
            btnXemCong.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barButtonItem16.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string saveExcelFile = @"C:\GioNguon_report.xlsx";

                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "J1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = "Giờ Nguồn";

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2", "A2");//Cột A dòng 2 và dòng 3
                row23_STT.Merge();
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô Mã Sản phẩm :
                Range row23_MaNhanVien = ws.get_Range("B2", "B2");//Cột B dòng 2 và dòng 3
                row23_MaNhanVien.Merge();

                row23_MaNhanVien.Font.Name = fontName;
                row23_MaNhanVien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaNhanVien.Value2 = "Mã Nhân Viên";
                row23_MaNhanVien.ColumnWidth = 20;
                row23_MaNhanVien.Font.Size = fontSizeTenTruong;
                //Tạo Ô Tên Sản phẩm :
                Range row23_MaDinhDanh = ws.get_Range("C2", "C2");//Cột C dòng 2 và dòng 3
                row23_MaDinhDanh.Merge();
                row23_MaDinhDanh.Font.Size = fontSizeTenTruong;
                row23_MaDinhDanh.Font.Name = fontName;
                row23_MaDinhDanh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaDinhDanh.ColumnWidth = 20;
                row23_MaDinhDanh.Value2 = "Mã Định Danh";

                Range row23_HoTen = ws.get_Range("D2", "D2");//Cột C dòng 2 và dòng 3
                row23_HoTen.Merge();
                row23_HoTen.Font.Size = fontSizeTenTruong;
                row23_HoTen.Font.Name = fontName;
                row23_HoTen.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_HoTen.ColumnWidth = 20;
                row23_HoTen.Value2 = "Họ Tên";

                //Tạo Ô Giá Sản phẩm :
                Range row2_NgayChamCong = ws.get_Range("E2", "E2");//Cột D->E của dòng 2
                row2_NgayChamCong.Merge();
                row2_NgayChamCong.Font.Size = fontSizeTenTruong;
                row2_NgayChamCong.Font.Name = fontName;
                row2_NgayChamCong.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_NgayChamCong.ColumnWidth = 20;
                row2_NgayChamCong.Value2 = "Ngày Chấm Công";

                //Tạo Ô Giá Nhập:
                Range row3_GioChamCong = ws.get_Range("F2", "F2");//Ô D3
                row3_GioChamCong.Font.Size = fontSizeTenTruong;
                row3_GioChamCong.Font.Name = fontName;
                row3_GioChamCong.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_GioChamCong.Value2 = "Giờ Chấm Công";
                row3_GioChamCong.ColumnWidth = 20;

                //Tạo Ô Giá Xuất:
                Range row3_LoaiChamCong = ws.get_Range("G2", "G2");//Ô E3
                row3_LoaiChamCong.Font.Size = fontSizeTenTruong;
                row3_LoaiChamCong.Font.Name = fontName;
                row3_LoaiChamCong.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_LoaiChamCong.Value2 = "Loại";
                row3_LoaiChamCong.ColumnWidth = 20;

                Range row3_MaThietBi = ws.get_Range("H2", "H2");//Ô E3
                row3_MaThietBi.Font.Size = fontSizeTenTruong;
                row3_MaThietBi.Font.Name = fontName;
                row3_MaThietBi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_MaThietBi.Value2 = "Mã Thiết Bị";
                row3_MaThietBi.ColumnWidth = 20;
                Range row3_NguonThucHien = ws.get_Range("I2", "I2");//Ô E3
                row3_NguonThucHien.Font.Size = fontSizeTenTruong;
                row3_NguonThucHien.Font.Name = fontName;
                row3_NguonThucHien.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_NguonThucHien.Value2 = "Nguồn Thực Hiện";
                row3_NguonThucHien.ColumnWidth = 20;
                Range row3_MaChamCong = ws.get_Range("J2", "J2");//Ô E3
                row3_MaChamCong.Font.Size = fontSizeTenTruong;
                row3_MaChamCong.Font.Name = fontName;
                row3_MaChamCong.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_MaChamCong.Value2 = "Mã Chấm Công";
                row3_MaChamCong.ColumnWidth = 20;
                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "J2");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 2;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 2 để vào vòng lặp nó ++ thành 3)
                foreach (var sp in dataGridView0.DataSource as List<ViewGioNguon>)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, sp.MaNhanVien,sp.MaDinhDanh, sp.HoTen, sp.NgayChamCong.ToShortDateString(), sp.GioChamCong.ToShortTimeString(), sp.MaLoaiChamCong, sp.MaThietBi, sp.NguonThucHien, sp.MaChamCong };
                    Range rowData = ws.get_Range("A" + row, "J" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "J" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            barButtonItem16.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barButtonItem16.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string saveExcelFile = @"C:\GioNguonHaiCot_report.xlsx";

                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "J1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = "Giờ Nguồn Hai Cột";

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2", "A2");//Cột A dòng 2 và dòng 3
                row23_STT.Merge();
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô Mã Sản phẩm :
                Range row23_MaNhanVien = ws.get_Range("B2", "B2");//Cột B dòng 2 và dòng 3
                row23_MaNhanVien.Merge();

                row23_MaNhanVien.Font.Name = fontName;
                row23_MaNhanVien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaNhanVien.Value2 = "Mã Nhân Viên";
                row23_MaNhanVien.ColumnWidth = 20;
                row23_MaNhanVien.Font.Size = fontSizeTenTruong;
                //Tạo Ô Tên Sản phẩm :
                Range row23_MaDinhDanh = ws.get_Range("C2", "C2");//Cột C dòng 2 và dòng 3
                row23_MaDinhDanh.Merge();
                row23_MaDinhDanh.Font.Size = fontSizeTenTruong;
                row23_MaDinhDanh.Font.Name = fontName;
                row23_MaDinhDanh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaDinhDanh.ColumnWidth = 20;
                row23_MaDinhDanh.Value2 = "Mã Định Danh";

                Range row23_HoTen = ws.get_Range("D2", "D2");//Cột C dòng 2 và dòng 3
                row23_HoTen.Merge();
                row23_HoTen.Font.Size = fontSizeTenTruong;
                row23_HoTen.Font.Name = fontName;
                row23_HoTen.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_HoTen.ColumnWidth = 20;
                row23_HoTen.Value2 = "Họ Tên";

                //Tạo Ô Giá Sản phẩm :
                Range row2_NgayChamCong = ws.get_Range("E2", "E2");//Cột D->E của dòng 2
                row2_NgayChamCong.Merge();
                row2_NgayChamCong.Font.Size = fontSizeTenTruong;
                row2_NgayChamCong.Font.Name = fontName;
                row2_NgayChamCong.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_NgayChamCong.ColumnWidth = 20;
                row2_NgayChamCong.Value2 = "Ngày Chấm Công";

                //Tạo Ô Giá Nhập:
                Range row3_GioChamCong = ws.get_Range("F2", "F2");//Ô D3
                row3_GioChamCong.Font.Size = fontSizeTenTruong;
                row3_GioChamCong.Font.Name = fontName;
                row3_GioChamCong.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_GioChamCong.Value2 = "Giờ Vào";
                row3_GioChamCong.ColumnWidth = 20;

                //Tạo Ô Giá Xuất:
                Range row3_LoaiChamCong = ws.get_Range("G2", "G2");//Ô E3
                row3_LoaiChamCong.Font.Size = fontSizeTenTruong;
                row3_LoaiChamCong.Font.Name = fontName;
                row3_LoaiChamCong.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_LoaiChamCong.Value2 = "Giờ Ra";
                row3_LoaiChamCong.ColumnWidth = 20;

                Range row3_MaThietBi = ws.get_Range("H2", "H2");//Ô E3
                row3_MaThietBi.Font.Size = fontSizeTenTruong;
                row3_MaThietBi.Font.Name = fontName;
                row3_MaThietBi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_MaThietBi.Value2 = "Qua Đêm";
                row3_MaThietBi.ColumnWidth = 20;
                Range row3_NguonThucHien = ws.get_Range("I2", "I2");//Ô E3
                row3_NguonThucHien.Font.Size = fontSizeTenTruong;
                row3_NguonThucHien.Font.Name = fontName;
                row3_NguonThucHien.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_NguonThucHien.Value2 = "Mã Chấm Công";
                row3_NguonThucHien.ColumnWidth = 20;
                Range row3_MaChamCong = ws.get_Range("J2", "J2");//Ô E3
                row3_MaChamCong.Font.Size = fontSizeTenTruong;
                row3_MaChamCong.Font.Name = fontName;
                row3_MaChamCong.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_MaChamCong.Value2 = "Tên Máy Chấm Công";
                row3_MaChamCong.ColumnWidth = 20;
                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "J2");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 2;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 2 để vào vòng lặp nó ++ thành 3)

                System.Data.DataTable tCxC = (System.Data.DataTable)dataGridView1.DataSource;
                foreach (DataRow sp in tCxC.Rows)
                {
                    stt++;
                    row++;
                    dynamic[] arr = 
                        { 
                        stt, sp.Field<int>("MaNhanVienGrid1"), 
                        sp.Field<int>("MaDinhDanhGrid1"), 
                        sp.Field<string>("HoTen"), 
                        sp.Field<DateTime>("NgayChamCongGrid1").ToShortDateString() , 
                        sp.Field<DateTime>("GioVaoGrid1").ToShortTimeString(), 
                        sp.Field<DateTime>("GioRaGrid1").ToShortTimeString(), 
                        sp.Field<string>("QuaDem"), 
                        sp.Field<int>("MaChamCongGrid1"), 
                        sp.Field<string>("TenMayGrid1") 
                    };
                    Range rowData = ws.get_Range("A" + row, "J" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "J" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            barButtonItem16.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}