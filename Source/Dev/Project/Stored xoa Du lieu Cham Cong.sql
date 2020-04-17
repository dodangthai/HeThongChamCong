use ATINChamCong
go

create proc spDeleteChamCongChiTietByNguoi
@MaNguoi int,
@FromDate Datetime,
@ToDate Datetime,
@DeleteChamCong bit
as
begin
set xact_abort on
begin tran
if(@DeleteChamCong = 0)
	begin
	Delete
	from ChamCongChiTiet
	where MaChamCongChiTiet = (Select CCCT.MaChamCongChiTiet from ChamCongChiTiet as CCCT
																left join ChamCong as CC on CCCT.MaChamCong = CC.MaChamCong
																left join Nguoi as N on CC.MaNhanVien = N.MaNguoi
								where N.MaNguoi = @MaNguoi 
									and CONVERT(date, CCCT.GioChamCong) >=CONVERT(date, @FromDate) 
									and CONVERT(date, CCCT.GioChamCong) <=CONVERT(date, @ToDate) 

							)
	end

if(@DeleteChamCong = 1)
	begin
	Delete
	from ChamCongChiTiet
	where MaChamCongChiTiet = (Select CCCT.MaChamCongChiTiet from ChamCongChiTiet as CCCT
																left join ChamCong as CC on CCCT.MaChamCong = CC.MaChamCong
																left join Nguoi as N on CC.MaNhanVien = N.MaNguoi
								where N.MaNguoi = @MaNguoi 
									and CONVERT(date, CCCT.GioChamCong) >=CONVERT(date, @FromDate) 
									and CONVERT(date, CCCT.GioChamCong) <=CONVERT(date, @ToDate) 

							)

	Delete
	from ChamCong
		where MaChamCong = (Select CC.MaChamCong from ChamCong as CC
												inner join Nguoi as N on CC.MaNhanVien = N.MaNguoi
												where N.MaNguoi =@MaNguoi
							)
	end
commit
end
go