using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATINTimekeeping.FormTimeKeepingSetting
{
    public partial class DeclareWorkCalenda : Form
    {
        private static DeclareWorkCalenda obj;
        //using Singleton to create only one Instance of form
        private DeclareWorkCalenda()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static DeclareWorkCalenda CreateInstance()
        {
            if (obj == null)
                return obj = new DeclareWorkCalenda();
            else
                return obj;
        }
        public static DeclareWorkCalenda GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
                obj = null;
        }

        private void DeclareWorkCalenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = new SubDeclareWorkCalendar("month");
            f.ShowDialog();
        }
    }
}
