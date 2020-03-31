Create proc spGetAllCaLamViec
as
Select * 
From CaLamViec
go

Create proc spGetCaLamViec
@MaCaLamViec int
as
begin
Select *
From CaLamViec
Where MaCaLamViec = @MaCaLamViec
end
go

Alter proc spInsertCaLamViec
@TenCaLamViec nvarchar(50), @GioBatDauCa time(7), @GioKetThucCa time(7), @GioBatDauGiaiLao time(7), @GioKetThucGiaiLao time(7),
@TongGio int,  @DiemCong int, @GioVaoSomNhatDuocTinhCa time(7), @GioVaoMuonNhatDuocTinhCa time(7), @GioRaMuonNhatDuocTinhCa time(7), 
@GioRaSomNhatDuocTinhCa time(7), @KhongCoGioRa int, @KhongCoGioVao int, @TruGioDiTre bit, @ThoiGianDiTreChoPhep int, @TruGioVeSom bit, @ThoiGianVeSomChoPhep int,
@GioiHanTCMucMot int,@GioiHanTCMucHai int,@SDMucTangCaCuaTangCaCuoiTuan bit, @MucTangCaCuaTangCaCuoiTuan int, @SDMucTangCaCuaTangCaNgayLe bit, @MucTangCaCuaTangCaNgayLe int, @GioiHanTCTruocGLV int,
@GioiHanTCSauGLV int, @CaQuaDem bit, @TachGioCaDemTu time(7), @TachGioCaDemDen time(7)
as
begin
insert into CaLamViec(TenCaLamViec, 
GioBatDauCa, 
GioKetThucCa, 
GioBatDauGiaiLao, 
GioKetThucGiaiLao , 
TongGio, 
DiemCong, 
GioVaoSomNhatDuocTinhCa, 
GioVaoMuonNhatDuocTinhCa, 
GioRaMuonNhatDuocTinhCa, 
GioRaSomNhatDuocTinhCa, 
KhongCoGioRa, 
KhongCoGioVao, 
TruGioDiTre, 
ThoiGianDiTreChoPhep, 
TruGioVeSom, 
ThoiGianVeSomChoPhep, 
GioiHanTCMucMot, 
GioiHanTCMucHai,
SDMucTangCaCuaTangCaCuoiTuan, 
MucTangCaCuaTangCaCuoiTuan, 
SDMucTangCaCuaTangCaNgayLe, 
MucTangCaCuaTangCaNgayLe, 
GioiHanTCTruocGLV,
GioiHanTCSauGLV, 
CaQuaDem, 
TachGioCaDemTu, 
TachGioCaDemDen)
values (@TenCaLamViec, 
@GioBatDauCa, 
@GioKetThucCa, 
@GioBatDauGiaiLao, 
@GioKetThucGiaiLao, 
@TongGio, 
@DiemCong, 
@GioVaoSomNhatDuocTinhCa,
@GioVaoMuonNhatDuocTinhCa,
@GioRaMuonNhatDuocTinhCa, 
@GioRaSomNhatDuocTinhCa,
@KhongCoGioRa,
@KhongCoGioVao,
@TruGioDiTre,
@ThoiGianDiTreChoPhep, 
@TruGioVeSom, 
@ThoiGianVeSomChoPhep,
@GioiHanTCMucMot,
@GioiHanTCMucHai,
@SDMucTangCaCuaTangCaCuoiTuan, 
@MucTangCaCuaTangCaCuoiTuan, 
@SDMucTangCaCuaTangCaNgayLe, 
@MucTangCaCuaTangCaNgayLe, 
@GioiHanTCTruocGLV,
@GioiHanTCSauGLV, 
@CaQuaDem, 
@TachGioCaDemTu,
@TachGioCaDemDen);
end
go

Create proc spDeleteCaLamViec
@MaCaLamViec nvarchar(50)
as
begin
delete from CaLamViec
where MaCaLamViec = @MaCaLamViec;
end
go

Alter proc spUpdateCaLamViec
@MaCaLamViec int,
@TenCaLamViec nvarchar(50), 
@GioBatDauCa time(7), 
@GioKetThucCa time(7), 
@GioBatDauGiaiLao time(7), 
@GioKetThucGiaiLao time(7),
@TongGio int,  
@DiemCong int, 
@GioVaoSomNhatDuocTinhCa time(7), 
@GioVaoMuonNhatDuocTinhCa time(7), 
@GioRaMuonNhatDuocTinhCa time(7), 
@GioRaSomNhatDuocTinhCa time(7), 
@KhongCoGioRa int, 
@KhongCoGioVao int, 
@TruGioDiTre bit, 
@ThoiGianDiTreChoPhep int, 
@TruGioVeSom bit, 
@ThoiGianVeSomChoPhep int,
@GioiHanTCMucMot int,
@GioiHanTCMucHai int,
@SDMucTangCaCuaTangCaCuoiTuan bit, 
@MucTangCaCuaTangCaCuoiTuan int,
@SDMucTangCaCuaTangCaNgayLe bit, 
@MucTangCaCuaTangCaNgayLe int, 
@GioiHanTCTruocGLV int,
@GioiHanTCSauGLV int, 
@CaQuaDem bit, 
@TachGioCaDemTu time(7), 
@TachGioCaDemDen time(7)
as
begin
update CaLamViec
set 
TenCaLamViec = @TenCaLamViec, 
GioBatDauCa=@GioBatDauCa, 
GioKetThucCa=@GioKetThucCa, 
GioBatDauGiaiLao=@GioBatDauGiaiLao, 
GioKetThucGiaiLao= @GioKetThucGiaiLao, 
TongGio=@TongGio, 
DiemCong=@DiemCong, 
GioVaoSomNhatDuocTinhCa=@GioVaoSomNhatDuocTinhCa, 
GioVaoMuonNhatDuocTinhCa=@GioVaoMuonNhatDuocTinhCa, 
GioRaMuonNhatDuocTinhCa=@GioRaMuonNhatDuocTinhCa, 
GioRaSomNhatDuocTinhCa=@GioRaSomNhatDuocTinhCa,
KhongCoGioRa=@KhongCoGioRa, 
KhongCoGioVao= @KhongCoGioVao,
TruGioDiTre=@TruGioDiTre, 
ThoiGianDiTreChoPhep=@ThoiGianDiTreChoPhep, 
TruGioVeSom=@TruGioVeSom, 
ThoiGianVeSomChoPhep=@ThoiGianVeSomChoPhep, 
GioiHanTCMucMot=@GioiHanTCMucMot, 
GioiHanTCMucHai=@GioiHanTCMucHai,
SDMucTangCaCuaTangCaCuoiTuan=@SDMucTangCaCuaTangCaCuoiTuan, 
MucTangCaCuaTangCaCuoiTuan=@MucTangCaCuaTangCaCuoiTuan, 
SDMucTangCaCuaTangCaNgayLe=@SDMucTangCaCuaTangCaNgayLe, 
MucTangCaCuaTangCaNgayLe=@MucTangCaCuaTangCaNgayLe, 
GioiHanTCTruocGLV=@GioiHanTCTruocGLV, 
GioiHanTCSauGLV=@GioiHanTCSauGLV, 
CaQuaDem=@CaQuaDem, 
TachGioCaDemTu=@TachGioCaDemTu, 
TachGioCaDemDen=@TachGioCaDemDen
where MaCaLamViec = @MaCaLamViec;
end
go

