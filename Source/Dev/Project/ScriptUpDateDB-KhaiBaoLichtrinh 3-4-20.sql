use ATINChamCong

--remove FK
begin
ALTER TABLE LichTrinhTuan
DROP CONSTRAINT [FK_dbo.LichTrinhTuan_ChuKyTuan];
ALTER TABLE LichTrinhNam
DROP CONSTRAINT [FK_dbo.LichTrinhNam_ChuKyNam];
ALTER TABLE LichTrinhThang
DROP CONSTRAINT [FK_dbo.LichTrinhThang_ChuKyThang];
ALTER TABLE LichTrinh
DROP CONSTRAINT [FK_dbo.LichTrinh_LoaiChuKy];
end
go

--drop unnecessary table
begin
delete from ChuKyNam;
delete from ChuKyTuan;
delete from ChuKyThang;
delete from LoaiChuKy;
Drop table ChuKyNam;
Drop table ChuKyTuan;
Drop table ChuKyThang;
Drop table LoaiChuKy;
end
go

begin
alter table LichTrinh
drop COLUMN MaLoaiChuKy;
alter table LichTrinh
add LoaiChuKy varchar(5) NOT NULL
end 
go

begin
ALTER TABLE LichTrinhNam
drop column MaChuKyNam;
ALTER TABLE LichTrinhNam
add 
MaLichTrinh varchar(5) NOT NULL,
[Date] int NOT NULL,
[Month] int NOT NULL
;
ALTER TABLE LichTrinhNam
ADD CONSTRAINT FK_LichTrinhNam_LichTrinh
FOREIGN KEY (MaLichTrinh) REFERENCES LichTrinh(MaLichTrinh);
end
go

begin
ALTER TABLE LichTrinhThang
drop column MaChuKyThang;
ALTER TABLE LichTrinhThang
add 
MaLichTrinh varchar(5) NOT NULL,
[Date] int NOT NULL
;
ALTER TABLE LichTrinhThang
ADD CONSTRAINT FK_LichTrinhThang_LichTrinh
FOREIGN KEY (MaLichTrinh) REFERENCES LichTrinh(MaLichTrinh);
end
go

begin
ALTER TABLE LichTrinhTuan
drop column MaChuKyTuan;
ALTER TABLE LichTrinhTuan
add 
MaLichTrinh varchar(5) NOT NULL,
[DateInWeek] int NOT NULL
;
ALTER TABLE LichTrinhTuan
ADD CONSTRAINT FK_LichTrinhTuan_LichTrinh
FOREIGN KEY (MaLichTrinh) REFERENCES LichTrinh(MaLichTrinh);
end
go