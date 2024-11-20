CREATE DATABASE MobileShop

go 

use MobileShop

GO

-- Tạo bảng Sản phẩm
CREATE TABLE SanPham (
    id INT PRIMARY KEY IDENTITY(1,1), 
    tenSP NVARCHAR(255) NOT NULL,   
    gia DECIMAL(18, 2) NOT NULL,     
    hangSX NVARCHAR(255) NOT NULL    
);

go

CREATE TABLE KhachHang (
    id INT PRIMARY KEY IDENTITY(1,1),
    tenKH NVARCHAR(255) NOT NULL,     
    diachi NVARCHAR(255),         
    sdt NVARCHAR(20)              
);

go

-- Tạo bảng Đơn hàng
CREATE TABLE DonHang (
    id INT PRIMARY KEY IDENTITY(1,1),    
    khachhangid INT NOT NULL,            
    sanphamid INT NOT NULL,             
    soluong INT NOT NULL,                
    ngaymua DATE NOT NULL,             
    FOREIGN KEY (khachhangid) REFERENCES KhachHang(id),
    FOREIGN KEY (sanphamid) REFERENCES SanPham(id)     
);

go

CREATE TABLE NguoiDung (
    id INT PRIMARY KEY IDENTITY(1,1),
    tendangnhap NVARCHAR(50) NOT NULL UNIQUE, 
    matkhau NVARCHAR(255) NOT NULL        
);

go

INSERT INTO NguoiDung (tendangnhap, matkhau) VALUES 
('admin', '123456'), -- Người dùng quản trị
('user1', 'password1'), -- Người dùng thường
('user2', 'password2'); -- Người dùng thường

go

INSERT INTO SanPham (tenSP, gia, hangSX) VALUES
('iPhone 14', 25000000, 'Apple'),
('Samsung Galaxy S23', 22000000, 'Samsung'),
('Xiaomi Mi 13', 15000000, 'Xiaomi'),
('MacBook Pro', 50000000, 'Apple'),
('Dell XPS 13', 40000000, 'Dell');

go

INSERT INTO KhachHang (tenKH, diachi, sdt) VALUES
('Nguyen Van A', '123 Le Loi, TP.HCM', '0912345678'),
('Tran Thi B', '456 Hai Ba Trung, Ha Noi', '0987654321'),
('Le Van C', '789 Nguyen Trai, Da Nang', '0933333333'),
('Hoang Thi D', '111 Tran Phu, Can Tho', '0909090909');

go

INSERT INTO DonHang (khachhangid, sanphamid, soluong, ngaymua) VALUES
(1, 1, 1, '2024-11-01'), -- Nguyễn Văn A mua 1 iPhone 14
(2, 2, 2, '2024-11-05'), -- Trần Thị B mua 2 Samsung Galaxy S23
(3, 3, 1, '2024-11-10'), -- Lê Văn C mua 1 Xiaomi Mi 13
(4, 4, 1, '2024-11-15'), -- Hoàng Thị D mua 1 MacBook Pro
(1, 5, 1, '2024-11-18'); -- Nguyễn Văn A mua 1 Dell XPS 13
