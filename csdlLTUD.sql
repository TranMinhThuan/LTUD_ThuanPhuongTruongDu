-- Tao database
create Database QuanLyHang
go
use QuanLyHang

-- Tao bang Hang Hoa
set dateformat dmy
create table HANGHOA(
	MaHang nvarchar(20) primary key not null,
	TenHang nvarchar(20),
	DonGia nvarchar(20),
	MaNhaCungCap nvarchar(20),
	NhayNhap datetime,
	NhayXuat datetime
)
-- Tao bang Nha Cung Cap
create table NHACUNGCAP(
	MaNhaCungCap nvarchar(20) primary key not null,
	TenNhaCungCap nvarchar(20),
	DiaChi nvarchar(20)
)
-- Tao bang Hoa Don
create table HOADON(
	MaHD nvarchar(20) primary key not null,
	TenHD nvarchar(20),
	MaHang nvarchar(20),
	SoLuong int,
	DonGia float,
	Thue float
)
-- Tao bang Thong Tin Nhan Vien
create table THONGTINNV(
	MaNV nvarchar(20) primary key not null,
	MatKhau nvarchar(20),
	TenNV nvarchar(20),
	Email nvarchar(20),
	DiaChi nvarchar(20),
	SoDT int
)

-- Them cac rang buoc
go
alter table HANGHOA
add constraint fk_HANGHOA_NHACUNGCAP foreign key (MaNhaCungCap) references NHACUNGCAP(MaNhaCungCap)
on delete cascade
go
alter table HOADON
add constraint fk_HOADON_HANGHOA foreign key (MaHang) references HANGHOA(MaHang)
on delete cascade




-- Tao chuc nang cho Dang nhap
go 
use QuanLyHang
-- lay danh sach bang nhan vien
go
create proc sp_LayDSNhanVien
as
select * from THONGTINNV
-- them danh sach vao bang nhan vien
go
create proc sp_themTK (@ma nvarchar(20), @mk nvarchar(20), @ten nvarchar (20),@email nvarchar (20),@diachi nvarchar (20),@sdt int)
as
insert into THONGTINNV(MaNV, MatKhau, TenNV,Email,DiaChi,SoDT) 
values (@ma,@mk,@ten,@email,@diachi,@sdt)
--Them nhan vien vo bang NHANVIEN
exec sp_themTK 'a1', '123','Thuan','thuana1@gmail.com','quan9','0123456789'
exec sp_themTK 'a2', '123','Phuong','phuonga2@gmail.com','quan ThuDuc','0263211123'
exec sp_themTK 'a3', '123','Du','dua3@gmail.com','quan9','0964586672'
exec sp_themTK 'a4', '123','Truong','truonga4@gmail.com','quan ThuDuc','0364442551'
-- lay danh sach
exec sp_LayDSNhanVien

go
use QuanLyHang
-- lay ds nha cung cap
go
create proc sp_LayDSNhaCungCap
as
select *from NHACUNGCAP
-- Them nha cung cap
go
create proc sp_themNCC (@macc nvarchar(20), @tencc nvarchar(20), @diachi nvarchar(20))
as
insert into NHACUNGCAP values (@macc, @tencc, @diachi)
-- Them nha cung cap vao bang NHACUNGCAP
exec sp_themNCC 'CC','Coca','quanThuDuc'
exec sp_themNCC 'PS','Pepsi','quan9'
exec sp_themNCC 'FT','Fanta','quan10'
exec sp_themNCC 'RB','Redbull','quan7'
-- lay danh sach
exec sp_LayDSNhaCungCap
--Xoa nha cung cap

go
create proc sp_XoaNCC (@macc nvarchar(20))
as
delete
from NHACUNGCAP
where MaNhaCungCap=@macc
exec sp_XoaNCC 'RB'

--Sua nha cung cap

go
create proc sp_SuaNCC(@macc nvarchar(20), @tencc nvarchar(20), @diachi nvarchar(20))
as
update NHACUNGCAP
set  MaNhaCungCap= @macc,  TenNhaCungCap= @tencc, DiaChi=  @diachi
where MaNhaCungCap = @macc

exec sp_SuaNCC 'CC','Cocacola', 'Tri thuy'

-- lay ds hoa don
go
use QuanLyHang
go
create proc sp_LayDSHoaDon
as
select *from HoaDon
--Them hoa don
go
create proc sp_themHD (@mahd nvarchar(20), @tenhd nvarchar(20), @mahang nvarchar(20),@soluong int,@dongia nvarchar(20),@thue float)
as
insert into HOADON 
values (@mahd,@tenhd,@mahang,@soluong,@dongia,@thue)
-- Them san Pham Vao hoa Don
exec sp_themHD 'H1','hoadon1','1','13','8000','0.1'
exec sp_themHD 'H2','hoadon2','2','24','9000','0.1'
exec sp_themHD 'H3','hoadon3','3','15','10000','0.1'
--lay danh san pham
exec sp_LayDSHoaDon

--Xoa hoa don

go
create proc sp_XoaHD (@mahd nvarchar(20))
as
delete
from HOADON
where MaHD=@mahd
exec sp_XoaHD 'H1'

--Sua hoa don
go
create proc sp_HD(@mahd nvarchar(20), @tenhd nvarchar(20), @mahang nvarchar(20),@soluong int,@dongia nvarchar(20),@thue float)
as
update HOADON
set MaHD= @mahd, TenHD = @tenhd, MaHang= @mahang, SoLuong= @soluong, DonGia= @dongia, Thue= @thue
where MaHD = @mahd

exec sp_HD 'H1','HD1', '1', '7', '5000','0.3'


-- lay ds hang hoa
go
use QuanLyHang
go
create proc sp_LayDSHangHoa
as
select *from HANGHOA
-- Them hang
go
use QuanLyHang
go
create proc sp_themHang (@ma nvarchar(20), @ten nvarchar(20), @dongia nvarchar(20), @nhacungcap nvarchar(20), @ngaynhap datetime, @ngayxuat datetime)
as
insert into HANGHOA values (@ma, @ten, @dongia, @nhacungcap, @ngaynhap, @ngayxuat)
exec sp_themHang '1','Banh','1000','CC','5/11/2018','10/11/2018'
exec sp_themHang '2','Keo','2000','PS','6/11/2018','11/11/2018'
exec sp_themHang '3','Quan','3000','FT','7/11/2018','12/11/2018'
exec sp_themHang '4','Ao','4000','RB','8/11/2018','12/11/2018'

exec sp_LayDSHangHoa
--Xoa hang hoa

go
create proc sp_XoaH (@mah nvarchar(20))
as
delete
from HANGHOA
where MaHang=@mah
exec sp_XoaH '5'
-- Sua hang
go
create proc sp_SuaHang(@ma nvarchar(20), @ten nvarchar(20), @dongia nvarchar(20), @nhacungcap nvarchar(20), @ngaynhap datetime, @ngayxuat datetime)
as
update HANGHOA
set  MaHang= @ma, TenHang= @ten, DonGia= @dongia, MaNhaCungCap= @nhacungcap, NhayNhap= @ngaynhap, NhayXuat=@ngayxuat
where MaHang = @ma

exec sp_SuaHang '1','Tu lanh','10000','CC','20/12/2018','22/12/2018'