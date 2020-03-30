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
    public partial class ChooseWeekends : Form
    {
        private static ChooseWeekends obj;
        //using Singleton to create only one Instance of form
        private ChooseWeekends()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static ChooseWeekends CreateInstance()
        {
            if (obj == null)
                return obj = new ChooseWeekends();
            else
                return obj;
        }
        public static ChooseWeekends GetInstance()
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
    }
}
