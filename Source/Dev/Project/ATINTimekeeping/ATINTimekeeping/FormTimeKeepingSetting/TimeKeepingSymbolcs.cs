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
    public partial class TimeKeepingSymbolcs : Form
    {
        private static TimeKeepingSymbolcs obj;
        //using Singleton to create only one Instance of form
        private TimeKeepingSymbolcs()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static TimeKeepingSymbolcs CreateInstance()
        {
            if (obj == null)
                return obj = new TimeKeepingSymbolcs();
            else
                return obj;
        }
        public static TimeKeepingSymbolcs GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
            obj = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CleanObj();
        }

        private void TimeKeepingSymbolcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }

        private void Set()
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            var lstkyhieu = context.spGetAllKyHieuChamCong().OrderBy(x=>(x.MaKyHieu)).ToList();
            textEdit1.Text = lstkyhieu[0].TenKyHieu;
            checkBox1.Checked = lstkyhieu[0].SuDung;
            textEdit1.Tag = lstkyhieu[0];
            textEdit2.Text = lstkyhieu[1].TenKyHieu;
            checkBox2.Checked = lstkyhieu[1].SuDung;
            textEdit2.Tag = lstkyhieu[1];
            textEdit3.Text = lstkyhieu[2].TenKyHieu;
            checkBox3.Checked = lstkyhieu[2].SuDung;
            textEdit3.Tag = lstkyhieu[2];
            textEdit4.Text = lstkyhieu[3].TenKyHieu;
            checkBox4.Checked = lstkyhieu[3].SuDung;
            textEdit4.Tag = lstkyhieu[3];
            textEdit5.Text = lstkyhieu[4].TenKyHieu;
            checkBox5.Checked = lstkyhieu[4].SuDung;
            textEdit5.Tag = lstkyhieu[4];
            textEdit6.Text = lstkyhieu[5].TenKyHieu;
            checkBox6.Checked = lstkyhieu[5].SuDung;
            textEdit6.Tag = lstkyhieu[5];
            textEdit7.Text = lstkyhieu[6].TenKyHieu;
            checkBox7.Checked = lstkyhieu[6].SuDung;
            textEdit7.Tag = lstkyhieu[6];
            textEdit8.Text = lstkyhieu[7].TenKyHieu;
            checkBox8.Checked = lstkyhieu[7].SuDung;
            textEdit8.Tag = lstkyhieu[7];
            textEdit9.Text = lstkyhieu[8].TenKyHieu;
            checkBox9.Checked = lstkyhieu[8].SuDung;
            textEdit9.Tag = lstkyhieu[8];
        }
        private void Save()
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            context.spUpdateKyHeuChamCong((textEdit1.Tag as KyHieuChamCong).MaKyHieu, (textEdit1.Tag as KyHieuChamCong).TenKyHieu, checkBox1.Checked);
            context.spUpdateKyHeuChamCong((textEdit2.Tag as KyHieuChamCong).MaKyHieu, (textEdit2.Tag as KyHieuChamCong).TenKyHieu, checkBox2.Checked);
            context.spUpdateKyHeuChamCong((textEdit3.Tag as KyHieuChamCong).MaKyHieu, (textEdit3.Tag as KyHieuChamCong).TenKyHieu, checkBox3.Checked);
            context.spUpdateKyHeuChamCong((textEdit4.Tag as KyHieuChamCong).MaKyHieu, (textEdit4.Tag as KyHieuChamCong).TenKyHieu, checkBox4.Checked);
            context.spUpdateKyHeuChamCong((textEdit5.Tag as KyHieuChamCong).MaKyHieu, (textEdit5.Tag as KyHieuChamCong).TenKyHieu, checkBox5.Checked);
            context.spUpdateKyHeuChamCong((textEdit6.Tag as KyHieuChamCong).MaKyHieu, (textEdit6.Tag as KyHieuChamCong).TenKyHieu, checkBox6.Checked);
            context.spUpdateKyHeuChamCong((textEdit7.Tag as KyHieuChamCong).MaKyHieu, (textEdit7.Tag as KyHieuChamCong).TenKyHieu, checkBox7.Checked);
            context.spUpdateKyHeuChamCong((textEdit8.Tag as KyHieuChamCong).MaKyHieu, (textEdit8.Tag as KyHieuChamCong).TenKyHieu, checkBox8.Checked);
            context.spUpdateKyHeuChamCong((textEdit9.Tag as KyHieuChamCong).MaKyHieu, (textEdit9.Tag as KyHieuChamCong).TenKyHieu, checkBox9.Checked);
        }
        private void TimeKeepingSymbolcs_Load(object sender, EventArgs e)
        {
            Set();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }
    }
}
