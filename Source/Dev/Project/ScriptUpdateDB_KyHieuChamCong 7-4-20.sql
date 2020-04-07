use ATINChamCong
go

Create table KyHieuChamCong
(
MaKyHieu int NOT NULL identity(1,1),
TenKyHieu varchar(5) NOT NULL,
MoTa nvarchar(255) NULL,
SuDung bit NOT NULL
primary key (MaKyHieu)
)
begin
Set nocount on
Insert into KyHieuChamCong(TenKyHieu, MoTa, SuDung)
values ('DT',N'Ký Hiệu đi trễ', 1)
Insert into KyHieuChamCong(TenKyHieu, MoTa, SuDung)
values ('vs',N'Ký Hiệu về sớm', 1)
Insert into KyHieuChamCong(TenKyHieu, MoTa, SuDung)
values ('dg',N'Ký Hiệu đúng giờ', 1)
Insert into KyHieuChamCong(TenKyHieu, MoTa, SuDung)
values ('tc',N'Ký Hiệu tăng ca', 1)
Insert into KyHieuChamCong(TenKyHieu, MoTa, SuDung)
values ('tgr',N'Ký Hiệu thiếu giờ ra', 1)
Insert into KyHieuChamCong(TenKyHieu, MoTa, SuDung)
values ('tgv',N'Ký Hiệu thiếu giờ vào', 1)
Insert into KyHieuChamCong(TenKyHieu, MoTa, SuDung)
values ('v',N'Ký Hiệu vắng', 1)
Insert into KyHieuChamCong(TenKyHieu, MoTa, SuDung)
values ('qd',N'Ký Hiệu đúng giờ ca có qua đêm', 1)
Insert into KyHieuChamCong(TenKyHieu, MoTa, SuDung)
values ('kx',N'Ký Hiệu ngày không xếp ca', 1)
end
go

Create or alter proc spGetAllKyHieuChamCong
as
begin
select*
from KyHieuChamCong
end
go

Create or alter proc spUpdateKyHeuChamCong
@MaKyHieu int,
@TenKyHieu varchar(5),
@SuDung bit
as
begin
update KyHieuChamCong
set
TenKyHieu = @TenKyHieu,
SuDung=@SuDung
where MaKyHieu = @MaKyHieu
end
go
