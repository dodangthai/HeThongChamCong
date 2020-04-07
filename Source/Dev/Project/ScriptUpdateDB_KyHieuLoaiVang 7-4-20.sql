use ATINChamCong
go

Create table KyHieuCacLoaiVang
(
MaKyHieu varchar(5) Not NULL,
TenKyHieu varchar(5) Not Null,
MoTa nvarchar(255) null,
SuDung bit NOT NULL,
TinhCong bit not null
primary key (MaKyHieu)
)

begin
Set nocount on
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A01','OM',N'Nghỉ ốm', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A02','TS',N'Nghỉ thai sản', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A03','R',N'Nghỉ việc riêng có lương', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A04','Ro',N'Nghỉ việc riêng không lương', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A05','P',N'Nghỉ phép', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A06','F',N'Nghỉ phép năm', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A07','CO',N'Nghỉ con ốm', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A08','MD',N'Nghỉ mất điện', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A09','H',N'Nghỉ đi họp, đi học', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A010','CT',N'Nghỉ công tác', 1, 1)
Insert into KyHieuCacLoaiVang(MaKyHieu, TenKyHieu, MoTa, SuDung, TinhCong)
values ('A011','LE',N'Nghỉ lễ', 1, 1)
end
go

create proc spGetAllKyHieuCacLoaiVang
as
begin
select* 
from KyHieuCacLoaiVang
end
go

create or alter proc spUpdateKyHieuCacLoaiVang
@MaKyHieu varchar(5),
@SuDung bit,
@TinhCong bit
as
begin
update KyHieuCacLoaiVang
set
SuDung = @SuDung,
TinhCong = @TinhCong
where MaKyHieu = @MaKyHieu
end
go