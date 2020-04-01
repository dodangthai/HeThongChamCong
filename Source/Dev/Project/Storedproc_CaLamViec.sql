
Create proc spGetAllCaLamViec
as
Select * 
From CaLamViec
go

Create proc spGetCaLamViec
@MaCaLamViec varchar(5)
as
begin
Select *
From CaLamViec
Where MaCaLamViec = @MaCaLamViec
end
go

Create proc spInsertCaLamViec
@MaCaLamViec varchar(5),
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

@SDMucTangCaHienTai bit,
@MucTangCaHienTai int,
@SDMucTangCaCuoiTuan bit,
@MucTangCaCuoiTuan int,
@SDMucTangCaNgayLe bit,
@MucTangCaNgayLe int,
@SDTangCaTruocGLV bit,
@TangCaTruocGLV int,
@SDTangCaSauGLV bit,
@TangCaSauGLV int,
@SDTongGLVTinhTangCa bit,
@TongGLVTinhTangCa int,

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
insert into CaLamViec(
MaCaLamViec,
TenCaLamViec, 
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

SDMucTangCaHienTai,
MucTangCaHienTai,
SDMucTangCaCuoiTuan,
MucTangCaCuoiTuan,
SDMucTangCaNgayLe,
MucTangCaNgayLe,
SDTangCaTruocGLV,
TangCaTruocGLV,
SDTangCaSauGLV,
TangCaSauGLV,
SDTongGLVTinhTangCa,
TongGLVTinhTangCa,

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
values (
@MaCaLamViec,
@TenCaLamViec, 
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

@SDMucTangCaHienTai,
@MucTangCaHienTai,
@SDMucTangCaCuoiTuan,
@MucTangCaCuoiTuan,
@SDMucTangCaNgayLe,
@MucTangCaNgayLe,
@SDTangCaTruocGLV,
@TangCaTruocGLV,
@SDTangCaSauGLV,
@TangCaSauGLV,
@SDTongGLVTinhTangCa,
@TongGLVTinhTangCa,

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
@MaCaLamViec varchar(5)
as
begin
delete from CaLamViec
where MaCaLamViec = @MaCaLamViec;
end
go

Create proc spUpdateCaLamViec
@MaCaLamViecChon varchar(5),
@MaCaLamViec varchar(5),
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

@SDMucTangCaHienTai bit,
@MucTangCaHienTai int,
@SDMucTangCaCuoiTuan bit,
@MucTangCaCuoiTuan int,
@SDMucTangCaNgayLe bit,
@MucTangCaNgayLe int,
@SDTangCaTruocGLV bit,
@TangCaTruocGLV int,
@SDTangCaSauGLV bit,
@TangCaSauGLV int,
@SDTongGLVTinhTangCa bit,
@TongGLVTinhTangCa int,


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
MaCaLamViec = @MaCaLamViec,
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


SDMucTangCaHienTai = @SDMucTangCaHienTai,
MucTangCaHienTai = @MucTangCaHienTai,
SDMucTangCaCuoiTuan = @SDMucTangCaCuoiTuan,
MucTangCaCuoiTuan = @MucTangCaCuoiTuan,
SDMucTangCaNgayLe = @SDMucTangCaNgayLe,
MucTangCaNgayLe = @MucTangCaNgayLe,
SDTangCaTruocGLV = @SDTangCaTruocGLV,
TangCaTruocGLV = @TangCaTruocGLV,
SDTangCaSauGLV = @SDTangCaSauGLV,
TangCaSauGLV = @TangCaSauGLV,
SDTongGLVTinhTangCa = @SDTongGLVTinhTangCa,
TongGLVTinhTangCa = @TongGLVTinhTangCa,



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
where MaCaLamViec = @MaCaLamViecChon;
end
go

