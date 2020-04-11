using ATINTimekeeping.Manager;
using ATINTimekeeping.Model;
using System.Drawing;
using System.Windows.Forms;

namespace ATINTimekeeping.FormHeThong
{
    public partial class KhaiBaoPhongBanAdd : DevExpress.XtraEditors.XtraForm
    {
        private const int INSERT = 1;
        private const int UPDATE = 2;
        private int action = 0; //1: insert, 2: update
        private int selectedId = 0;
        private string tenPhongBan = "";

        public KhaiBaoPhongBanAdd(int action, int selectedId, string tenPhongBan)
        {
            InitializeComponent();
            this.tenPhongBan = tenPhongBan;
            this.action = action;
            this.selectedId = selectedId;
            txtTenPhongBan.Text = tenPhongBan;
            btnAccept.Paint += new PaintEventHandler(btnAccept_Paint);
            txtTenPhongBan.Paint += new PaintEventHandler(txtTenPhongBan_Paint);
        }

        private void txtTenPhongBan_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            RectangleF rec = e.Graphics.ClipBounds;
            rec.Inflate(-1, -1);
            e.Graphics.DrawRectangle(Pens.DodgerBlue,
                rec.Left,
                rec.Top,
                rec.Width,
                rec.Height);
        }

        private void btnAccept_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            RectangleF rec = e.Graphics.ClipBounds;
            rec.Inflate(-1, -1);
            e.Graphics.DrawRectangle(Pens.DodgerBlue,
                rec.Left,
                rec.Top,
                rec.Width,
                rec.Height);
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            PhongBan phongBan = new PhongBan();
            phongBan.TenPhongBan = txtTenPhongBan.Text;

            if (action == INSERT)
            {
                phongBan.Cha = selectedId;
                PhongBanManager.Instance.AddPhongBan(phongBan);
            }
            else if(action == UPDATE)
            {
                PhongBan phongBanHienTai = PhongBanManager.Instance.GetPhongBan(selectedId);
                phongBan.MaPhongBan = selectedId;
                phongBan.Cha = phongBanHienTai.Cha;
                PhongBanManager.Instance.UpdatePhongBan(phongBan);                
            }
            this.Close();
        }
    }
}
