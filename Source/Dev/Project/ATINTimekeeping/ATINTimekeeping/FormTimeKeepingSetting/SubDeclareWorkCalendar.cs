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
    public partial class SubDeclareWorkCalendar : Form
    {
        private bool askWhenRemoveShiftInDate = false;
        private string typeLichTrinh;
        public SubDeclareWorkCalendar()
        {
            InitializeComponent();
        }
        public SubDeclareWorkCalendar(string typeLichTrinh)
        {
            this.typeLichTrinh = typeLichTrinh;
            InitializeComponent();
            listView1.Items.Clear();
            listView2.Items.Clear();
            treeView1.Nodes.Clear();
            LisView1Config();
            LisView2Config(typeLichTrinh, DateTime.Now.Month);
            TreeView1Config(listView2);
            Combobox1Config();
        }
        private void LisView1Config()
        {
            var lstCaLamViec = DeclareTheShift.LoadAllCaLamViec();
            for (int i = 0; i < lstCaLamViec.Count; i++)
            {
                ListViewItem item = new ListViewItem(lstCaLamViec[i].MaCaLamViec);
                item.Tag = lstCaLamViec[i];
                listView1.Items.Add(item);
            }           
        }
        private void LisView2Config(string typeLichTrinh, int month)
        {
            if(typeLichTrinh == "week") 
            {
                ListViewItem weekitem = new ListViewItem("Chủ Nhật");
                weekitem.Tag = 1;
                listView2.Items.Add(weekitem);
                for (int i = 2; i < 8; i++)
                {
                    ListViewItem weekitem2 = new ListViewItem("Thứ "+i.ToString());
                    weekitem2.Tag = i;
                    listView2.Items.Add(weekitem2);
                }
                weekitem = new ListViewItem("Ngày Lễ");
                weekitem.Tag = 8;
                listView2.Items.Add(weekitem);
                comboBox1.Enabled = false;
            }
            if (typeLichTrinh == "month")
            {
                for (int i = 1; i < 32; i++)
                {
                    ListViewItem monthitem = new ListViewItem("Ngày " + i.ToString());
                    monthitem.Tag = i;
                    listView2.Items.Add(monthitem);
                    
                }
                ListViewItem item2 = new ListViewItem("Ngày Lễ 32");
                item2.Tag = 32;
                listView2.Items.Add(item2);
                comboBox1.Enabled = false;
            }
            if(typeLichTrinh == "year")
            {
                comboBox1.Enabled = true;
                int dayInMonth = DateTime.DaysInMonth(DateTime.Now.Year, month);
                for (int i = 1; i <= dayInMonth; i++)
                {
                    ListViewItem day = new ListViewItem("Ngày " + i.ToString());
                    day.Tag = i;
                    listView2.Items.Add(day);

                }
                ListViewItem item2 = new ListViewItem("Ngày Lễ 32");
                item2.Tag = 32;
                listView2.Items.Add(item2);
                comboBox1.Enabled = true;
            }
        }
        //refresh when changeed month
        private void RefreshMonthChange(int month)
        {
            listView2.Items.Clear();
            treeView1.Nodes.Clear();
            LisView2Config(typeLichTrinh, month);
            TreeView1Config(listView2);
        }
        private void TreeView1Config(ListView listView)
        {
            foreach(ListViewItem item in listView.Items)
            {
                TreeNode node = new TreeNode(item.Text);
                node.Tag = item.Tag;
                treeView1.Nodes.Add(node);
            }
        }
        private void Combobox1Config()
        {
            comboBox1.SelectedIndex = 0;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            foreach(ListViewItem item in listView1.Items)
                {
                    item.Checked = true;
                }
            else
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Checked = false;
                }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                foreach (ListViewItem item in listView2.Items)
                {
                    item.Checked = true;
                }
            else
                foreach (ListViewItem item in listView2.Items)
                {
                    item.Checked = false;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.Items)
            {
                int? x = item.Tag as int?;
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            askWhenRemoveShiftInDate = checkBox3.Checked;
        }

        private void SubDeclareWorkCalendar_Load(object sender, EventArgs e)
        {
            //load lichtrinh
            //for...
            //load Listcalamviec where treeview1.node.tag == lichtrinhtuan.date.........
                //for..
                //
        }
        //delete selected
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //delete all
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMonthChange(comboBox1.SelectedIndex+1);
        }
    }

}
