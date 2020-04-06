use ATINChamCong
go

Create proc spInsertSapxepLichTrinhTam
@TuNgay date,
@DenNgay date,
@MaLichTrinh varchar(5),
@MaNguoi int
as
begin
insert into SapXepLichTrinhTam(
TuNgay,
DenNgay,
MaLichTrinh,
MaNguoi
)
values(
@TuNgay,
@DenNgay,
@MaLichTrinh,
@MaNguoi
)
end
go

Create proc spUpdateSapxepLichTrinhTam
@MaLichTrinhTam int,
@TuNgay date,
@DenNgay date,
@MaLichTrinh varchar(5),
@MaNguoi int
as
begin
update SapXepLichTrinhTam
set
TuNgay = @TuNgay,
DenNgay = @DenNgay,
MaLichTrinh = @MaLichTrinh,
MaNguoi = @MaNguoi
where MaLichTrinhTam = @MaLichTrinhTam
end
go

Create proc spDeleteSapXepLichTrinhTam
@MaLichTrinhTam int
as
begin
delete
from SapXepLichTrinhTam
where MaLichTrinhTam = @MaLichTrinhTam
end
go

Create proc spGetAllSapXepLichTrinhTam
as
begin
Select* from SapXepLichTrinhTam
end
go

Create proc spGetSapXepLichTrinhTamByNguoi
@MaNguoi int
as
begin
Select *
from SapXepLichTrinhTam
where MaNguoi = @MaNguoi
end
go
