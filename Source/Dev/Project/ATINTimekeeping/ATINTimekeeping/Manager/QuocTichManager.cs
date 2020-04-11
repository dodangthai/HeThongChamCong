using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class QuocTichManager
    {
        private static QuocTichManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static QuocTichManager Instance
        {
            get
            {
                return _instance ?? (_instance = new QuocTichManager());
            }
        }

        public List<QuocTich> GetAllQuocTich()
        {
            try
            {
                var listQuocTich = context.QuocTiches.ToList();
                return listQuocTich;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public QuocTich GetQuocTich(int maQuocTich)
        {
            try
            {
                return context.QuocTiches
                    .Where(c => c.MaQuocTich == maQuocTich)
                    .Single<QuocTich>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddQuocTich(QuocTich quocTich)
        {
            try
            {
                context.QuocTiches.Add(quocTich);
                context.SaveChanges();

                int maQuocTich = quocTich.MaQuocTich;
                return maQuocTich;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteQuocTich(int maQuocTich)
        {
            try
            {
                QuocTich quocTich = context.QuocTiches.Where(x => x.MaQuocTich == maQuocTich).Single<QuocTich>();
                context.QuocTiches.Remove(quocTich);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateQuocTich(QuocTich quocTichUpdate)
        {
            try
            {
                QuocTich quocTich = context.QuocTiches.Where(x => x.MaQuocTich == quocTichUpdate.MaQuocTich).Single<QuocTich>();
                quocTich.TenQuocTich = quocTichUpdate.TenQuocTich;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
