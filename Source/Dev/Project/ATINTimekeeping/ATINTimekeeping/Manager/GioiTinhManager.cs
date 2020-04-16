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
        private ATINChamCongEntities context = new ATINChamCongEntities();

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
                
                listGioiTinh = context.GioiTinhs.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return listGioiTinh;
        }

        public GioiTinh GetGioiTinh(int maGioiTinh)
        {
            try
            {
                return context.GioiTinhs
                    .Where(c => c.MaGioiTinh == maGioiTinh)
                    .Single<GioiTinh>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
