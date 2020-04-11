using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class TrinhDoHocVanManager
    {
        private static TrinhDoHocVanManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static TrinhDoHocVanManager Instance
        {
            get
            {
                return _instance ?? (_instance = new TrinhDoHocVanManager());
            }
        }

        public List<TrinhDoHocVan> GetAllTrinhDo()
        {
            try
            {
                var listTrinhDoHocVan = context.TrinhDoHocVans.ToList();
                return listTrinhDoHocVan;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteTrinhDoHocVan(int maTrinhDoHocVan)
        {
            try
            {
                TrinhDoHocVan trinhDoHocVan = context.TrinhDoHocVans.Where(x => x.MaTrinhDoHocVan == maTrinhDoHocVan).Single<TrinhDoHocVan>();
                context.TrinhDoHocVans.Remove(trinhDoHocVan);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public int AddTrinhDoHocVan(TrinhDoHocVan trinhDoHocVan)
        {
            try
            {
                context.TrinhDoHocVans.Add(trinhDoHocVan);
                context.SaveChanges();

                int maTrinhDoHocVan = trinhDoHocVan.MaTrinhDoHocVan;
                return maTrinhDoHocVan;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateTrinhDoHocVan(TrinhDoHocVan trinhDoHocVanUpdate)
        {
            try
            {
                TrinhDoHocVan trinhDoHocVan = context.TrinhDoHocVans.Where(x => x.MaTrinhDoHocVan == trinhDoHocVanUpdate.MaTrinhDoHocVan).Single<TrinhDoHocVan>();
                trinhDoHocVan.TenTrinhDoHocVan = trinhDoHocVanUpdate.TenTrinhDoHocVan;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
