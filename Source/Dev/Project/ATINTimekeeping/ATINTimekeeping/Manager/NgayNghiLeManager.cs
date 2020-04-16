using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class NgayNghiLeManager
    {
        private static NgayNghiLeManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static NgayNghiLeManager Instance
        {
            get
            {
                return _instance ?? (_instance = new NgayNghiLeManager());
            }
        }

        public List<NgayNghiLe> GetAllNgayNghiLe()
        {
            try
            {
                var listNgayNghiLe = context.NgayNghiLes.ToList();
                return listNgayNghiLe;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public NgayNghiLe GetNgayNghiLe(int maNgayNghiLe)
        {
            try
            {
                return context.NgayNghiLes
                    .Where(c => c.MaNgayNghiLe == maNgayNghiLe)
                    .Single<NgayNghiLe>();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public int AddNgayNghiLe(NgayNghiLe ngayNghiLe)
        {
            int maNgayNghiLe = 0;

            try
            {
                context.NgayNghiLes.Add(ngayNghiLe);
                context.SaveChanges();

                maNgayNghiLe = ngayNghiLe.MaNgayNghiLe;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return maNgayNghiLe;
        }

        public void UpdateNgayNghiLe(NgayNghiLe ngayNghiLeUpdate)
        {
            try
            {
                NgayNghiLe ngayNghiLe = context.NgayNghiLes.Where(x => x.MaNgayNghiLe == ngayNghiLeUpdate.MaNgayNghiLe).Single<NgayNghiLe>();

                ngayNghiLe.TenNgayNghiLe = ngayNghiLeUpdate.TenNgayNghiLe;
                ngayNghiLe.NgayLe = ngayNghiLeUpdate.NgayLe;
                ngayNghiLe.MoTa = ngayNghiLeUpdate.MoTa;

                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteNgayNghiLe(int maNgayNghiLe)
        {
            try
            {
                NgayNghiLe ngayNghiLe = context.NgayNghiLes.Where(x => x.MaNgayNghiLe == maNgayNghiLe).Single<NgayNghiLe>();
                context.NgayNghiLes.Remove(ngayNghiLe);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }        
    }
}
