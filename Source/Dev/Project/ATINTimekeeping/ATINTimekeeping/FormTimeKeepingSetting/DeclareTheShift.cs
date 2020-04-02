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

namespace ATINTimekeeping.FormTimeKeepingSetting
{
    public partial class DeclareTheShift : Form
    {
        private static DeclareTheShift obj;
        private bool allowInsert = false;
        public DeclareTheShift()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static DeclareTheShift CreateInstance()
        {
            if (obj == null)
                return obj = new DeclareTheShift();
            else
                return obj;
        }
        public static DeclareTheShift GetInstance()
        {
            return obj;
        }

        private void DeclareTheShift_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }

        private void SetCaLamViec(CaLamViec caLamViec)
        {
            textEdit1.Text = caLamViec.MaCaLamViec;
            textEdit2.Text = caLamViec.TenCaLamViec;
            timeSpanEdit1.TimeSpan = caLamViec.GioBatDauCa;
            timeSpanEdit2.TimeSpan = caLamViec.GioKetThucCa;
            timeSpanEdit3.TimeSpan = caLamViec.GioBatDauGiaiLao == null ? TimeSpan.Zero : (TimeSpan)caLamViec.GioBatDauGiaiLao;
            timeSpanEdit4.TimeSpan = caLamViec.GioKetThucGiaiLao == null ? TimeSpan.Zero : (TimeSpan)caLamViec.GioKetThucGiaiLao;
            numericUpDown26.Value = caLamViec.TongGio;
            numericUpDown26.Value = caLamViec.DiemCong;
            timeSpanEdit5.TimeSpan = caLamViec.GioVaoSomNhatDuocTinhCa;
            timeSpanEdit6.TimeSpan = caLamViec.GioVaoMuonNhatDuocTinhCa;
            timeSpanEdit7.TimeSpan = caLamViec.GioRaMuonNhatDuocTinhCa;
            timeSpanEdit8.TimeSpan = caLamViec.GioRaSomNhatDuocTinhCa;
            numericUpDown2.Value = caLamViec.KhongCoGioRa;
            numericUpDown3.Value = caLamViec.KhongCoGioVao;
            checkBox1.Checked = caLamViec.TruGioDiTre == null ? false : (bool)caLamViec.TruGioDiTre;
            checkBox4.Checked = caLamViec.TruGioVeSom == null ? false : (bool)caLamViec.TruGioVeSom;
            numericUpDown5.Value = caLamViec.ThoiGianDiTreChoPhep == null ? 0 : (int)caLamViec.ThoiGianDiTreChoPhep;
            numericUpDown8.Value = caLamViec.ThoiGianVeSomChoPhep == null ? 0 : (int)caLamViec.ThoiGianVeSomChoPhep;
            checkBox6.Checked = caLamViec.SDMucTangCaHienTai == null ? false : (bool)caLamViec.SDMucTangCaHienTai;
            checkBox5.Checked = caLamViec.SDMucTangCaCuoiTuan == null ? false : (bool)caLamViec.SDMucTangCaCuoiTuan;
            checkBox8.Checked = caLamViec.SDMucTangCaNgayLe == null ? false : (bool)caLamViec.SDMucTangCaNgayLe;
            checkBox7.Checked = caLamViec.SDTangCaTruocGLV == null ? false : (bool)caLamViec.SDTangCaTruocGLV;
            checkBox10.Checked = caLamViec.SDTangCaSauGLV == null ? false : (bool)caLamViec.SDTangCaSauGLV;
            checkBox9.Checked = caLamViec.SDTongGLVTinhTangCa == null ? false : (bool)caLamViec.SDTongGLVTinhTangCa;
            numericUpDown9.Value = caLamViec.MucTangCaHienTai == null ? 0 : (int)caLamViec.MucTangCaHienTai;
            numericUpDown10.Value = caLamViec.MucTangCaCuoiTuan == null ? 0 : (int)caLamViec.MucTangCaCuoiTuan;
            numericUpDown11.Value = caLamViec.MucTangCaNgayLe == null ? 0 : (int)caLamViec.MucTangCaNgayLe;
            numericUpDown12.Value = caLamViec.TangCaTruocGLV == null ? 0 : (int)caLamViec.TangCaTruocGLV;
            numericUpDown13.Value = caLamViec.TangCaSauGLV == null ? 0 : (int)caLamViec.TangCaSauGLV;
            numericUpDown14.Value = caLamViec.TongGLVTinhTangCa == null ? 0 : (int)caLamViec.TongGLVTinhTangCa;
            numericUpDown20.Value = caLamViec.GioiHanTCMucMot == null ? 0 : (int)caLamViec.GioiHanTCMucMot;
            numericUpDown19.Value = caLamViec.GioiHanTCMucHai == null ? 0 : (int)caLamViec.GioiHanTCMucHai;
            checkBox12.Checked = caLamViec.SDMucTangCaCuaTangCaCuoiTuan == null ? false : (bool)caLamViec.SDMucTangCaCuaTangCaCuoiTuan;
            checkBox11.Checked = caLamViec.SDMucTangCaCuaTangCaNgayLe == null ? false : (bool)caLamViec.SDMucTangCaCuaTangCaNgayLe;
            numericUpDown24.Value = caLamViec.MucTangCaCuaTangCaCuoiTuan == null ? 0 : (int)caLamViec.MucTangCaCuaTangCaCuoiTuan;
            numericUpDown23.Value = caLamViec.MucTangCaCuaTangCaNgayLe == null ? 0 : (int)caLamViec.MucTangCaCuaTangCaNgayLe;
            numericUpDown22.Value = caLamViec.GioiHanTCTruocGLV == null ? 0 : (int)caLamViec.GioiHanTCTruocGLV;
            numericUpDown21.Value = caLamViec.GioiHanTCSauGLV == null ? 0 : (int)caLamViec.GioiHanTCSauGLV;
            checkBox13.Checked = caLamViec.CaQuaDem == null ? false : (bool)caLamViec.CaQuaDem;
            timeSpanEdit10.TimeSpan = caLamViec.TachGioCaDemTu == null ? TimeSpan.Zero : (TimeSpan)caLamViec.TachGioCaDemTu;
            timeSpanEdit9.TimeSpan = caLamViec.TachGioCaDemDen == null ? TimeSpan.Zero : (TimeSpan)caLamViec.TachGioCaDemDen;
        }
        private  CaLamViec GetCaLamViec()
        {
            CaLamViec caLamViec = new CaLamViec();

            caLamViec.MaCaLamViec = textEdit1.Text;
            caLamViec.TenCaLamViec = textEdit2.Text;
            caLamViec.GioBatDauCa = timeSpanEdit1.TimeSpan;
            caLamViec.GioKetThucCa = timeSpanEdit2.TimeSpan;
            caLamViec.GioBatDauGiaiLao = timeSpanEdit3.TimeSpan;
            caLamViec.GioKetThucGiaiLao = timeSpanEdit4.TimeSpan;
            caLamViec.TongGio = (int)numericUpDown26.Value;
            caLamViec.DiemCong = (int)numericUpDown26.Value;
            caLamViec.GioVaoSomNhatDuocTinhCa = timeSpanEdit5.TimeSpan;
            caLamViec.GioVaoMuonNhatDuocTinhCa = timeSpanEdit6.TimeSpan;
            caLamViec.GioRaMuonNhatDuocTinhCa = timeSpanEdit7.TimeSpan;
            caLamViec.GioRaSomNhatDuocTinhCa = timeSpanEdit8.TimeSpan;
            caLamViec.KhongCoGioRa = (int)numericUpDown2.Value;
            caLamViec.KhongCoGioVao = (int)numericUpDown3.Value;
            caLamViec.TruGioDiTre = checkBox1.Checked;
            caLamViec.TruGioVeSom = checkBox4.Checked;
            caLamViec.ThoiGianDiTreChoPhep = (int)numericUpDown5.Value;
            caLamViec.ThoiGianVeSomChoPhep = (int)numericUpDown8.Value;
            caLamViec.SDMucTangCaHienTai = checkBox6.Checked;
            caLamViec.SDMucTangCaCuoiTuan = checkBox5.Checked;
            caLamViec.SDMucTangCaNgayLe = checkBox8.Checked;
            caLamViec.SDTangCaTruocGLV = checkBox7.Checked;
            caLamViec.SDTangCaSauGLV = checkBox10.Checked;
            caLamViec.SDTongGLVTinhTangCa = checkBox9.Checked;
            caLamViec.MucTangCaHienTai = (int)numericUpDown9.Value;
            caLamViec.MucTangCaCuoiTuan = (int)numericUpDown10.Value;
            caLamViec.MucTangCaNgayLe = (int)numericUpDown11.Value;
            caLamViec.TangCaTruocGLV = (int)numericUpDown12.Value;
            caLamViec.TangCaSauGLV = (int)numericUpDown13.Value;
            caLamViec.TongGLVTinhTangCa = (int)numericUpDown14.Value;
            caLamViec.GioiHanTCMucMot = (int)numericUpDown20.Value;
            caLamViec.GioiHanTCMucHai = (int)numericUpDown19.Value;
            caLamViec.SDMucTangCaCuaTangCaCuoiTuan = checkBox12.Checked;
            caLamViec.SDMucTangCaCuaTangCaNgayLe = checkBox11.Checked;
            caLamViec.MucTangCaCuaTangCaCuoiTuan = (int)numericUpDown24.Value;
            caLamViec.MucTangCaCuaTangCaNgayLe = (int)numericUpDown23.Value;
            caLamViec.GioiHanTCTruocGLV = (int)numericUpDown22.Value;
            caLamViec.GioiHanTCSauGLV = (int)numericUpDown21.Value;
            caLamViec.CaQuaDem = checkBox13.Checked;
            caLamViec.TachGioCaDemTu = timeSpanEdit10.TimeSpan;
            caLamViec.TachGioCaDemDen = timeSpanEdit9.TimeSpan;

            return caLamViec;
        }
        private void DeleteCaLamViec(string MaCaLamViec)
        {
            try
            {
                var context = new ATINChamCongEntities();
                context.spDeleteCaLamViec(MaCaLamViec);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void Save(string MaCaLamViecChon, CaLamViec caLamViec, ref bool allowInsert)
        {
            try
            {
                if (allowInsert)
                {
                    ATINChamCongEntities context = new ATINChamCongEntities();
                    context.spInsertCaLamViec(
                     caLamViec.MaCaLamViec,
                     caLamViec.TenCaLamViec,
                     caLamViec.GioBatDauCa,
                     caLamViec.GioKetThucCa,
                     caLamViec.GioBatDauGiaiLao,
                     caLamViec.GioKetThucGiaiLao,
                     caLamViec.TongGio,
                     caLamViec.DiemCong,
                     caLamViec.GioVaoSomNhatDuocTinhCa,
                     caLamViec.GioVaoMuonNhatDuocTinhCa,
                     caLamViec.GioRaMuonNhatDuocTinhCa,
                     caLamViec.GioRaSomNhatDuocTinhCa,
                     caLamViec.KhongCoGioRa,
                     caLamViec.KhongCoGioVao,
                     caLamViec.TruGioDiTre,
                     caLamViec.ThoiGianDiTreChoPhep,
                     caLamViec.TruGioVeSom,
                     caLamViec.ThoiGianVeSomChoPhep,
                     caLamViec.SDMucTangCaHienTai,
                     caLamViec.MucTangCaHienTai,
                     caLamViec.SDMucTangCaCuoiTuan,
                     caLamViec.MucTangCaCuoiTuan,
                     caLamViec.SDMucTangCaNgayLe,
                     caLamViec.MucTangCaNgayLe,
                     caLamViec.SDTangCaTruocGLV,
                     caLamViec.TangCaTruocGLV,
                     caLamViec.SDTangCaSauGLV,
                     caLamViec.TangCaSauGLV,
                     caLamViec.SDTongGLVTinhTangCa,
                     caLamViec.TongGLVTinhTangCa,
                     caLamViec.GioiHanTCMucMot,
                     caLamViec.GioiHanTCMucHai,
                     caLamViec.SDMucTangCaCuaTangCaCuoiTuan,
                     caLamViec.MucTangCaCuaTangCaCuoiTuan,
                     caLamViec.SDMucTangCaCuaTangCaNgayLe,
                     caLamViec.MucTangCaCuaTangCaNgayLe,
                     caLamViec.GioiHanTCTruocGLV,
                     caLamViec.GioiHanTCSauGLV,
                     caLamViec.CaQuaDem,
                     caLamViec.TachGioCaDemTu,
                     caLamViec.TachGioCaDemDen
                     );
                }
                else
                {
                    ATINChamCongEntities context = new ATINChamCongEntities();
                    context.spUpdateCaLamViec(
                     MaCaLamViecChon,
                     caLamViec.MaCaLamViec,
                     caLamViec.TenCaLamViec,
                     caLamViec.GioBatDauCa,
                     caLamViec.GioKetThucCa,
                     caLamViec.GioBatDauGiaiLao,
                     caLamViec.GioKetThucGiaiLao,
                     caLamViec.TongGio,
                     caLamViec.DiemCong,
                     caLamViec.GioVaoSomNhatDuocTinhCa,
                     caLamViec.GioVaoMuonNhatDuocTinhCa,
                     caLamViec.GioRaMuonNhatDuocTinhCa,
                     caLamViec.GioRaSomNhatDuocTinhCa,
                     caLamViec.KhongCoGioRa,
                     caLamViec.KhongCoGioVao,
                     caLamViec.TruGioDiTre,
                     caLamViec.ThoiGianDiTreChoPhep,
                     caLamViec.TruGioVeSom,
                     caLamViec.ThoiGianVeSomChoPhep,
                     caLamViec.SDMucTangCaHienTai,
                     caLamViec.MucTangCaHienTai,
                     caLamViec.SDMucTangCaCuoiTuan,
                     caLamViec.MucTangCaCuoiTuan,
                     caLamViec.SDMucTangCaNgayLe,
                     caLamViec.MucTangCaNgayLe,
                     caLamViec.SDTangCaTruocGLV,
                     caLamViec.TangCaTruocGLV,
                     caLamViec.SDTangCaSauGLV,
                     caLamViec.TangCaSauGLV,
                     caLamViec.SDTongGLVTinhTangCa,
                     caLamViec.TongGLVTinhTangCa,
                     caLamViec.GioiHanTCMucMot,
                     caLamViec.GioiHanTCMucHai,
                     caLamViec.SDMucTangCaCuaTangCaCuoiTuan,
                     caLamViec.MucTangCaCuaTangCaCuoiTuan,
                     caLamViec.SDMucTangCaCuaTangCaNgayLe,
                     caLamViec.MucTangCaCuaTangCaNgayLe,
                     caLamViec.GioiHanTCTruocGLV,
                     caLamViec.GioiHanTCSauGLV,
                     caLamViec.CaQuaDem,
                     caLamViec.TachGioCaDemTu,
                     caLamViec.TachGioCaDemDen
                     );
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static List<CaLamViec> LoadAllCaLamViec()
        {
            List<CaLamViec> caLamViecs = new List<CaLamViec>();
            try
            {
                ATINChamCongEntities context = new ATINChamCongEntities();
                caLamViecs = context.spGetAllCaLamViec().ToList();
                return caLamViecs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        private void RefreshGrid()
        {
            List<CaLamViec> caLamViecs = LoadAllCaLamViec();
            dataGridView1.DataSource = caLamViecs;
        }
        //add data when form load
        private void DeclareTheShift_Load(object sender, EventArgs e)
        {
            List<CaLamViec> caLamViecs = LoadAllCaLamViec();
            dataGridView1.DataSource = caLamViecs;
            //dataGridView1.Columns["MaCaLamViec"].Visible = false;
            dataGridView1.Columns["TenCaLamViec"].Visible = false;
            //dataGridView1.Columns["GioBatDauCa"].Visible = false;
            //dataGridView1.Columns["GioKetThucCa"].Visible = false;
            dataGridView1.Columns["GioBatDauGiaiLao"].Visible = false;
            dataGridView1.Columns["GioKetThucGiaiLao"].Visible = false;
            dataGridView1.Columns["TongGio"].Visible = false;
            dataGridView1.Columns["DiemCong"].Visible = false;
            dataGridView1.Columns["GioVaoSomNhatDuocTinhCa"].Visible = false;
            dataGridView1.Columns["GioVaoMuonNhatDuocTinhCa"].Visible = false;
            dataGridView1.Columns["GioRaSomNhatDuocTinhCa"].Visible = false;
            dataGridView1.Columns["GioRaMuonNhatDuocTinhCa"].Visible = false;
            dataGridView1.Columns["KhongCoGioVao"].Visible = false;
            dataGridView1.Columns["KhongCoGioRa"].Visible = false;
            dataGridView1.Columns["TruGioDiTre"].Visible = false;
            dataGridView1.Columns["ThoiGianDiTreChoPhep"].Visible = false;
            dataGridView1.Columns["TruGioVeSom"].Visible = false;
            dataGridView1.Columns["ThoiGianVeSomChoPhep"].Visible = false;
            dataGridView1.Columns["SDMucTangCaHienTai"].Visible = false;
            dataGridView1.Columns["MucTangCaHienTai"].Visible = false;
            dataGridView1.Columns["SDMucTangCaCuoiTuan"].Visible = false;
            dataGridView1.Columns["MucTangCaCuoiTuan"].Visible = false;
            dataGridView1.Columns["SDMucTangCaNgayLe"].Visible = false;
            dataGridView1.Columns["MucTangCaNgayLe"].Visible = false;
            dataGridView1.Columns["SDMucTangCaCuaTangCaCuoiTuan"].Visible = false;
            dataGridView1.Columns["MucTangCaCuaTangCaCuoiTuan"].Visible = false;
            dataGridView1.Columns["SDMucTangCaCuaTangCaNgayLe"].Visible = false;
            dataGridView1.Columns["MucTangCaCuaTangCaNgayLe"].Visible = false;
            dataGridView1.Columns["TangCaTruocGLV"].Visible = false;
            dataGridView1.Columns["TangCaSauGLV"].Visible = false;
            dataGridView1.Columns["TongGLVTinhTangCa"].Visible = false;
            dataGridView1.Columns["GioiHanTCMucMot"].Visible = false;
            dataGridView1.Columns["GioiHanTCMucHai"].Visible = false;
            dataGridView1.Columns["GioiHanTCTruocGLV"].Visible = false;
            dataGridView1.Columns["GioiHanTCSauGLV"].Visible = false;
            dataGridView1.Columns["CaQuaDem"].Visible = false;
            dataGridView1.Columns["TachGioCaDemTu"].Visible = false;
            dataGridView1.Columns["TachGioCaDemDen"].Visible = false;
            dataGridView1.Columns["SDTangCaTruocGLV"].Visible = false;
            dataGridView1.Columns["SDTangCaSauGLV"].Visible = false;
            dataGridView1.Columns["SDTongGLVTinhTangCa"].Visible = false;


        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var caLamViec = dataGridView1.SelectedRows[0].DataBoundItem as CaLamViec;
                SetCaLamViec(caLamViec);
            }
            allowInsert = false;
            barButtonItemAddNew.Enabled = true;
        }

        //allow to Insert new CaLamViec
        private void barButtonItemAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            allowInsert = true;
            barButtonItemAddNew.Enabled = false;
            //Refresh tabpage
            CaLamViec caLamViec = new CaLamViec();
            SetCaLamViec(caLamViec);

        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Update or insert
            if (dataGridView1.Rows.Count > 0)
                Save((dataGridView1.SelectedRows[0].DataBoundItem as CaLamViec).MaCaLamViec, GetCaLamViec(), ref allowInsert);
            else
                Save(null, GetCaLamViec(), ref allowInsert);
            allowInsert = false;
            barButtonItemAddNew.Enabled = true;
            RefreshGrid();
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn muốn xóa Ca: " + (dataGridView1.SelectedRows[0].DataBoundItem as CaLamViec).TenCaLamViec + " Phải không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                DeleteCaLamViec((dataGridView1.SelectedRows[0].DataBoundItem as CaLamViec).MaCaLamViec);
            allowInsert = false;
            barButtonItemAddNew.Enabled = true;
            RefreshGrid();
        }

        private void barButtonRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            allowInsert = false;
            barButtonItemAddNew.Enabled = true;
            CaLamViec caLamViec = new CaLamViec();
            SetCaLamViec(caLamViec);
            RefreshGrid();
        }
    }
}
