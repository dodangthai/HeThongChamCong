using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATINTimekeeping.Model;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace ATINTimekeeping.ChamCongVaBaoBieu
{
    public partial class ViewImage : Form
    {
        public ViewImage()
        {
            InitializeComponent();
            SetDoubleBuffer(listView1, true);
            SetCombobox_Datetime_Default();
        }
        private void SetCombobox_Datetime_Default()
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            var lstMayChamCong = context.MayNhanDangs.ToList();
            comboBox1.DataSource = lstMayChamCong;
            comboBox1.DisplayMember = "TenMay";
            comboBox1.ValueMember = "MaMay";
            if (lstMayChamCong.Count > 0)
                comboBox1.SelectedIndex = 0;
            dateEdit1.DateTime = DateTime.Now;
        }

        private void SetListView()
        {
            imageList1.Images.Clear();
            listView1.Items.Clear();
            ATINChamCongEntities context = new ATINChamCongEntities();
            List<ViewXemHinhChamCong> lstViewXemHinhChamCong = new List<ViewXemHinhChamCong>();
            if (comboBox1.DataSource == null)
                return;
            if (radioButton1.Checked == true)
            {
                lstViewXemHinhChamCong = context.spGetViewXemHinhChamCongByTimeByMachine(dateEdit1.DateTime, (int)comboBox1.SelectedValue, "year").ToList();
            }
            else if (radioButton2.Checked == true)
            {
                lstViewXemHinhChamCong = context.spGetViewXemHinhChamCongByTimeByMachine(dateEdit1.DateTime, (int)comboBox1.SelectedValue, "month").ToList();
            }
            else if (radioButton3.Checked == true)
            {
                lstViewXemHinhChamCong = context.spGetViewXemHinhChamCongByTimeByMachine(dateEdit1.DateTime, (int)comboBox1.SelectedValue, "date").ToList();
            }
            else if (radioButton4.Checked == true)
            {
                lstViewXemHinhChamCong = context.spGetViewXemHinhChamCongByTimeByMachine(dateEdit1.DateTime, (int)comboBox1.SelectedValue, "hour").ToList();
            }
            List<ListViewItem> lstLv = new List<ListViewItem>();
            foreach (var view in lstViewXemHinhChamCong)
            {
                if (view.HinhChamCong == null)
                    imageList1.Images.Add(Properties.Resources.bouser_32x32);
                else
                    imageList1.Images.Add(byteArrayToImage(view.HinhChamCong));
            }
            imageList1.ImageSize = new Size(100, 100);
            listView1.View = View.LargeIcon;
            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem(lstViewXemHinhChamCong[j].HoTen + " " + lstViewXemHinhChamCong[j].GioChamCong.ToString());
                item.ImageIndex = j;
                this.listView1.Items.Add(item);
            }
            listView1.LargeImageList = imageList1;

        }
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctl, new object[] { DoubleBuffered });
        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            button1.Enabled = false;
            SetListView();
            Cursor.Current = Cursors.Default;
            button1.Enabled = true;
        }
    }
}
