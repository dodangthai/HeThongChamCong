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
    public partial class LayDaySmbol : Form
    {
        private static LayDaySmbol obj;
        //using Singleton to create only one Instance of form
        private LayDaySmbol()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static LayDaySmbol CreateInstance()
        {
            if (obj == null)
                return obj = new LayDaySmbol();
            else
                return obj;
        }
        public static LayDaySmbol GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
                obj = null;
        }

        private void LayDaySmbol_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }

        private void Set()
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            var lstKyHieuVang = context.spGetAllKyHieuCacLoaiVang();
            dataGridView1.DataSource = lstKyHieuVang;

        }

        private void LayDaySmbol_Load(object sender, EventArgs e)
        {
            Set();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            if (dataGridView1.CurrentCell != null)
            {
                var kyHieuVang = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as KyHieuCacLoaiVang;
                if (dataGridView1.CurrentCell.ColumnIndex == 3)
                {
                    context.spUpdateKyHieuCacLoaiVang(kyHieuVang.MaKyHieu, (bool)dataGridView1.CurrentCell.Value, (bool)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    context.spUpdateKyHieuCacLoaiVang(kyHieuVang.MaKyHieu, (bool)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value, (bool)dataGridView1.CurrentCell.Value);

                }
            }
        }
    }
}
