using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATINTimekeeping.Model;
namespace ATINTimekeeping.FormTimeKeepingSetting
{
    public partial class SelectTime : Form
    {
        private static SelectTime obj;
        //using Singleton to create only one Instance of form
        private SelectTime()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            using (ATINChamCongEntities db = new ATINChamCongEntities())
            {
                DanToc dan = db.DanTocs.Where((x) => x.MaDanToc == 2).FirstOrDefault();
                textEdit1.Text = dan.DanToc1;
            }
        }
        public static SelectTime CreateInstance()
        {
            if (obj == null)
                return obj = new SelectTime();
            else
                return obj;
        }
        public static SelectTime GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if(obj!=null)
            obj = null;
        }

        private void SelectTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }
    }
}
