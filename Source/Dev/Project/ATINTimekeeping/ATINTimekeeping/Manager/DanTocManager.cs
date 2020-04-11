using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class DanTocManager
    {
        private static DanTocManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static DanTocManager Instance
        {
            get
            {
                return _instance ?? (_instance = new DanTocManager());
            }
        }

        public List<DanToc> GetAllDanToc()
        {
            List<DanToc> listDanToc = new List<DanToc>();

            try
            {
                listDanToc = context.DanTocs.ToList();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listDanToc;
        }

        public DanToc GetDanToc(int maDanToc)
        {
            try
            {
                return context.DanTocs
                    .Where(c => c.MaDanToc == maDanToc)
                    .Single<DanToc>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddDanToc (DanToc danToc)
        {
            try
            {
                context.DanTocs.Add(danToc);
                context.SaveChanges();

                int maDanToc = danToc.MaDanToc;
                return maDanToc;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteDanToc (int maDanToc)
        {
            try
            {
                DanToc danToc = context.DanTocs.Where(x => x.MaDanToc == maDanToc).Single<DanToc>();
                context.DanTocs.Remove(danToc);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateDanToc(DanToc danTocUpdate)
        {
            try
            {
                DanToc danToc = context.DanTocs.Where(x => x.MaDanToc == danTocUpdate.MaDanToc).Single<DanToc>();
                danToc.TenDanToc = danTocUpdate.TenDanToc;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
