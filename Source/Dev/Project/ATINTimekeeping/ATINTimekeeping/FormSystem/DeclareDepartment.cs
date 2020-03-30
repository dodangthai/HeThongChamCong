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
    public partial class DeclareDepartment : Form
    {
        private static DeclareDepartment obj;
        //using Singleton to create only one Instance of form
        private DeclareDepartment()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static DeclareDepartment CreateInstance()
        {
            if (obj == null)
                return obj = new DeclareDepartment();
            else
                return obj;
        }
        public static DeclareDepartment GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
            obj = null;
        }

        private void DeclareDepartment_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
