use ATINChamCong
go


CREATE OR Alter VIEW [ViewSapXepLichTrinh] as
SELECT N.MaNguoi, N.HoTen, C.MaChamCong, SX.MaLichTrinh, SX.MaSapXep
FROM 
(Nguoi as N
left join ChamCong as C On  N.MaNguoi = c.MaNhanVien)
left join SapXepLichTrinh as SX on N.MaNguoi = SX.MaNguoi
go
Create or ALTER   proc [spGetViewSapXepLichTrinhByNguoi]
@MaNguoi int 
as
begin
select *
From ViewSapXepLichTrinh
where MaNguoi = @MaNguoi
end
go



