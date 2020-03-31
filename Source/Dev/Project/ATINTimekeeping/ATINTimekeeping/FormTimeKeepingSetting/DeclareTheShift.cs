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
            textEdit1.Text = caLamViec.TenCaLamViec;
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
            checkBox1.Checked = caLamViec.TruGioDiTre  == null ? false : (bool)caLamViec.TruGioDiTre;
            checkBox4.Checked = caLamViec.TruGioVeSom == null ? false : (bool)caLamViec.TruGioVeSom;
            numericUpDown5.Value = caLamViec.ThoiGianDiTreChoPhep==null? 0:(int)caLamViec.ThoiGianDiTreChoPhep;
            numericUpDown8.Value = caLamViec.ThoiGianVeSomChoPhep == null ? 0 : (int)caLamViec.ThoiGianVeSomChoPhep;
            checkBox6.Checked = caLamViec.SDMucTangCaHienTai == null ? false : (bool)caLamViec.SDMucTangCaHienTai;
            checkBox5.Checked = caLamViec.SDMucTangCaCuoiTuan == null ? false : (bool)caLamViec.SDMucTangCaCuoiTuan;
            checkBox8.Checked = caLamViec.SDMucTangCaNgayLe == null ? false : (bool)caLamViec.SDMucTangCaNgayLe;
            checkBox7.Checked = (caLamViec.TangCaTruocGLV == null|| caLamViec.TangCaTruocGLV ==0) ? false : true;
            checkBox10.Checked = checkBox7.Checked = (caLamViec.TangCaSauGLV == null || caLamViec.TangCaSauGLV == 0) ? false : true;



        }
        private CaLamViec GetCaLamViec()
        {
            CaLamViec caLamViec = new CaLamViec();

            return caLamViec;
        }


    }
}
