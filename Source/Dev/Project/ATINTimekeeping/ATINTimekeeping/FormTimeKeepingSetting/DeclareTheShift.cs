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
    public partial class DeclareTheShift : Form
    {
        private static DeclareTheShift obj;
        public DeclareTheShift()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static DeclareTheShift CreateInstance()
        {
            if (obj == null)
                return obj = new DeclareTheShift();
            else
                return obj;
        }
        public static DeclareTheShift GetInstance()
        {
            return obj;
        }

        private void DeclareTheShift_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }
    }
}
