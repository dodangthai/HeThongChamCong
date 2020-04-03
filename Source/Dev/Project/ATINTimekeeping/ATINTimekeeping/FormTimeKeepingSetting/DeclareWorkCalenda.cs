using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //private void Save(string MaCaLamViecChon, CaLamViec caLamViec, ref bool allowInsert)
        //{
        //    try
        //    {
        //        if (allowInsert)
        //        {
        //            ATINChamCongEntities context = new ATINChamCongEntities();
        //            context.spInsertCaLamViec(
        //             caLamViec.MaCaLamViec,
        //             caLamViec.TenCaLamViec,
        //             caLamViec.GioBatDauCa,
        //             caLamViec.GioKetThucCa,
        //             caLamViec.GioBatDauGiaiLao,
        //             caLamViec.GioKetThucGiaiLao,
        //             caLamViec.TongGio,
        //             caLamViec.DiemCong,
        //             caLamViec.GioVaoSomNhatDuocTinhCa,
        //             caLamViec.GioVaoMuonNhatDuocTinhCa,
        //             caLamViec.GioRaMuonNhatDuocTinhCa,
        //             caLamViec.GioRaSomNhatDuocTinhCa,
        //             caLamViec.KhongCoGioRa,
        //             caLamViec.KhongCoGioVao,
        //             caLamViec.TruGioDiTre,
        //             caLamViec.ThoiGianDiTreChoPhep,
        //             caLamViec.TruGioVeSom,
        //             caLamViec.ThoiGianVeSomChoPhep,
        //             caLamViec.SDMucTangCaHienTai,
        //             caLamViec.MucTangCaHienTai,
        //             caLamViec.SDMucTangCaCuoiTuan,
        //             caLamViec.MucTangCaCuoiTuan,
        //             caLamViec.SDMucTangCaNgayLe,
        //             caLamViec.MucTangCaNgayLe,
        //             caLamViec.SDTangCaTruocGLV,
        //             caLamViec.TangCaTruocGLV,
        //             caLamViec.SDTangCaSauGLV,
        //             caLamViec.TangCaSauGLV,
        //             caLamViec.SDTongGLVTinhTangCa,
        //             caLamViec.TongGLVTinhTangCa,
        //             caLamViec.GioiHanTCMucMot,
        //             caLamViec.GioiHanTCMucHai,
        //             caLamViec.SDMucTangCaCuaTangCaCuoiTuan,
        //             caLamViec.MucTangCaCuaTangCaCuoiTuan,
        //             caLamViec.SDMucTangCaCuaTangCaNgayLe,
        //             caLamViec.MucTangCaCuaTangCaNgayLe,
        //             caLamViec.GioiHanTCTruocGLV,
        //             caLamViec.GioiHanTCSauGLV,
        //             caLamViec.CaQuaDem,
        //             caLamViec.TachGioCaDemTu,
        //             caLamViec.TachGioCaDemDen
        //             );
        //        }
        //        else
        //        {
        //            ATINChamCongEntities context = new ATINChamCongEntities();
        //            context.spUpdateCaLamViec(
        //             MaCaLamViecChon,
        //             caLamViec.MaCaLamViec,
        //             caLamViec.TenCaLamViec,
        //             caLamViec.GioBatDauCa,
        //             caLamViec.GioKetThucCa,
        //             caLamViec.GioBatDauGiaiLao,
        //             caLamViec.GioKetThucGiaiLao,
        //             caLamViec.TongGio,
        //             caLamViec.DiemCong,
        //             caLamViec.GioVaoSomNhatDuocTinhCa,
        //             caLamViec.GioVaoMuonNhatDuocTinhCa,
        //             caLamViec.GioRaMuonNhatDuocTinhCa,
        //             caLamViec.GioRaSomNhatDuocTinhCa,
        //             caLamViec.KhongCoGioRa,
        //             caLamViec.KhongCoGioVao,
        //             caLamViec.TruGioDiTre,
        //             caLamViec.ThoiGianDiTreChoPhep,
        //             caLamViec.TruGioVeSom,
        //             caLamViec.ThoiGianVeSomChoPhep,
        //             caLamViec.SDMucTangCaHienTai,
        //             caLamViec.MucTangCaHienTai,
        //             caLamViec.SDMucTangCaCuoiTuan,
        //             caLamViec.MucTangCaCuoiTuan,
        //             caLamViec.SDMucTangCaNgayLe,
        //             caLamViec.MucTangCaNgayLe,
        //             caLamViec.SDTangCaTruocGLV,
        //             caLamViec.TangCaTruocGLV,
        //             caLamViec.SDTangCaSauGLV,
        //             caLamViec.TangCaSauGLV,
        //             caLamViec.SDTongGLVTinhTangCa,
        //             caLamViec.TongGLVTinhTangCa,
        //             caLamViec.GioiHanTCMucMot,
        //             caLamViec.GioiHanTCMucHai,
        //             caLamViec.SDMucTangCaCuaTangCaCuoiTuan,
        //             caLamViec.MucTangCaCuaTangCaCuoiTuan,
        //             caLamViec.SDMucTangCaCuaTangCaNgayLe,
        //             caLamViec.MucTangCaCuaTangCaNgayLe,
        //             caLamViec.GioiHanTCTruocGLV,
        //             caLamViec.GioiHanTCSauGLV,
        //             caLamViec.CaQuaDem,
        //             caLamViec.TachGioCaDemTu,
        //             caLamViec.TachGioCaDemDen
        //             );
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}

        //public static List<CaLamViec> LoadAllCaLamViec()
        //{
        //    List<CaLamViec> caLamViecs = new List<CaLamViec>();
        //    try
        //    {
        //        ATINChamCongEntities context = new ATINChamCongEntities();
        //        caLamViecs = context.spGetAllCaLamViec().ToList();
        //        return caLamViecs;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        return null;
        //    }
        //}

        //private void RefreshGrid()
        //{
        //    List<CaLamViec> caLamViecs = LoadAllCaLamViec();
        //    dataGridView1.DataSource = caLamViecs;
        //}
        //private void DeleteCaLamViec(string MaCaLamViec)
        //{
        //    try
        //    {
        //        var context = new ATINChamCongEntities();
        //        context.spDeleteCaLamViec(MaCaLamViec);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }

        //}

            private void SetLichTrinh()
        {

        }
        private void GetLichTrinh()
        {

        }
        private void DeclareWorkCalenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = new SubDeclareWorkCalendar(WorkCalendarShowType);
            f.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (this.dataGridView1.SelectedRows.Count > 0)
            //{
            //    var caLamViec = dataGridView1.SelectedRows[0].DataBoundItem as CaLamViec;
            //    SetCaLamViec(caLamViec);
            //}
            //allowInsert = false;
            //barButtonItemAddNew.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                WorkCalendarShowType = "week";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                WorkCalendarShowType = "month";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                WorkCalendarShowType = "year";
        }
    }
}
