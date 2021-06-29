use master
Drop Database quanlysach
----------
create database quanlysach
GO
use quanlysach
GO
CREATE TABLE SACH
(
	Id INT IDENTITY(1,1),
	Author NVARCHAR(100),
	Title NVARCHAR(100),
	Descriptio_n NVARCHAR(100),
	Price Decimal(18,0) CHECK (Price>=0),
	Images VARCHAR(50),
	CONSTRAINT PK_SACH PRIMARY KEY(Id)
)
GO



INSERT SACH(Author,Title,Descriptio_n,Price,Images) 
VALUES (N'Thien',N'Visual', N'Visual Basic 2005 Tập 1, Quyển 2: Lập Trình Web', 20000, 'LTWeb2005.jpg')
INSERT SACH(Author,Title,Descriptio_n,Price,Images) 
VALUES ( N'Thien',N'Visual', N'Visual Basic 2005 Tập 2, Quyển 2: Lập Trình Web', 20000, 'TH001.jpg')
INSERT SACH(Author,Title,Descriptio_n,Price,Images) 
VALUES ( N'Thien',N'Visual', N'Visual Basic 2005 Tập 3, Quyển 2: Lập Trình Web', 20000, 'Gt_Thcb.jpg')
INSERT SACH(Author,Title,Price,Descriptio_n,Images) 
VALUES ( N'Thien',N'Visual', N'Visual Basic 2005 Tập 4, Quyển 2: Lập Trình Web', 20000, 'KT0001.jpg')
INSERT SACH(Author,Title,Price,Descriptio_n,Images) 
VALUES ( N'Thien',N'Visual', N'Visual Basic 2005 Tập 5, Quyển 2: Lập Trình Web', 20000, 'KT0001.jpg')
