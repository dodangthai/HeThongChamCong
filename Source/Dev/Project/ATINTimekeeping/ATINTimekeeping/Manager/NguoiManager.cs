using ATINTimekeeping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        public List<Nguoi> SearchNguoi (int maNguoi, string hoTen, int maPhongBan)
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

        public Nguoi GetNguoi(int maNguoi)
        {
            Nguoi nguoi = new Nguoi();

            try
            {
                nguoi = context.Nguois
                .Where(c => c.MaNguoi == maNguoi)
                .Single<Nguoi>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return nguoi;
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

        public void UpdateNguoi (Nguoi nguoiUpdate)
        {
            try
            {
                Nguoi nguoi = context.Nguois.Where(x => x.MaNguoi == nguoiUpdate.MaNguoi).Single<Nguoi>();
                nguoi.HoTen = nguoiUpdate.HoTen;
                nguoi.MaDinhDanh = nguoiUpdate.MaDinhDanh;
                nguoi.MaPhongBan = nguoiUpdate.MaPhongBan;
                nguoi.MaChucVu = nguoiUpdate.MaChucVu;
                nguoi.NgayNhanViec = nguoiUpdate.NgayNhanViec;
                nguoi.NgaySinh = nguoiUpdate.NgaySinh;
                nguoi.AnhDaiDien = nguoiUpdate.AnhDaiDien;
                nguoi.MaGioiTinh = nguoiUpdate.MaGioiTinh;
                nguoi.TinhTrangHonNhan = nguoiUpdate.TinhTrangHonNhan;
                nguoi.MaTrinhDo = nguoiUpdate.MaTrinhDo;
                nguoi.MaDanToc = nguoiUpdate.MaDanToc;
                nguoi.MaTonGiao = nguoiUpdate.MaTonGiao;
                nguoi.MaQuocTich = nguoiUpdate.MaQuocTich;
                nguoi.NgayCapTCC = nguoiUpdate.NgayCapTCC;
                nguoi.SoTheCanCuoc = nguoiUpdate.SoTheCanCuoc;
                nguoi.NoiCapTCC = nguoiUpdate.NoiCapTCC;
                nguoi.DiaChiThuongTru = nguoiUpdate.DiaChiThuongTru;
                nguoi.DiaChiTamTru = nguoiUpdate.DiaChiTamTru;
                nguoi.Email = nguoiUpdate.Email;
                nguoi.SoDienThoai = nguoiUpdate.SoDienThoai;
                nguoi.SuDungKhuonMat = nguoiUpdate.SuDungKhuonMat;
                nguoi.SuDungTheTu = nguoiUpdate.SuDungTheTu;
                nguoi.SuDungVanTay = nguoiUpdate.SuDungVanTay;
                nguoi.GhiChu = nguoiUpdate.GhiChu;
                nguoi.ThoiGianCapNhat = nguoiUpdate.ThoiGianCapNhat;
                nguoi.TrangThaiHoatDong = nguoiUpdate.TrangThaiHoatDong;

                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
