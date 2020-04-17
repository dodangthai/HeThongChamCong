use ATINChamCong
go


alter table ChamCong
drop constraint [FK_dbo.ChamCong_CacLoaiVang]
alter table ChamCong
drop constraint [FK_dbo.ChamCong_CaLamViec]
alter table ChamCong
drop constraint [FK_dbo.ChamCong_XepLoaiChamCong]

alter table ChamCong
alter column MaCaLamViec varchar(5) Null
alter table ChamCong
alter column SoGioLamViec float Null
alter table ChamCong
alter column SoCongLamViec float Null
alter table ChamCong
alter column SoPhutDiTre int Null
alter table ChamCong
alter column SoPhutVeSom int Null
alter table ChamCong
alter column SoPhutBuGio int Null
alter table ChamCong
alter column TangCa1 int Null
alter table ChamCong
alter column TangCa2 float Null
alter table ChamCong
alter column TangCa3 float Null
alter table ChamCong
alter column TongSoGioLamViec float Null
alter table ChamCong
alter column TongSoCongLamViec float Null
go




create or alter proc spInsertChamCongChiTiet
@MaNguoi int,
@GioChamCong dateTime,
@MaLoaiChamCong varchar(3),
@NguonThucHien int
as
declare @MaChamCong as int
begin
	set xact_abort on
	begin tran
		if(Not Exists(select * from ChamCong where ChamCong.NgayChamCong = convert(date, @GioChamCong)
													and ChamCong.MaNhanVien = @MaNguoi))
			begin
			Insert into ChamCong(
								 MaNhanVien,
								 NgayChamCong
								 )
			values (@MaNguoi, convert(date, @GioChamCong));
			set @MaChamCOng = (SELECT max(ChamCong.MaChamCong) from ChamCong);
			end
		else
			begin
			set @MaChamCong = (select MaChamCong from ChamCong where ChamCong.NgayChamCong = convert(date, @GioChamCong)
													and ChamCong.MaNhanVien = @MaNguoi)
			end

		Insert into ChamCongChiTiet(MaChamCong, NgayChamCong, GioChamCong, MaLoaiChamCong, NguonThucHien)
		values (@MaChamCong, CONVERT(date, @GioChamCong), @GioChamCong, @MaLoaiChamCong, @NguonThucHien)
	commit
end
go