use ATINChamCong
go

Create table ChamCongLoaiVang(
MaChamCong int not null,
MaCaLamViec varchar(5) not null,
MaKyHieu varchar(5) not null,
LyDoVang nvarchar(max),
primary key (MaChamCong,MaCaLamViec),
constraint FK_ChamCongLoaiVang_ChamCong foreign key (MaChamCong) references ChamCong(MaChamCong),
constraint FK_ChamCongLoaiVang_CaLamViec foreign key (MaCaLamViec) references CaLamViec(MaCaLamViec),
constraint FK_ChamCongLoaiVang_KyHieuCacLoaiVang foreign key (MaKyHieu) references KyHieuCacLoaiVang(MaKyHieu)
)
go
create or alter View ViewDanhSachVang 
as
Select CC.MaNhanVien,CC.MaChamCong, CC.NgayChamCong, CLV.DiemCong, KHCLV.MoTa, CLV.MaCaLamViec, CCLV.LyDoVang
from ChamCongLoaiVang as CCLV
	left join ChamCong as CC on CCLV.MaChamCong = CC.MaChamCong
	left join CaLamViec as CLV on CCLV.MaCaLamViec = CLV.MaCaLamViec
	left join KyHieuCacLoaiVang as KHCLV on KHCLV.MaKyHieu = CCLV.MaKyHieu
go

create or alter proc spGetViewDanhSachVangByNguoi
@MaNhanVien int
as
begin
select* from ViewDanhSachVang
where MaNhanVien = @MaNhanVien
end
go

create or alter proc spInsertChamCongLoaiVang
@NgayChamCong Datetime,
@MaNguoi int,
@MaCaLamViec varchar(5),
@MaKyHieu varchar(5),
@LyDoVang nvarchar(max)
as
declare @MaChamCong int
begin
	if(Not Exists (Select * from ChamCong where MaNhanVien = @MaNguoi and Convert(date, NgayChamCong)=Convert(date,@NgayChamCong)))
	begin
		Insert into ChamCong(MaNhanVien, NgayChamCong)
		values (@MaNguoi, CONVERT(date, @NgayChamCong))
		Set @MaChamCong = (SELECT max(ChamCong.MaChamCong) from ChamCong);
	end
	else
	begin
		set @MaChamCong = (select MaChamCong from ChamCong where ChamCong.NgayChamCong = convert(date, @NgayChamCong)
														and ChamCong.MaNhanVien = @MaNguoi)
	end
	Insert into ChamCongLoaiVang(MaChamCong, MaCaLamViec,MaKyHieu,LyDoVang)
	values (@MaChamCong, @MaCaLamViec, @MaKyHieu, @LyDoVang)
end
go

create or alter proc spDeleteChamCongLoaiVang
@MaChamCong int,
@MaCaLamViec varchar(5)
as
begin
delete
from ChamCongLoaiVang
where MaChamCong = @MaChamCong and MaCaLamViec = @MaCaLamViec
end
go

create or alter proc spUpdateChamCongLoaiVang
@MaChamCong int,
@MaCaLamViec varchar(5),
@MaKyHieu varchar(5),
@LyDoVang nvarchar(max)
as
begin
update ChamCongLoaiVang
Set MaKyHieu = @MaKyHieu,
	LyDoVang = @LyDoVang
where MaChamCong = @MaChamCong and MaCaLamViec = @MaCaLamViec
end
go