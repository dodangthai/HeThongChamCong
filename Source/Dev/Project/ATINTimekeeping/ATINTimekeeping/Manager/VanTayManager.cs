using ATINTimekeeping.Common;
using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class VanTayManager
    {
        private static VanTayManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static VanTayManager Instance
        {
            get
            {
                return _instance ?? (_instance = new VanTayManager());
            }
        }

        public List<VanTay> GetAllVanTay()
        {
            List<VanTay> listVanTay = new List<VanTay>();
            
            try
            {
                listVanTay = context.VanTays.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return listVanTay;
        }

        public List<VanTay> GetVanTayPersonId(int maNguoi)
        {
            List<VanTay> listVanTay = new List<VanTay>();

            try
            {
                listVanTay = context.VanTays
                            .Where(c => c.MaNguoi == maNguoi)
                            .ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return listVanTay;
        }

        public void DeleteTheTu(int maTheTu)
        {
            try
            {
                VanTay vanTay = context.VanTays.Where(x => x.MaVanTay == maTheTu).Single<VanTay>();
                context.VanTays.Remove(vanTay);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int AddVanTay (VanTay vanTay)
        {
            int maVanTay = 0;

            try
            {
                context.VanTays.Add(vanTay);
                context.SaveChanges();

                maVanTay = vanTay.MaVanTay;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return maVanTay;
        }

        public void UpdateVanTay(VanTay vanTayUpdate)
        {
            try
            {
                VanTay vanTay = context.VanTays.Where(x => x.MaVanTay == vanTayUpdate.MaVanTay).Single<VanTay>();
                vanTay.MaNguoi = vanTayUpdate.MaNguoi;
                vanTay.NgonTay = vanTayUpdate.NgonTay;
                vanTay.ThuocTinhVanTay = vanTayUpdate.ThuocTinhVanTay;
                vanTay.ThoiGianDangKy = vanTayUpdate.ThoiGianDangKy;
                vanTay.TrangThai = vanTayUpdate.TrangThai;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
