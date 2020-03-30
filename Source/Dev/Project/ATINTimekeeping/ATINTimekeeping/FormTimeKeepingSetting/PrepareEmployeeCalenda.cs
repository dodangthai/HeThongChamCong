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
    public partial class PrepareEmployeeCalenda : Form
    {
        private static PrepareEmployeeCalenda obj;
        //using Singleton to create only one Instance of form
        private PrepareEmployeeCalenda()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static PrepareEmployeeCalenda CreateInstance()
        {
            if (obj == null)
                return obj = new PrepareEmployeeCalenda();
            else
                return obj;
        }
        public static PrepareEmployeeCalenda GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
            obj = null;
        }

        private void PrepareEmployeeCalenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }
    }
}
