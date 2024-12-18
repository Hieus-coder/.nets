create database BanHang
go
USE BanHang
GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 11/6/2024 8:11:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MaHoaDon] [nchar](10) NOT NULL,
	[MaSP] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TongTien] [money] NOT NULL,
	[NgayDatHang] [date] NOT NULL,
	[NgayGiaoHang] [date] NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/6/2024 8:11:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[DienThoai] [nchar](10) NOT NULL,
	[Email] [nchar](10) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 11/6/2024 8:11:03 AM ******/

DROP TABLE IF EXISTS LoaiSanPham;
GO

CREATE TABLE LoaiSanPham(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	MaLoaiSP nchar(10) NOT NULL UNIQUE,
	tenSP NVARCHAR(60),
	motaSP NVARCHAR(100),
	gia FLOAT,
	sl INT
);
GO

/****** Object:  Table [dbo].[NguoiDung]    Script Date: 11/6/2024 8:11:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [nchar](10) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_NguoiDung] UNIQUE NONCLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/6/2024 8:11:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](10) NOT NULL,
	[Ten] [nvarchar](max) NOT NULL,
	[DonGia] [money] NOT NULL,
	[HinhAnh] [text] NOT NULL,
	[MoTaNgan] [nvarchar](max) NOT NULL,
	[MoTaChiTiet] [text] NOT NULL,
	[MaLoaiSP] [nchar](10) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_KhachHang]
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_SanPham]
GO

GO

ALTER TABLE SanPham
ADD CONSTRAINT FK_SanPham_LoaiSanPham FOREIGN KEY (MaLoaiSP) REFERENCES LoaiSanPham(MaLoaiSP);
GO


INSERT INTO LoaiSanPham (MaLoaiSP, tenSP, motaSP, gia, sl)
VALUES 
(N'LSP001', N'Gà', N'Gà ai cập', 150000, 100),
(N'LSP002', N'Vịt', N'Vịt cỏ', 350000, 50),
(N'LSP003', N'Lợn', N'Lợn rừng', 700000, 30);

INSERT INTO SanPham (MaSP, Ten, DonGia, HinhAnh, MoTaNgan, MoTaChiTiet, MaLoaiSP)
VALUES 
(N'SP001', N'Tru Ga', 150000, N'hinhga.jpg', N'Ga ai cap ngon', N'Chi tiet ve ga ai cap', N'LSP001'),
(N'SP002', N'Tru Vit', 350000, N'hinhvit.jpg', N'Vit co ngon', N'Chi tiet ve vit co', N'LSP002');
