use ATINChamCong
go

create or alter View ViewSuaGioChamCong as
SELECT CCCT.MaChamCongChiTiet, CC.MaNhanVien, CCCT.MaChamCong, CCCT.NgayChamCong, CCCT.GioChamCong, CCCT.MaLoaiChamCong, CCCT.NguonThucHien, CCCT.MaThietBi
FROM     dbo.ChamCong AS CC RIGHT OUTER JOIN
                  dbo.ChamCongChiTiet AS CCCT ON CC.MaChamCong = CCCT.MaChamCong LEFT OUTER JOIN
                  dbo.Nguoi AS N ON N.MaNguoi = CC.MaNhanVien
go
create or alter proc spGetViewSuaGioChamCongByNguoiByTime
@MaNhanVien int,
@GioChamCong datetime
as
begin
select*
from ViewSuaGioChamCong
where MaNhanVien = @MaNhanVien
	and
		convert(date, GioChamCong) = convert(date, @GioChamCong)
end
go

create or alter proc spUpdateChamCongChiTiet
@MaChamCongChiTiet int,
@GioChamCong datetime
as
begin
update ChamCongChiTiet
Set GioChamCong = @GioChamCong
where MaChamCongChiTiet = @MaChamCongChiTiet
end
go

create or alter proc spDeleteChamCongChiTietByMaCCCT
@MaChamCongChiTiet int
as
begin
delete from ChamCongChiTiet
where MaChamCongChiTiet = @MaChamCongChiTiet
end
go

