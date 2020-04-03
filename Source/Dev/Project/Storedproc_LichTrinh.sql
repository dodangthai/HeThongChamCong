Create proc spGetAllLichTrinh
as
begin
Select*
from LichTrinh
end
go

Create proc spGetLichTrinh
@MaCaLamViec varchar(5)
as
begin
Select *
From CaLamViec
Where MaCaLamViec = @MaCaLamViec
end
go

Create proc spGetLichTrinhTuanByLichTrinh
@MaLichTrinh varchar(5)
as
begin
Select*
From LichTrinhTuan
Where MaLichTrinh =@MaLichTrinh
end
go

Create proc spGetLichTrinhThangByLichTrinh
@MaLichTrinh varchar(5)
as
begin
Select*
From LichTrinhThang
Where MaLichTrinh =@MaLichTrinh
end
go

Create proc spGetLichTrinhNamByLichTrinh
@MaLichTrinh varchar(5)
as
begin
Select*
From LichTrinhNam
Where MaLichTrinh =@MaLichTrinh
end
go

Create proc spGetMapLichTrinhNangCaoByLichTrinh
@MaLichTrinh varchar(5)
as
begin
select*
from MapLichTrinhNangCao
where MaLichTrinh=@MaLichTrinh
end
go

Create proc spInsertLichTrinh
@MaLichTrinh varchar(5),
@TenLichTrinh nvarchar(30),
@LoaiChuKy varchar(5)
as
begin
insert into LichTrinh(MaLichTrinh, TenLichTrinh, LoaiChuKy)
values (@MaLichTrinh, @TenLichTrinh, @LoaiChuKy)
end
go

Create proc spInsertMapLichTrinhNangCao
@MaLichTrinh varchar(5),
@MaLichTrinhNangCao varchar(5)
as
begin
	if not exists(select* from MapLichTrinhNangCao where MaLichTrinh = @MaLichTrinh and MaLichTrinhNangCao = @MaLichTrinhNangCao)
	begin
	insert into MapLichTrinhNangCao(MaLichTrinh,MaLichTrinhNangCao)
	values (@MaLichTrinh, @MaLichTrinhNangCao)
	end
end
go

Create proc spInsertLichTrinhTuan
@MaLichTrinh varchar(5),
@MaCaLamViec varchar(5),
@DateInWeek int
as
begin
	if not EXISTS (
	select * 
	from LichTrinhTuan 
	where MaLichTrinh = @MaLichTrinh
		and
		MaCaLamViec = @MaCaLamViec
		and
		DateInWeek = @DateInWeek
	)
	begin
	insert into LichTrinhTuan(MaLichTrinh, MaCaLamViec, DateInWeek)
	values (@MaLichTrinh, @MaCaLamViec, @DateInWeek)
	end
end

go

Create proc spInsertLichTrinhThang
@MaLichTrinh varchar(5),
@MaCaLamViec varchar(5),
@Date int
as
begin
	if not EXISTS (
	select * 
	from LichTrinhThang
	where MaLichTrinh = @MaLichTrinh
		and
		MaCaLamViec = @MaCaLamViec
		and
		Date = @Date
	)
	begin
	insert into LichTrinhThang(MaLichTrinh, MaCaLamViec, Date)
	values (@MaLichTrinh, @MaCaLamViec, @Date)
	end
end
go

Create proc spInsertLichTrinhNam
@MaLichTrinh varchar(5),
@MaCaLamViec varchar(5),
@Date int,
@Month int
as
begin
	if not EXISTS (
	select * 
	from LichTrinhNam
	where MaLichTrinh = @MaLichTrinh
		and
		MaCaLamViec = @MaCaLamViec
		and
		Date = @Date
		and
		Month = @Month
	)
	begin
	insert into LichTrinhNam(MaLichTrinh, MaCaLamViec, Date, Month)
	values (@MaLichTrinh, @MaCaLamViec, @Date, @Month)
	end
end
go

Create proc spUpdateLichTrinh
@MaLichTrinhChon varchar(5),
@MaLichTrinh varchar(5),
@TenLichTrinh nvarchar(30),
@LoaiChuKy varchar(5)
as
begin
update LichTrinh
set 
--MaLichTrinh=@MaLichTrinh, 
TenLichTrinh=@TenLichTrinh, 
LoaiChuKy=@LoaiChuKy
where MaLichTrinh = @MaLichTrinhChon
end
go

Create proc spDeleteMapLichTrinhNangCao
@MaLichTrinh varchar(5),
@MaLichTrinhNangCao varchar(5)
as
begin
delete
from MapLichTrinhNangCao
where	MaLichTrinh = @MaLichTrinh 
		and
		MaLichTrinhNangCao = @MaLichTrinhNangCao
end
go


Create proc spDeleteLichTrinh
@MaLichTrinh varchar(5)
as
begin
	set XACT_ABORT ON
	begin tran
	delete
	from MapLichTrinhNangCao
	where MaLichTrinh = @MaLichTrinh
	delete
	from LichTrinhNam
	where MaLichTrinh = @MaLichTrinh
	delete
	from LichTrinhTuan
	where MaLichTrinh = @MaLichTrinh
	delete
	from LichTrinhThang
	where MaLichTrinh = @MaLichTrinh
	Delete
	from LichTrinh
	where MaLichTrinh = @MaLichTrinh
	commit
end
go

Create proc spDeleteLichTrinhTuan
@MaLichTrinh varchar(5),
@MaCaLamViec varchar(5),
@DateInWeek int
as
begin
delete
from LichTrinhTuan
where	MaLichTrinh = @MaLichTrinh
		And 
		DateInWeek = @DateInWeek 
		And
		MaCaLamViec = @MaCaLamViec
end
go
Create proc spDeleteAllLichTrinhTuanByLichTrinh
@MaLichTrinh varchar(5)
as
begin
delete
from LichTrinhTuan
where	MaLichTrinh = @MaLichTrinh
end
go

Create proc spDeleteLichTrinhThang
@MaLichTrinh varchar(5),
@MaCaLamViec varchar(5),
@Date int
as
begin
delete
from LichTrinhThang
where	MaLichTrinh = @MaLichTrinh
		And 
		Date = @Date
		And
		MaCaLamViec = @MaCaLamViec
end
go

Create proc spDeleteAllLichTrinhThangByLichTrinh
@MaLichTrinh varchar(5)
as
begin
delete
from LichTrinhThang
where	MaLichTrinh = @MaLichTrinh
end
go

Create proc spDeleteLichTrinhNam
@MaLichTrinh varchar(5),
@MaCaLamViec varchar(5),
@Date int,
@Month int
as
begin
delete
from LichTrinhNam
where	MaLichTrinh = @MaLichTrinh
		And 
		Date = @Date
		And
		MaCaLamViec = @MaCaLamViec
		And
		Month = @Month
end
go

Create proc spDeleteAllLichTrinhNamByLichTrinh_Month
@MaLichTrinh varchar(5),
@Month int
as
begin
delete
from LichTrinhNam
where	MaLichTrinh = @MaLichTrinh
		and
		Month = @Month
end
go