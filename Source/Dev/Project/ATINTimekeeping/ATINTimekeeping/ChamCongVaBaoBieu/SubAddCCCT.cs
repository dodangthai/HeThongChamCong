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

namespace ATINTimekeeping.ChamCongVaBaoBieu
{
    public partial class SubAddCCCT : Form
    {
        private int MaNhanVien;
        public SubAddCCCT(int MaNhanVien)
        {
            InitializeComponent();
            this.MaNhanVien = MaNhanVien;
            textBox1.Text = MaNhanVien.ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            if (checkBox2.Checked == false && checkBox1.Checked == false)
                return;
            if(checkBox1.Checked == true)
            {
                context.spInsertChamCongChiTiet(MaNhanVien, dateEdit1.DateTime, "IN", 3);
            }
            if (checkBox2.Checked == true)
            {
                context.spInsertChamCongChiTiet(MaNhanVien, dateEdit2.DateTime, "OUT", 3);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
