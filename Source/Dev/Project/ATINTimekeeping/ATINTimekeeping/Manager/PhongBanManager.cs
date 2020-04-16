using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATINTimekeeping.Manager
{
    class PhongBanManager
    {
        private static PhongBanManager _instance;
        private ATINChamCongEntities context = new ATINChamCongEntities();

        public static PhongBanManager Instance
        {
            get
            {
                return _instance ?? (_instance = new PhongBanManager());
            }
        }

        public List<PhongBan> GetPhongBanByParentId(int parentId)
        {
            List<PhongBan> listPhongBan = new List<PhongBan>();

            try
            {
                listPhongBan = context.PhongBans
                    .Where(c => c.Cha == parentId)
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listPhongBan;
        }

        public List<PhongBan> GetAllPhongBan()
        {
            List<PhongBan> listPhongBan = new List<PhongBan>();
            try
            {
                listPhongBan = context.PhongBans.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return listPhongBan;
        }

        public int AddPhongBan(PhongBan phongBan)
        {
            int maPhongBan = -1;

            try
            {
                context.PhongBans.Add(phongBan);
                context.SaveChanges();

                maPhongBan = phongBan.MaPhongBan;                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return maPhongBan;
        }

        public PhongBan GetPhongBan(int maPhongBan)
        {
            PhongBan phongban = new PhongBan();

            try
            {
                phongban = context.PhongBans
                    .Where(c => c.MaPhongBan == maPhongBan)
                    .Single<PhongBan>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return phongban;
        }

        public void UpdatePhongBan(PhongBan phongBanUpdate)
        {
            try
            {
                PhongBan phongBan = context.PhongBans.Where(x => x.MaPhongBan == phongBanUpdate.MaPhongBan).Single<PhongBan>();
                phongBan.TenPhongBan = phongBanUpdate.TenPhongBan;
                phongBan.Cha = phongBanUpdate.Cha;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeletePhongBan(int maPhongBan)
        {
            try
            {
                PhongBan phongBan = context.PhongBans.Where(x => x.MaPhongBan == maPhongBan).Single<PhongBan>();
                context.PhongBans.Remove(phongBan);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
