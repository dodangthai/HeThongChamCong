
Create or alter view ViewXemHinhChamCong as
select ChamCongChiTiet.MaChamCongChiTiet, ChamCongChiTiet.GioChamCong, ChamCongChiTiet.HinhChamCong, ChamCongChiTiet.MaThietBi, ChamCong.MaChamCong, Nguoi.MaNguoi, Nguoi.HoTen
from ChamCongChiTiet
join ChamCong on ChamCongChiTiet.MaChamCong = ChamCong.MaChamCong
join Nguoi on Nguoi.MaNguoi = ChamCong.MaNhanVien
go

Create or alter proc spGetViewXemHinhChamCongByTimeByMachine
@Time datetime,
@MaThietBi int,
@TimeType varchar(5)
as
begin
	IF(@TimeType = 'year')
	begin
	Select * 
	from ViewXemHinhChamCong
	where YEAR(GioChamCong) = YEAR(@Time) and MaThietBi = @MaThietBi
	end
	IF(@TimeType = 'month')
	begin
	Select * 
	from ViewXemHinhChamCong
	where YEAR(GioChamCong) = YEAR(@Time) and Month(GioChamCong) = Month(@Time) and MaThietBi = @MaThietBi
	end
	IF(@TimeType = 'date')
	begin
	Select * 
	from ViewXemHinhChamCong
	where CONVERT(date, GioChamCong) = CONVERT(date, @Time) and MaThietBi = @MaThietBi
	end
	IF(@TimeType = 'hour')
	begin
	Select * 
	from ViewXemHinhChamCong
	where CONVERT(date, GioChamCong) = CONVERT(date, @Time) and DATEPART(HOUR, GioChamCong) = DATEPART(HOUR, @Time) and MaThietBi = @MaThietBi
	end
end
go
