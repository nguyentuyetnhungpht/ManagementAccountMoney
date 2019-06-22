USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='dbQLSTK')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'dbQLSTK') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [dbQLSTK]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [dbQLSTK]
GO
USE [dbQLSTK]
GO

CREATE TABLE [dbo].[tblThamSo](
	[MaTS] [varchar](50) NOT NULL,
	[SoTienGuiToiThieuPG] [money] NOT NULL,
	[SoTienGuiToiThieuSTK] [money] NOT NULL,
	[SoNgayGuiToiThieu] [int] NOT NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [varchar](50) NOT NULL,
	[HoTenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[CMND] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblLoaiTietKiem](
	[MaLTK] [nvarchar](50) NOT NULL,
	[TenLTK] [nvarchar](50) NOT NULL,
	[LaiSuat] [float] NOT NULL,
	[KyHan] [int] NOT NULL,
 CONSTRAINT [PK_tblLoaiTietKiem] PRIMARY KEY CLUSTERED 
(
	[MaLTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblLoaiTietKiem]  WITH CHECK ADD  CONSTRAINT [FK_tblLoaiTietKiem_tblLoaiTietKiem] FOREIGN KEY([MaLTK])
REFERENCES [dbo].[tblLoaiTietKiem] ([MaLTK])
GO

ALTER TABLE [dbo].[tblLoaiTietKiem] CHECK CONSTRAINT [FK_tblLoaiTietKiem_tblLoaiTietKiem]
GO

CREATE TABLE [dbo].[tblSoTietKiem](
	[MaSoSTK] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[SoTienGoiSTK] [money] NOT NULL,
	[MaLTK] [nvarchar](50) NOT NULL,
	[NgayMoSo] [datetime2](7) NOT NULL,
	[TienLai] [money] NOT NULL,
	[SoLanDaoHan] [int] NOT NULL,
	[SoDu] [money] NOT NULL,
	[LaiSuatCamKet] [float] NOT NULL,
	[KyHanCamKet] [int] NOT NULL,
 CONSTRAINT [PK_tblSoTietKiem] PRIMARY KEY CLUSTERED 
(
	[MaSoSTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tblPhieuGuiTien](
	[MaSoPGT] [nvarchar](50) NOT NULL,
	[NgayGoi] [datetime2](7) NOT NULL,
	[SoTienGoiPGT] [money] NOT NULL,
	[MaSoSTK] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblPhieuGuiTien] PRIMARY KEY CLUSTERED 
(
	[MaSoPGT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblPhieuGuiTien]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuGuiTien_tblPhieuGuiTien] FOREIGN KEY([MaSoPGT])
REFERENCES [dbo].[tblPhieuGuiTien] ([MaSoPGT])
GO

ALTER TABLE [dbo].[tblPhieuGuiTien] CHECK CONSTRAINT [FK_tblPhieuGuiTien_tblPhieuGuiTien]
GO
CREATE TABLE [dbo].[tblPhieuRutTien](
	[MaSoPRT] [nvarchar](50) NOT NULL,
	[NgayRut] [datetime2](7) NOT NULL,
	[SoTienRut] [money] NOT NULL,
	[MaSoSTK] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblPhieuRutTien] PRIMARY KEY CLUSTERED 
(
	[MaSoPRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tblBaoCaoDoanhSoNgay](
	[MaBCDSN] [varchar](50) NOT NULL,
	[NgayBCDS] [datetime2](7) NOT NULL,
	[TongThu] [money] NOT NULL,
	[TongChi] [money] NOT NULL,
	[ChenhLechTien] [money] NOT NULL,
	[MaLTK] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblBaoCaoDoanhSoNgay] PRIMARY KEY CLUSTERED 
(
	[NgayBCDS] ASC,
	[MaLTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tblBaoCaoMoDongSoThang](
	[MaBCMDST] [nvarchar](50) NULL,
	[ThangBCMDST] [int] NOT NULL,
	[NamBCMDST] [int] NOT NULL,
	[NgayBCMDST] [datetime2](7) NOT NULL,
	[SoMo] [int] NOT NULL,
	[SoDong] [int] NOT NULL,
	[ChenhLechSo] [int] NOT NULL,
 CONSTRAINT [PK_tblBaoCaoMoDongSoThang2] PRIMARY KEY CLUSTERED 
(
	[NgayBCMDST] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [dbQLSTK]
GO
