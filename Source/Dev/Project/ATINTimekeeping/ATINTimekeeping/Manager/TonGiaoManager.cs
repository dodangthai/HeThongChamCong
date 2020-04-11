using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class TonGiaoManager
    {
        private static TonGiaoManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static TonGiaoManager Instance
        {
            get
            {
                return _instance ?? (_instance = new TonGiaoManager());
            }
        }

        public List<TonGiao> GetAllTonGiao()
        {
            try
            {
                var listTonGiao = context.TonGiaos.ToList();
                return listTonGiao;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteTonGiao(int maTonGiao)
        {
            try
            {
                TonGiao tonGiao = context.TonGiaos.Where(x => x.MaTonGiao == maTonGiao).Single<TonGiao>();
                context.TonGiaos.Remove(tonGiao);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void AddTonGiao(TonGiao tonGiao)
        {
            try
            {
                context.TonGiaos.Add(tonGiao);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateTonGiao(TonGiao tonGiaoUpdate)
        {
            try
            {
                TonGiao tonGiao = context.TonGiaos.Where(x => x.MaTonGiao == tonGiaoUpdate.MaTonGiao).Single<TonGiao>();
                tonGiao.TenTonGiao = tonGiaoUpdate.TenTonGiao;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
