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
    public partial class ServerEvent : Form
    {
        private static ServerEvent obj;
        //using Singleton to create only one Instance of form
        private ServerEvent()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static ServerEvent CreateInstance()
        {
            if (obj == null)
                return obj = new ServerEvent();
            else
                return obj;
        }
        public static ServerEvent GetInstance()
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
