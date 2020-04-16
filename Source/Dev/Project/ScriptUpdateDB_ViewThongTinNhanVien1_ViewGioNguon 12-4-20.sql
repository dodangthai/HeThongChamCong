use ATINChamCong1
go


Create or alter View ViewThongTinNhanVien1
as
Select N.MaNguoi, N.HoTen, CC.MaChamCong, LT.MaLichTrinh,LT.TenLichTrinh, CV.MaChucVu,CV.TenChucVu, PB.MaPhongBan,PB.TenPhongBan, N.NgayNhanViec
from
Nguoi as N left join ChamCong as CC on  N.MaNguoi = CC.MaNhanVien
			left join PhongBan as PB on N.MaPhongBan = PB.MaPhongBan
			left join ChucVu as CV on N.MaChucVu = CV.MaChucVu
			left join SapXepLichTrinh as SXLT on N.MaNguoi = SXLT.MaNguoi
			left join LichTrinh as LT on SXLT.MaLichTrinh = LT.MaLichTrinh

go

Create or alter proc spGetAllViewThongTinNhanVien1
as
begin
Select * 
from ViewThongTinNhanVien1
end 
go

Create or alter proc spGetViewThongTinNhanVien1ByPhongBan
@MaPhongBan int
as
begin
Select * 
from ViewThongTinNhanVien1
where MaPhongBan = @MaPhongBan
end 
go


Create or alter View ViewGioNguon
as
Select CC.MaNhanVien,N.HoTen, CC.MaDinhDanh, CCCT.NgayChamCong,CCCT.GioChamCong, CCCT.MaLoaiChamCong, CCCT.NguonThucHien, CCCT.MaChamCong,CCCT.MaThietBi
From ChamCong as CC 
		Right join ChamCongChiTiet as CCCT on CC.MaChamCong = CCCT.MaChamCong
		left join Nguoi as N on N.MaNguoi = CC.MaNhanVien
go

Create or alter proc spGetAllViewGioNguonOrderByNgayGio
@MaNhanVien int,
@TuNgay date,
@DenNgay date
as
begin 
Select*
From ViewGioNguon
where 
	ViewGioNguon.MaNhanVien = @MaNhanVien
	And
	ViewGioNguon.NgayChamCong >= @TuNgay
	And
	ViewGioNguon.NgayChamCong <= @DenNgay
Order By ViewGioNguon.NgayChamCong ASC, ViewGioNguon.GioChamCong ASC
end
go



Create or alter View ViewGioChiaHaiCot
as
select  CC.MaNhanVien, N.HoTen , CC.MaDinhDanh, CCCT.NgayChamCong,CCCT.GioChamCong, CCCT.MaLoaiChamCong,  CCCT.MaChamCong, MND.TenMay
				--case
				--when CCCT.MaLoaiChamCong = 'IN' then CCCT.GioChamCong
				--else NULL 
				--end as GioVao,
				--case
				--when CCCT.MaLoaiChamCong = 'OUT' then CCCT.GioChamCong
				--else NULL 
				--end as GioRa
from ChamCongChiTiet as CCCT
		left join ChamCong as CC on CCCT.MaChamCong = CC.MaChamCong
		left join MayNhanDang as MND on CCCT.MaThietBi = MND.MaMay
		left join Nguoi as N on N.MaNguoi = CC.MaNhanVien
go

Create or alter proc spGetAllViewGioChiaHaiCot
@MaNhanVien int,
@TuNgay date,
@DenNgay date
as
begin
Select *
from ViewGioChiaHaiCot
where 
	MaNhanVien = @MaNhanVien
	And
	NgayChamCong >= @TuNgay
	And
	NgayChamCong <= @DenNgay
Order By ViewGioChiaHaiCot.NgayChamCong ASC, ViewGioChiaHaiCot.GioChamCong ASC
end
go

