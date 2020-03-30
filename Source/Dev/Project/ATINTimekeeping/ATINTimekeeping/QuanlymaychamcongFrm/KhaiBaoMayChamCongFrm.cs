using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATINTimekeeping
{
    public partial class KhaiBaoMayChamCongFrm : Form
    {
        private static KhaiBaoMayChamCongFrm obj;
        //using Singleton to create only one Instance of form
        public KhaiBaoMayChamCongFrm()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }



    }
}
