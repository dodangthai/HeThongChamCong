using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class GioiTinhManager
    {
        private static GioiTinhManager _instance;

        public static GioiTinhManager Instance
        {
            get
            {
                return _instance ?? (_instance = new GioiTinhManager());
            }
        }

        public List<GioiTinh> GetAllGioiTinh()
        {
            List<GioiTinh> listGioiTinh = new List<GioiTinh>();
            try
            {
                ATINChamCongEntities context = new ATINChamCongEntities();
                listGioiTinh = context.GioiTinhs.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return listGioiTinh;
        }
    }
}
