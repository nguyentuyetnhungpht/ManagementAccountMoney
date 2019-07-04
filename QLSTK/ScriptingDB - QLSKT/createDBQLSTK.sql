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
	[MaTS] [int] NOT NULL,
	[SoTienGuiToiThieuPG] [money] NOT NULL,
	[SoTienGuiToiThieuSTK] [money] NOT NULL,
	[SoNgayGuiToiThieu] [int] NOT NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [int] NOT NULL PRIMARY KEY,
	[HoTenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[CMND] [varchar](50) NOT NULL
) 

CREATE TABLE [dbo].[tblLoaiTietKiem](
	[MaLTK] [int] NOT NULL PRIMARY KEY,
	[TenLTK] [nvarchar](50) NOT NULL,
	[LaiSuat] [float] NOT NULL,
	[KyHan] [int] NOT NULL,
)
CREATE TABLE [dbo].[tblSoTietKiem](
	[MaSoSTK] [int] NOT NULL PRIMARY KEY,
	[MaKH] [int] NOT NULL FOREIGN KEY REFERENCES tblKhachHang(MAKH),
	[SoTienGoiSTK] [money] NOT NULL,
	[MaLTK] [int] NOT NULL FOREIGN KEY REFERENCES tblLoaiTietKiem(MaLTK) ,
	[NgayMoSo] [datetime2](7) NOT NULL,
	[TienLai] [money] NOT NULL,
	[SoLanDaoHan] [int] NOT NULL,
	[SoDu] [money] NOT NULL,
	[LaiSuatCamKet] [float] NOT NULL,
	[KyHanCamKet] [int] NOT NULL,
	[NgayChinhSua] [datetime2](7) NOT NULL
)

CREATE TABLE [dbo].[tblPhieuGuiTien](
	[MaSoPGT] [int] NOT NULL PRIMARY KEY,
	[NgayGoi] [datetime2](7) NOT NULL,
	[SoTienGoiPGT] [money] NOT NULL,
	[MaSoSTK] [int] NOT NULL FOREIGN KEY REFERENCES tblSoTietKiem(MaSoSTK),
)

CREATE TABLE [dbo].[tblPhieuRutTien](
	[MaSoPRT] [int] NOT NULL PRIMARY KEY,
	[NgayRut] [datetime2](7) NOT NULL,
	[SoTienRut] [money] NOT NULL,
	[MaSoSTK] [int] NOT NULL FOREIGN KEY REFERENCES tblSoTietKiem(MaSoSTK),
)

CREATE TABLE [dbo].[tblBaoCaoDoanhSoNgay](
	[MaBCDSN] [int] NOT NULL PRIMARY KEY,
	[NgayBCDS] [datetime2](7) NOT NULL,
	[TongThu] [money] NOT NULL,
	[TongChi] [money] NOT NULL,
	[ChenhLechTien] [money] NOT NULL,
	[MaLTK] [int] NOT NULL FOREIGN KEY REFERENCES tblLoaiTietKiem(MaLTK)
)
CREATE TABLE [dbo].[tblBaoCaoMoDongSoThang](
	[MaBCMDST] [int] NOT NULL PRIMARY KEY,
	[ThangBCMDST] [int] NOT NULL,
	[NamBCMDST] [int] NOT NULL,
	[NgayBCMDST] [datetime2](7) NOT NULL,
	[SoMo] [int] NOT NULL,
	[SoDong] [int] NOT NULL,
	[ChenhLechSo] [int] NOT NULL,
	[MaLTK] [int] NOT NULL FOREIGN KEY REFERENCES tblLoaiTietKiem(MaLTK)
)
USE [dbQLSTK]
GO
