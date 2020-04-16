using ATINTimekeeping.Common;
using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class TheTuManager
    {
        private static TheTuManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static TheTuManager Instance
        {
            get
            {
                return _instance ?? (_instance = new TheTuManager());
            }
        }

        public List<TheTu> GetAllTheTu()
        {
            try
            {
                var listTheTu = context.TheTus.ToList();
                return listTheTu;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<TheTu> GetTheTuByPersonId(int maNguoi)
        {
            List<TheTu> listTheTu = new List<TheTu>();

            try
            {
                listTheTu = context.TheTus
                            .Where(c => c.MaNguoi == maNguoi)
                            .ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return listTheTu;
        }

        public void DeleteTheTu(int maTheTu)
        {
            try
            {
                TheTu theTu = context.TheTus.Where(x => x.MaTheTu == maTheTu).Single<TheTu>();
                context.TheTus.Remove(theTu);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int AddTheTu(TheTu theTu)
        {
            try
            {
                context.TheTus.Add(theTu);
                context.SaveChanges();

                int maTheTu = theTu.MaTheTu;
                return maTheTu;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateTheTu(TheTu theTuUpdate)
        {
            try
            {
                TheTu theTu = context.TheTus.Where(x => x.MaTheTu == theTuUpdate.MaTheTu).Single<TheTu>();
                theTu.MaNguoi = theTuUpdate.MaNguoi;
                theTu.LoaiTheTu = theTuUpdate.LoaiTheTu;
                theTu.NoiDungThe = theTuUpdate.NoiDungThe;
                theTu.ThoiGianDangKy = theTuUpdate.ThoiGianDangKy;
                theTu.TrangThai = theTuUpdate.TrangThai;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
