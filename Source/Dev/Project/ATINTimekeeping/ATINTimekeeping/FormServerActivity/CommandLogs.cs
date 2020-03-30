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
    public partial class CommandLogs : Form
    {
        private static CommandLogs obj;
        //using Singleton to create only one Instance of form
        private CommandLogs()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static CommandLogs CreateInstance()
        {
            if (obj == null)
                return obj = new CommandLogs();
            else
                return obj;
        }
        public static CommandLogs GetInstance()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
