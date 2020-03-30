using System;

namespace ATINTimekeeping.FormSystem
{
    public partial class DeclareHoliday : DevExpress.XtraEditors.XtraForm
    {
        private static DeclareHoliday obj;

        public DeclareHoliday()
        {
            InitializeComponent();
        }

        public static DeclareHoliday CreateInstance()
        {
            if (obj == null)
                return obj = new DeclareHoliday();
            else
                return obj;
        }
        public static DeclareHoliday GetInstance()
        {
            return obj;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeclareHoliday_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTINChamCongDataSet.AspNetUsers' table. You can move, or remove it, as needed.
            this.aspNetUsersTableAdapter.Fill(this.aTINChamCongDataSet.AspNetUsers);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}