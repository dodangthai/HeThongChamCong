using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class TrangThaiManager
    {
        private static TrangThaiManager _instance;
        ATINChamCongEntities context = new ATINChamCongEntities();

        public static TrangThaiManager Instance
        {
            get
            {
                return _instance ?? (_instance = new TrangThaiManager());
            }
        }

        public List<TrangThai> GetAllTrangThai(string tenNhom)
        {
            List<TrangThai> listTrangThai = new List<TrangThai>();
            try
            {
                
                listTrangThai = context.TrangThais
                    .Where(c => c.TenNhom == tenNhom)
                    .ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return listTrangThai;
        }
    }
}
