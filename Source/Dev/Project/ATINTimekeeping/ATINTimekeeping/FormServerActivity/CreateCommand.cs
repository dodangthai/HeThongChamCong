using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATINTimekeeping.FormServerActivity
{
    public partial class CreateCommand : Form
    {
        private static CreateCommand obj;
        //using Singleton to create only one Instance of form
        private CreateCommand()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static CreateCommand CreateInstance()
        {
            if (obj == null)
                return obj = new CreateCommand();
            else
                return obj;
        }
        public static CreateCommand GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
                obj = null;
        }

        private void SelectTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

