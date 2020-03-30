using System;

namespace ATINTimekeeping.FormSystem
{
    public partial class DeclareReligion : DevExpress.XtraEditors.XtraForm
    {
        private static DeclareReligion obj;

        public DeclareReligion()
        {
            InitializeComponent();
        }

        public static DeclareReligion CreateInstance()
        {
            if (obj == null)
                return obj = new DeclareReligion();
            else
                return obj;
        }
        public static DeclareReligion GetInstance()
        {
            return obj;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeclareReligion_Load(object sender, EventArgs e)
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
    }
}