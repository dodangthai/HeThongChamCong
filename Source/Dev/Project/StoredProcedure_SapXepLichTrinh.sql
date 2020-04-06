USE ATINChamCong
go

Create or alter Proc spInsertSapXepLichTrinh
@MaNguoi int,
@MaLichTrinh varchar(5)
as
begin
insert into SapXepLichTrinh(
MaNguoi,
MaLichTrinh
)
values(
@MaNguoi,
@MaLichTrinh
)
end
go

Create or alter proc spUpdateSapXepLichTrinh
@MaSapXep int,
@MaNguoi int,
@MaLichTrinh varchar(5)
as
begin
update SapXepLichTrinh
set
MaNguoi = @MaNguoi,
MaLichTrinh = @MaLichTrinh
end
go

Create or alter proc spDeleteSapXepLichTrinh
@MaSapXep int
as
begin
Delete
from SapXepLichTrinh
where MaSapXep = @MaSapXep
end
go

create or alter proc spGetAllSapXepLichTrinh
as
begin
select*
from SapXepLichTrinh
end
go

Create or alter proc spGetSapXepLichTrinhByNguoi
@MaNguoi int
as
begin
Select* 
from SapXepLichTrinh
where MaNguoi = @MaNguoi
end
go

Create or alter proc spGetViewSapXepLichTrinhByNguoi
@MaNguoi int 
as
begin
select *
From ViewSapXepLichTrinh
where MaNguoi = @MaNguoi
end
go