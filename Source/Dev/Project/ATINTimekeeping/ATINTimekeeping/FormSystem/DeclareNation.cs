using System;

namespace ATINTimekeeping.FormSystem
{
    public partial class DeclareNation : DevExpress.XtraEditors.XtraForm
    {
        private static DeclareNation obj;

        public DeclareNation()
        {
            InitializeComponent();
        }

        public static DeclareNation CreateInstance()
        {
            if (obj == null)
                return obj = new DeclareNation();
            else
                return obj;
        }
        public static DeclareNation GetInstance()
        {
            return obj;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeclareNation_Load(object sender, EventArgs e)
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