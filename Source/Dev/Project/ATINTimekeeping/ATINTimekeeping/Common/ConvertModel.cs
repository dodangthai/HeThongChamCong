using ATINTimekeeping.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATINTimekeeping.Common
{
    static class ConvertModel
    {

        public static MayNhanDangTreeNode ConvertMayNhanDangToTreeView(MayNhanDang model)
        {
            MayNhanDangTreeNode mayNhanDangTreeNode = new MayNhanDangTreeNode();
            mayNhanDangTreeNode.MaMay = model.MaMay;
            mayNhanDangTreeNode.TenMay = model.TenMay;
            mayNhanDangTreeNode.Parent = 0;
            return mayNhanDangTreeNode;
        }

    }

    public class MayNhanDangTreeNode
    {
        public int MaMay { get; set; }
        public string TenMay { get; set; }
        public int Parent { get; set; }
    }
}
