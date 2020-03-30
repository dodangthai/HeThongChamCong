using System;
using System.Windows.Forms;

namespace ATINTimekeeping.FormSystem
{
    public partial class ChangePassword : Form
    {
        private static ChangePassword obj;

        private ChangePassword()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static ChangePassword CreateInstance()
        {
            if (obj == null)
                return obj = new ChangePassword();
            else
                return obj;
        }
        public static ChangePassword GetInstance()
        {
            return obj;
        }
        public static void CleanObj()
        {
            if (obj != null)
            obj = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CleanObj();
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
