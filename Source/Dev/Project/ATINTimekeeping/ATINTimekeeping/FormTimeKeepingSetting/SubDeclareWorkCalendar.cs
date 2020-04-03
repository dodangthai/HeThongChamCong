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
using System.Reflection;

namespace ATINTimekeeping.FormTimeKeepingSetting
{
    public partial class SubDeclareWorkCalendar : Form
    {
        private bool askWhenRemoveShiftInDate = false;
        private LichTrinh lichTrinh;
        private string WorkCalendarShowType = null;
        public SubDeclareWorkCalendar()
        {
            InitializeComponent();
        }
        public SubDeclareWorkCalendar(LichTrinh lichTrinh, string WorkCalendarShowType)
        {
            this.lichTrinh = lichTrinh;
            this.Text = "Lịch Trình(" + lichTrinh.TenLichTrinh+")";
            this.WorkCalendarShowType = WorkCalendarShowType;
            //SetDoubleBuffer(treeView1, true);
            InitializeComponent();
            listView1.Items.Clear();
            listView2.Items.Clear();
            treeView1.Nodes.Clear();
            LisView1Config();
            LisView2Config(lichTrinh, DateTime.Now.Month);
            TreeView1Config(listView2);
            Combobox1Config();
        }
        
        //prevent treeview flickering
        //static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        //{
        //    typeof(Control).InvokeMember("DoubleBuffered",
        //        BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
        //        null, ctl, new object[] { DoubleBuffered });
        //}
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
        private void LisView2Config(LichTrinh lichTrinh, int month)
        {
            if(WorkCalendarShowType == "week") 
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
            if (WorkCalendarShowType == "month")
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
            if(WorkCalendarShowType == "year")
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
            LisView2Config(lichTrinh, month);
            TreeView1Config(listView2);
        }
        private void TreeView1Config(ListView listView)
        {
            treeView1.Nodes.Clear();
            ATINChamCongEntities context = new ATINChamCongEntities();
            foreach (ListViewItem item in listView.Items)
            {
                TreeNode node = new TreeNode(item.Text);
                node.Tag = item.Tag;
                treeView1.Nodes.Add(node);
            }
            switch (WorkCalendarShowType)
            {
                case "week":
                    List<LichTrinhTuan> lichTrinhTuans = context.spGetLichTrinhTuanByLichTrinh(lichTrinh.MaLichTrinh).OrderBy(x => x.DateInWeek).ToList();
                    foreach(TreeNode node in treeView1.Nodes)
                    {
                        int? x = node.Tag as int?;
                        foreach(LichTrinhTuan lic in lichTrinhTuans)
                        {
                            if (x == lic.DateInWeek)
                            {
                                TreeNode childNode = new TreeNode(lic.MaCaLamViec);
                                childNode.Tag = lic;
                                node.Nodes.Add(childNode);
                            }
                        }
                    }
                    break;
                case "month":
                    List<LichTrinhThang> lichTrinhThangs = context.spGetLichTrinhThangByLichTrinh(lichTrinh.MaLichTrinh).OrderBy(x => x.Date).ToList();
                    foreach (TreeNode node in treeView1.Nodes)
                    {
                        int? x = node.Tag as int?;
                        foreach (LichTrinhThang lic in lichTrinhThangs)
                        {
                            if (x == lic.Date)
                            {
                                TreeNode childNode = new TreeNode(lic.MaCaLamViec);
                                childNode.Tag = lic;
                                node.Nodes.Add(childNode);
                            }
                        }
                    }
                    break;
                case "year":
                    List<LichTrinhNam> lichTrinhNams = context.spGetLichTrinhNamByLichTrinh(lichTrinh.MaLichTrinh).OrderBy(x => x.Month).ToList();
                    foreach (TreeNode node in treeView1.Nodes)
                    {
                        int? x = node.Tag as int?;
                        foreach (LichTrinhNam lic in lichTrinhNams)
                        {
                            if (x == lic.Date && (comboBox1.SelectedIndex+1) == lic.Month)
                            {
                                TreeNode childNode = new TreeNode(lic.MaCaLamViec);
                                childNode.Tag = lic;
                                node.Nodes.Add(childNode);
                            }
                        }
                    }
                    break;
            }
            treeView1.ExpandAll();
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

        //Save
        private void button1_Click(object sender, EventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            //date

            switch (WorkCalendarShowType)
            {
                case "week":
                    foreach (ListViewItem Dateitem in listView2.CheckedItems)
                    {
                        int? x = Dateitem.Tag as int?;
                        foreach (ListViewItem caItem in listView1.CheckedItems)
                        {
                            CaLamViec ca = caItem.Tag as CaLamViec;
                            context.spInsertLichTrinhTuan(lichTrinh.MaLichTrinh, ca.MaCaLamViec, x);
                        }
                    }
                    break;
                case "month":
                    foreach (ListViewItem Dateitem in listView2.CheckedItems)
                    {
                        int? x = Dateitem.Tag as int?;
                        foreach (ListViewItem caItem in listView1.CheckedItems)
                        {
                            CaLamViec ca = caItem.Tag as CaLamViec;
                            context.spInsertLichTrinhThang(lichTrinh.MaLichTrinh, ca.MaCaLamViec, x);
                        }
                    }
                    break;
                case "year":
                    foreach (ListViewItem Dateitem in listView2.CheckedItems)
                    {
                        int? x = Dateitem.Tag as int?;
                        foreach (ListViewItem caItem in listView1.CheckedItems)
                        {
                            CaLamViec ca = caItem.Tag as CaLamViec;
                            context.spInsertLichTrinhNam(lichTrinh.MaLichTrinh, ca.MaCaLamViec, x,comboBox1.SelectedIndex+1);
                        }
                    }
                    break;
            }
            TreeView1Config(listView2);
        }
        //delete selected
        private void button2_Click(object sender, EventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            foreach(TreeNode node in treeView1.Nodes)
            {
                foreach(TreeNode childNode in node.Nodes)
                {
                    if(childNode.Checked)
                    {
                        switch (WorkCalendarShowType)
                        {
                            case "week":
                                context.spDeleteLichTrinhTuan(lichTrinh.MaLichTrinh, (childNode.Tag as CaLamViec).MaCaLamViec, node.Tag as int?);
                                break;
                            case "month":
                                context.spDeleteLichTrinhThang(lichTrinh.MaLichTrinh, (childNode.Tag as CaLamViec).MaCaLamViec, node.Tag as int?);
                                break;
                            case "year":
                                context.spDeleteLichTrinhNam(lichTrinh.MaLichTrinh, (childNode.Tag as CaLamViec).MaCaLamViec, node.Tag as int?, comboBox1.SelectedIndex+1);
                                break;
                        }
                    }
                }
            }
        }
        //delete all
        private void button3_Click(object sender, EventArgs e)
        {
            ATINChamCongEntities context = new ATINChamCongEntities();
            switch (WorkCalendarShowType)
            {
                case "week":
                    context.spDeleteAllLichTrinhTuanByLichTrinh(lichTrinh.MaLichTrinh);
                    break;
                case "month":
                    context.spDeleteAllLichTrinhThangByLichTrinh(lichTrinh.MaLichTrinh);
                    break;
                case "year":
                    context.spDeleteAllLichTrinhNamByLichTrinh_Month(lichTrinh.MaLichTrinh, comboBox1.SelectedIndex + 1);
                    break;
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
 
        }
 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMonthChange(comboBox1.SelectedIndex+1);
        }

        private void SubDeclareWorkCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }
        // Updates all child tree nodes recursively.
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

    }

}
