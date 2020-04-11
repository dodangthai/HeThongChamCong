using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class ChucVuManager
    {
        private static ChucVuManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static ChucVuManager Instance
        {
            get
            {
                return _instance ?? (_instance = new ChucVuManager());
            }
        }

        public List<ChucVu> GetAllChucVu()
        {
            try
            {
                var listChucVu = context.ChucVus.ToList();
                return listChucVu;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteChucVu(int maChucVu)
        {
            try
            {
                ChucVu cv = context.ChucVus.Where(x => x.MaChucVu == maChucVu).Single<ChucVu>();
                context.ChucVus.Remove(cv);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public int AddChucVu(ChucVu chucVu)
        {
            try
            {
                context.ChucVus.Add(chucVu);
                context.SaveChanges();

                int maChucVu = chucVu.MaChucVu;
                return maChucVu;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateChuVu(ChucVu chucVuUpdate)
        {
            try
            {
                ChucVu chucVu = context.ChucVus.Where(x => x.MaChucVu == chucVuUpdate.MaChucVu).Single<ChucVu>();
                chucVu.TenChucVu = chucVuUpdate.TenChucVu;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
