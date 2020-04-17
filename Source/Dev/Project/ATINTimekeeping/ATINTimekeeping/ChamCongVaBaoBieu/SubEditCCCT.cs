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
    public partial class SubEditCCCT : Form
    {
        private int MaChamCongCHiTiet;
        public SubEditCCCT(int MaChamCong, int MaChamCongChiTiet, DateTime GioGoc)
        {

            InitializeComponent();
            textBox1.Text = MaChamCong.ToString().Trim();
            dateEdit1.DateTime = GioGoc;
            dateEdit2.DateTime = GioGoc;
            this.MaChamCongCHiTiet = MaChamCongChiTiet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            if (dateEdit1.DateTime.Year != dateEdit2.DateTime.Year
                &&
                dateEdit1.DateTime.Month != dateEdit2.DateTime.Month
                &&
                dateEdit1.DateTime.Day != dateEdit2.DateTime.Day)
            {
                MessageBox.Show("Không được phép đổi ngày");
                dateEdit2.DateTime = dateEdit1.DateTime;
            }
            else
            {
                context.spUpdateChamCongChiTiet(MaChamCongCHiTiet, dateEdit2.DateTime);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
