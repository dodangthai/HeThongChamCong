using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu.CT
{
    public partial class PhongBan : UserControl
    {
        public PhongBan()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        string maphong = null, tenphong = null, sonv = null;
        private void load()
        {
            dt.Clear();
            dt = cl.HienPhongBan("0");
            dataGridView1.DataSource = dt;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            label5.Text = null;
            label6.Text = null;
            lbSoNV.Text = null;
        }
        private void PhongBan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maphong = dataGridView1.CurrentRow.Cells["MaPB"].Value.ToString();
            tenphong = dataGridView1.CurrentRow.Cells["TenPB"].Value.ToString();
            sonv = dataGridView1.CurrentRow.Cells["SoNV"].Value.ToString();
            txtMaPB.Text = maphong;
            txtTen.Text = tenphong;
            lbSoNV.Text = sonv;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dr = cl.XoaPhongBan(maphong);
                while(dr.Read())
                {
                    MessageBox.Show("Vui lòng xóa hết nhân viên trong phòng, và nhân viên trong hợp đồng trước khi xóa phòng");
                    
                }
            }
            catch (Exception)
            {
                
            }
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMaPB.Text))
            {
                if (!string.IsNullOrEmpty(txtTen.Text))
                {
                    dr = cl.CapNhatPhongBan(maphong, txtTen.Text);
                    label7.Text = "Sửa Thành Công";
                    load();
                }
                else
                {
                    label6.Text = "Lỗi!!";
                    label5.Text = null;
                }
            }
            else
            {
                label5.Text = "Lỗi!!";
                label6.Text = null;
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPB.Text = "PB0";
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            txtTen.Text = null;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPB.Text))
            {
                if (!string.IsNullOrEmpty(txtTen.Text))
                {
                    dr = cl.ThemPhongBan(txtMaPB.Text, txtTen.Text);
                    label7.Text = "Thêm Thành Công";
                    load();
                }
                else
                {
                    label6.Text = "Lỗi!!";
                    label5.Text = null;
                }
            }
            else
            {
                label5.Text = "Lỗi!!";
                label6.Text = null;
            }
        }

  
 
    }
}
