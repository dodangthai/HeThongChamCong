use ATINChamCong
go

--Create proc spInsertPhongBan
--@MaPhongBan int,
--@TenPhongBan nvarchar(100)
--as
--begin
--insert into PhongBan(MaPhongBan,TenPhongBan)
--values (@MaPhongBan,@TenPhongBan);
--end
--go

--Create proc spUpdatePhongBan
--@MaPhongBan int,
--@TenPhongBan nvarchar(100)
--as
--begin
--update PhongBan
--set TenPhongBan=@TenPhongBan
--where MaPhongBan = @MaPhongBan
--end
--go

--Create proc spDeletePhongBan
--@MaPhongBan int
--as
--begin
--delete
--from PhongBan
--where MaPhongBan = @MaPhongBan
--end
--go

Create or alter proc spGetAllPhongBan
as
begin
Select*
from PhongBan
end
go

--Create proc spGetPhongBan
--@MaPhongBan int
--as
--begin
--select *
--from PhongBan
--where MaPhongBan = @MaPhongBan
--end
--go