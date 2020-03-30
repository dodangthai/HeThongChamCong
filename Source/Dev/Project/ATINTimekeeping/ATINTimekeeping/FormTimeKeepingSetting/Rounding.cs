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
    public partial class Rounding : Form
    {
        private static Rounding obj;
        //using Singleton to create only one Instance of form
        private Rounding()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static Rounding CreateInstance()
        {
            if (obj == null)
                return obj = new Rounding();
            else
                return obj;
        }
        public static Rounding GetInstance()
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

