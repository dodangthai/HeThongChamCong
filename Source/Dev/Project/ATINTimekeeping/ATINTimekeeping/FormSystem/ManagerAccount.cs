using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ATINTimekeeping.FormSystem
{
    public partial class ManagerAccount : DevExpress.XtraEditors.XtraForm
    {
        private static ManagerAccount obj;

        public ManagerAccount()
        {
            InitializeComponent();
        }

        public static ManagerAccount CreateInstance()
        {
            if (obj == null)
                return obj = new ManagerAccount();
            else
                return obj;
        }
        public static ManagerAccount GetInstance()
        {
            return obj;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManagerAccount_Load(object sender, EventArgs e)
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