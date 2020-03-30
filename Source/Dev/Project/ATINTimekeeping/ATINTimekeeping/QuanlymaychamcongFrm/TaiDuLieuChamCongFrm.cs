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
    public partial class TaiDuLieuChamCongFrm : Form
    {
        //using Singleton to create only one Instance of form
        public TaiDuLieuChamCongFrm()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
    }
}
