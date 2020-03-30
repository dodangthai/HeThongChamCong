using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATINTimekeeping.FormSystem
{
    public partial class ManagerEmployee : Form
    {
        private static ManagerEmployee obj;
        //using Singleton to create only one Instance of form
        private ManagerEmployee()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static ManagerEmployee CreateInstance()
        {
            if (obj == null)
                return obj = new ManagerEmployee();
            else
                return obj;
        }
        public static ManagerEmployee GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
            obj = null;
        }

        private void ManagerEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
