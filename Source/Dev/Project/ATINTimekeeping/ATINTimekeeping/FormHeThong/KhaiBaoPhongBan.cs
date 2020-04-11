using ATINTimekeeping.Common;
using ATINTimekeeping.Manager;
using ATINTimekeeping.Model;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ATINTimekeeping.FormHeThong
{
    public partial class KhaiBaoPhongBan : DevExpress.XtraEditors.XtraForm
    {
        private const int NODE_TICKED = 0;
        private const int NODE_UNTICKED = 1;
        private const int INSERT = 1;
        private const int UPDATE = 2;

        public KhaiBaoPhongBan()
        {
            InitializeComponent();
            RefreshForm();
            GuideDocument();
        }

        public void RefreshForm()
        {
            LoadTreeViewPhongBan();
        }

        private void LoadTreeViewPhongBan()
        {
            List<PhongBan> listPhongBan = PhongBanManager.Instance.GetAllPhongBan();
            DataTable tblPhongBan = Utils.ToDataTable(listPhongBan);
            treeListPhongBan.DataSource = listPhongBan;
            treeListPhongBan.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView;
            treeListPhongBan.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.True;
            treeListPhongBan.ExpandAll();
        }

        private void GuideDocument()
        {
            txtGuildDocument.Clear();
            string content = "- Cần thêm phòng ban mới ta chọn phòng ban cha rồi bấm Thêm mới\n";
            content += "- Cần thay đổi phòng ban cha ta chọn phòng ban rồi bấm Sửa tên\n";
            content += "- Muốn thay đổi phòng ban cha của một phòng ban nào đó. Ta chọn phòng ban cha rồi nhấp chuột trái giữ, rê đến phòng ban cha cần đổi";
            txtGuildDocument.Text = content;
        }

        private void btnAddDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var maPhongBan = treeListPhongBan.FocusedNode.GetValue("MaPhongBan").ToString();
            int mMaPhongBanSelected = Utils.StringToInt(maPhongBan);

            if (mMaPhongBanSelected == 0)
            {
                MessageBox.Show("Xin chọn một phòng ban cha");
                return;
            }

            KhaiBaoPhongBanAdd dialog = new KhaiBaoPhongBanAdd(INSERT, mMaPhongBanSelected, "");
            dialog.ShowDialog();

            //TreeListMultiSelection selectedNodes = treeListPhongBan.Selection;
            //MessageBox.Show(selectedNodes[0].GetValue(treeListPhongBan.Columns[0]).ToString());

            //List<TreeListNode> listTreeNode = treeListPhongBan.GetNodeList();
            //listTreeNode.ForEach(node =>
            //{
            //    MessageBox.Show(node.GetValue("MaPhongBan").ToString());
            //    if (node.GetValue("MaPhongBan").ToString() == "12")
            //    {

            //    }
            //});
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshForm();
        }

        private void btnModifyDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var maPhongBan = treeListPhongBan.FocusedNode.GetValue("MaPhongBan").ToString();
            var tenPhongBan = treeListPhongBan.FocusedNode.GetValue("TenPhongBan").ToString();
            int maPhongBanSelected = Utils.StringToInt(maPhongBan);

            if (maPhongBanSelected == 0)
            {
                MessageBox.Show("Xin chọn một phòng ban cần sửa");
                return;
            }

            KhaiBaoPhongBanAdd dialog = new KhaiBaoPhongBanAdd(UPDATE, maPhongBanSelected, tenPhongBan);
            dialog.ShowDialog();
        }

        private void btnDeleteDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var maPhongBan = treeListPhongBan.FocusedNode.GetValue("MaPhongBan").ToString();
            int maPhongBanSelected = Utils.StringToInt(maPhongBan);

            if (maPhongBanSelected == 0)
            {
                MessageBox.Show("Xin chọn một phòng ban cần xóa");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn muốn xóa phòng ban đã chọn?", "ATIN Smartface - Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                PhongBanManager.Instance.DeletePhongBan(maPhongBanSelected);
                RefreshForm();
            }
        }
    }
}
