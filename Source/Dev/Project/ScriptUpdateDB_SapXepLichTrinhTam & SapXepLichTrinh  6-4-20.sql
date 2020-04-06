use ATINChamCong
go

begin
Delete
from SapXepLichTrinh;
ALTER TABLE SapXepLichTrinh
DROP Column MaChamCong, MaLichTrinhTam;
end 
go

begin
ALTER TABLE SapXepLichTrinhTam
add MaNguoi int NOT NULL;
end 
go

begin
Alter Table SapXepLichTrinhTam
ADD CONSTRAINT FK_SapXepLichTrinhTam_Nguoi
FOREIGN KEY (MaNguoi) REFERENCES Nguoi(MaNguoi);
end
go
