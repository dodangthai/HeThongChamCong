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
    public partial class ChucVu : UserControl
    {
        public ChucVu()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        private void load()
        {
            dt.Clear();
            dt = cl.LayChucVu("0");
            dataGridView1.DataSource = dt;
            btnLuu.Enabled = false;
            txtTenCV.Text = null;
            txtMaCV.Text = null;
            lbTB.Text = null;
        }
        private void ChucVu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtTenCV.Text = null;
            txtMaCV.Text = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (!string.IsNullOrEmpty(txtMaCV.Text))
                {
                    if (!string.IsNullOrEmpty(txtMaCV.Text))
                    {
                        dr = cl.ThemChucVu(txtMaCV.Text, txtTenCV.Text);
                        lbTB.Text = "Đã lưu!!";
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                        txtTenCV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi");
                    txtMaCV.Focus();
                }
            //}
            //catch (Exception)
            //{
                
            //    MessageBox.Show("Sai mã 'Chức Vụ'!!");
            //}
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaCV.Text))
                {
                    if (!string.IsNullOrEmpty(txtMaCV.Text))
                    {
                        dr = cl.CapNhatChucVu(txtMaCV.Text, txtTenCV.Text);
                        lbTB.Text = "Sửa thành công!!";
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                        txtTenCV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi");
                    txtMaCV.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chuyển hết nhân viên đang giữ chức vụ hiện tại trước khi sửa");
            }
        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn thật sự muốn xóa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dr = cl.XoaCapNhat(txtMaCV.Text);
                    lbTB.Text = "Đã xóa!!";
                    load();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng chuyển hết nhân viên đang giữ chức vụ hiện tại trước khi xóa");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV.Text = dataGridView1.CurrentRow.Cells["MaCV"].Value.ToString();
            txtTenCV.Text = dataGridView1.CurrentRow.Cells["TenCV"].Value.ToString();
        }
    }
}
