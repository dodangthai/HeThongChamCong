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
    }
}
