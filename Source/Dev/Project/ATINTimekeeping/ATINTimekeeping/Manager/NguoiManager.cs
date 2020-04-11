using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATINTimekeeping.Manager
{
    class NguoiManager
    {
        private static NguoiManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static NguoiManager Instance
        {
            get
            {
                return _instance ?? (_instance = new NguoiManager());
            }
        }

        public List<Nguoi> GetNguoi (int maNguoi, string hoTen, int maPhongBan)
        {
            try
            {
                var listNguoi = context.Nguois
                .Where(c => maNguoi == 0 || c.MaNguoi == maNguoi)
                .Where(c => hoTen == "" || c.HoTen == hoTen)
                .Where(c => maPhongBan == 0 || c.MaPhongBan == maPhongBan)
                .ToList();
                return listNguoi;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Nguoi> GetAllNguoi()
        {
            try
            {
                var listNguoi = context.Nguois.ToList();
                return listNguoi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddNguoi (Nguoi nguoi)
        {
            try
            {
                context.Nguois.Add(nguoi);
                context.SaveChanges();

                int maNguoi = nguoi.MaNguoi;
                return maNguoi;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteNguoi(int maNguoi)
        {
            try
            {
                Nguoi nguoi = context.Nguois.Where(x => x.MaNguoi == maNguoi).Single<Nguoi>();
                context.Nguois.Remove(nguoi);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
