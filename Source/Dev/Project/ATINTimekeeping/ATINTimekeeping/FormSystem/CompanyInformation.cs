using System;
using System.Windows.Forms;

namespace ATINTimekeeping.FormSystem
{
    public partial class CompanyInformation : Form
    {
        private static CompanyInformation obj;

        private CompanyInformation()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public static CompanyInformation CreateInstance()
        {
            if (obj == null)
                return obj = new CompanyInformation();
            else
                return obj;
        }
        public static CompanyInformation GetInstance()
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

        private void CompanyInformation_FormClosing(object sender, FormClosingEventArgs e)
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
