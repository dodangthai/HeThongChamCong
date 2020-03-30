using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyNhanSu.CT
{
    public partial class ThuongPhat : UserControl
    {
        public ThuongPhat()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        string mapb = null, manv = null, tenpb = null;
        string tennv = null, loai = null; 
        int tien = 0, thang = DateTime.Now.Month, nam = DateTime.Now.Year;
        DateTime nd, nc;
        private void load()
        {
            nd = Convert.ToDateTime(thang + "/1" + "/" + nam);
            nc = Convert.ToDateTime(thang + "/30" + "/" + nam);
            txtLyDo.Enabled = false;
            txtT.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            rdThuong.Enabled = false;
            rdPhat.Enabled = false;
            cbThang.Text = thang.ToString(); ;
            cbNam.Text = nam.ToString();
            cbPhongBan.Text = "Tất Cả";
            dt.Clear();
            dt = cl.LayNhanVienTuMaPB("0",nd,nc);
            dataGridView1.DataSource = dt;
        }
        private void ThuongPhat_Load(object sender, EventArgs e)
        {
            load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLyDo.Enabled = false;
            txtT.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtLyDo.Text = null;
            txtT.Text = null;
            if (cbPhongBan.Text == "Tất Cả")
                load();
            else
            {
                dr = cl.layMaPBTuTenPB(cbPhongBan.Text);
                while (dr.Read())
                    mapb = dr.GetString(0);
                dt.Clear();
                dt = cl.LayNhanVienTuMaPB(mapb, nd, nc);
                dataGridView1.DataSource = dt;
            }
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtLyDo.Enabled = true;
            txtT.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            rdThuong.Enabled = true;
            rdPhat.Enabled = true;
            tennv = dataGridView1.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["Loai"].Value.ToString() == "Thưởng")
            {
                rdThuong.Checked = true;
                loai = "Thưởng";
            }
            else
            {
                rdPhat.Checked = true;
                loai = "Phạt";
            }
            txtLyDo.Text = dataGridView1.CurrentRow.Cells["LyDo"].Value.ToString();
            txtT.Text = dataGridView1.CurrentRow.Cells["VND"].Value.ToString();
            cbPhongBan.Text = layTenPhongBan(layMaNhanVien(tennv));
        }
        private string layMaNhanVien(string tennv)
        {
            dr = cl.layMaNVTuTenNV(tennv);
            while (dr.Read())
                manv = dr.GetString(0);
            return manv;
        }
        private string layTenPhongBan(string ma)
        {
            dr = cl.layTenPBTuMaNV(ma);
            while (dr.Read())
                tenpb = dr.GetString(0);
            return tenpb;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPhongBan.Text) || cbPhongBan.Text == "Tất Cả")
                MessageBox.Show("Vui lòng chọn Phòng Ban và Tên nhân viên trước");
            else
            {
                txtLyDo.Enabled = true;
                txtT.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                rdThuong.Enabled = true;
                rdPhat.Enabled = true;
                txtLyDo.Text = null;
                txtT.Text = null;
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (rdPhat.Checked == true)
                loai = "Phạt";
            else loai = "Thưởng";
            if(!string.IsNullOrEmpty(txtLyDo.Text))
            {
                if (!string.IsNullOrEmpty(txtT.Text))
                {
                    dr = cl.ThemThuongPhat(layMaNhanVien(tennv), loai, Convert.ToInt32(txtT.Text), txtLyDo.Text, DateTime.Now);
                    load();
                }
                else
                {

                }
            }
            else
            {

            }
           
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rdPhat.Checked == true)
                loai = "Phạt";
            else loai = "Thưởng";
            if (MessageBox.Show("Bạn Thật Sự Muốn Xóa!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dr = cl.XoaThuongPhat(layMaNhanVien(tennv), loai, Convert.ToInt32(txtT.Text), txtLyDo.Text);
                load();
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            nd = Convert.ToDateTime(cbThang.Text + "/1" + "/" + cbNam.Text);
            nc = Convert.ToDateTime(cbThang.Text + "/30" + "/" + cbNam.Text);
            dt.Clear();
            dt = cl.LayNhanVienTuMaPB("0", nd, nc);
            dataGridView1.DataSource = dt;
        }

       

        
  
    }
}
