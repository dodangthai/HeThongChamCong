using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ATINTimekeeping.FormServerActivity
{
    public partial class Server : Form
    {
        private static Server obj;
        //using Singleton to create only one Instance of form
        private Server()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static Server CreateInstance()
        {
            if (obj == null)
                return obj = new Server();
            else
                return obj;
        }
        public static Server GetInstance()
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
    }
}
