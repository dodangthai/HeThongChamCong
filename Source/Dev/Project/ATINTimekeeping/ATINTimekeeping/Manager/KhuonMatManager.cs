using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class KhuonMatManager
    {
        private static KhuonMatManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static KhuonMatManager Instance
        {
            get
            {
                return _instance ?? (_instance = new KhuonMatManager());
            }
        }

        public List<KhuonMat> GetAllKhuonMat()
        {
            try
            {
                var listKhuonMat = context.KhuonMats.ToList();
                return listKhuonMat;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<KhuonMat> GetKhuonMatByPersonId(int maNguoi)
        {
            List<KhuonMat> listKhuonMat = new List<KhuonMat>();

            try
            {
                listKhuonMat = context.KhuonMats
                                .Where(c => c.MaNguoi == maNguoi)
                                .ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return listKhuonMat;
        }

        public void DeleteKhuonMat(int maKhuonMat)
        {
            try
            {
                KhuonMat khuonMat = context.KhuonMats.Where(x => x.MaKhuonMat == maKhuonMat).Single<KhuonMat>();
                context.KhuonMats.Remove(khuonMat);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public int AddKhuonMat(KhuonMat khuonMat)
        {
            try
            {
                context.KhuonMats.Add(khuonMat);
                context.SaveChanges();

                int maKhuonMat = khuonMat.MaKhuonMat;
                return maKhuonMat;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateKhuonMat(KhuonMat khuonMatUpdate)
        {
            try
            {
                KhuonMat khuonMat = context.KhuonMats.Where(x => x.MaKhuonMat == khuonMatUpdate.MaKhuonMat).Single<KhuonMat>();

                //Neu khong co thi insert moi
                if (khuonMat == null)
                {
                    AddKhuonMat(khuonMatUpdate);
                    return;
                }

                //Update
                khuonMat.MaKhuonMat = khuonMatUpdate.MaKhuonMat;
                khuonMat.MaNguoi = khuonMatUpdate.MaNguoi;
                khuonMat.AnhKhuonMat = khuonMatUpdate.AnhKhuonMat;
                khuonMat.ThuocTinhKhuonMat = khuonMatUpdate.ThuocTinhKhuonMat;
                khuonMat.ThoiGianDangKy = khuonMatUpdate.ThoiGianDangKy;
                khuonMat.TrangThai = khuonMatUpdate.TrangThai;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
