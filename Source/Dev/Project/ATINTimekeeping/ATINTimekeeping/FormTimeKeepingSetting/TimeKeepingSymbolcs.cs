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
    }
}
