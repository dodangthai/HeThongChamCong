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
using ATINTimekeeping.Model;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace ATINTimekeeping.ChamCongVaBaoBieu
{
    public partial class DiemDanh : DevExpress.XtraEditors.XtraForm
    {
        public DiemDanh()
        {
            InitializeComponent();
        }
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

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            btnThucHien.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            ATINChamCongEntities context = new ATINChamCongEntities();
            int TongSoNV = context.Nguois.Count();
            int TongSoNVDangHD = context.Nguois.Where(x => (x.TrangThaiHoatDong == 1 || x.TrangThaiHoatDong == 2)).Count();
            int TongSoNVDaDiemDanh = 0;
            List<Nguoi> lstNhanVienChuaDiemDanh = new List<Nguoi>();
            foreach (var nguoi in context.Nguois.Where(x => (x.TrangThaiHoatDong == 1 || x.TrangThaiHoatDong == 2)).ToList())
            {
                if (context.spGetAllViewGioNguonOrderByNgayGio(nguoi.MaNguoi, dateChonNgay.Value, dateChonNgay.Value).Count() > 0)
                    TongSoNVDaDiemDanh++;
                else
                    lstNhanVienChuaDiemDanh.Add(nguoi);
            }
            try
            {
                string saveExcelFile = @"C:\ĐiemDanh_report.xlsx";

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
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 12;
                int fontSizeNoiDung = 11;
                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "D1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = "Điểm Danh";

                Range row23_TongNV = ws.get_Range("A2", "A3");
                row23_TongNV.Merge();
                row23_TongNV.Font.Size = fontSizeTenTruong;
                row23_TongNV.Font.Name = fontName;
                row23_TongNV.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TongNV.Value2 = "Tổng số nhân viên";
                row23_TongNV.Columns.AutoFit();

                Range row23_TongNVDangHD = ws.get_Range("B2", "B3");
                row23_TongNVDangHD.Merge();
                row23_TongNVDangHD.Font.Name = fontName;
                row23_TongNVDangHD.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TongNVDangHD.Value2 = "Tổng số nhân viên đang hoạt động";
                row23_TongNVDangHD.Font.Size = fontSizeTenTruong;
                row23_TongNVDangHD.Columns.AutoFit();


                Range row23_NVDaDiemDanh = ws.get_Range("C2", "C3");
                row23_NVDaDiemDanh.Merge();
                row23_NVDaDiemDanh.Font.Size = fontSizeTenTruong;
                row23_NVDaDiemDanh.Font.Name = fontName;
                row23_NVDaDiemDanh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_NVDaDiemDanh.Value2 = "Tổng số nhân viên đã điểm danh";
                row23_NVDaDiemDanh.Columns.AutoFit();



                Range row23_TongNVChuaDiemDanh = ws.get_Range("D2", "D3");
                row23_TongNVChuaDiemDanh.Merge();
                row23_TongNVChuaDiemDanh.Font.Size = fontSizeTenTruong;
                row23_TongNVChuaDiemDanh.Font.Name = fontName;
                row23_TongNVChuaDiemDanh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TongNVChuaDiemDanh.Value2 = "Tổng số nhân viên chưa điểm danh";
                row23_TongNVChuaDiemDanh.Columns.AutoFit();

                Range row23_listNV = ws.get_Range("A5", "D5");
                row23_listNV.Merge();
                row23_listNV.Font.Size = fontSizeTenTruong;
                row23_listNV.Font.Name = fontName;
                row23_listNV.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_listNV.Value2 = "Danh sách nhân viên chưa điểm danh(nếu có)";

                Range rowData1 = ws.get_Range("A" + 4, "D" + 4);
                dynamic[] arr = { TongSoNV, TongSoNVDangHD, TongSoNVDaDiemDanh, TongSoNVDangHD - TongSoNVDaDiemDanh };
                rowData1.Font.Size = fontSizeNoiDung;
                rowData1.Font.Name = fontName;
                rowData1.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                rowData1.Value2 = arr;

                int row = 5;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 2 để vào vòng lặp nó ++ thành 3)
                foreach (var sp in lstNhanVienChuaDiemDanh)
                {
                    row++;
                    Range rowData = ws.get_Range("A" + row, "D" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Merge();
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = sp.HoTen + "(" + sp.MaNguoi + ")";
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "D" + row));

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
            btnThucHien.Enabled = true;
            Cursor.Current = Cursors.Default;
            this.Close();
        }
    }
}