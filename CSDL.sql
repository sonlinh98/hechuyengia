--Ban Chuan
USE master
GO
IF EXISTS (SELECT name 
	FROM sysdatabases 
	WHERE  name = 'TUVANMAYTINH')
BEGIN 
	PRINT 'db exists'
	DROP DATABASE TUVANMAYTINH 
	PRINT 'dropped db'
END
GO 
--Tao moi db
CREATE DATABASE TUVANMAYTINH 
PRINT 'create new db successfully'
GO
--====================================================================================
--TẠO BẢNG
USE TUVANMAYTINH
GO
CREATE TABLE DuLieu(
	Stt INT IDENTITY PRIMARY KEY,
	Age NVARCHAR(20),
	Sex NVARCHAR(20),
	Income NVARCHAR(20),
	Configuration NVARCHAR(20),
	Manufacturers NVARCHAR(20),
	Os NVARCHAR(20),
	Buy NVARCHAR(20))
GO
--====================================================================================
--CHÈN DL
USE TUVANMAYTINH
GO
INSERT INTO DuLieu VALUES('youth','male','high','high','SONY','Windows', 'Yes')
INSERT INTO DuLieu VALUES('senior','male','low','low','DELL','Windows', 'Yes')
INSERT INTO DuLieu VALUES('senior','female','high','high','APPLE','Mac OS', 'Yes')
INSERT INTO DuLieu VALUES('youth','male','high','medium','DELL','Linux', 'No')
INSERT INTO DuLieu VALUES('middle-aged','male','medium','high','APPLE','Mac OS', 'Yes')
INSERT INTO DuLieu VALUES('youth','female','high','high','DELL','Windows', 'No')
INSERT INTO DuLieu VALUES('senior','male','low','medium','SAMSUNG','Linux', 'Yes')
INSERT INTO DuLieu VALUES('youth','male','low','low','HP','Linux', 'Yes')
INSERT INTO DuLieu VALUES('middle-aged','female','low','high','APPLE','Mac OS', 'No')
INSERT INTO DuLieu VALUES('middle-aged','male','medium','medium','APPLE','Mac OS', 'Yes')
INSERT INTO DuLieu VALUES('youth','female','medium','high','ASUS','Windows', 'No')
INSERT INTO DuLieu VALUES('youth','male','high','low','ASUS','Windows', 'Yes')
INSERT INTO DuLieu VALUES('senior','male','medium','medium','HP','Windows', 'Yes')
INSERT INTO DuLieu VALUES('youth','female','low','high','DELL','Windows', 'No')
INSERT INTO DuLieu VALUES('middle-aged','male','low','medium','APPLE','Mac OS', 'No')
INSERT INTO DuLieu VALUES('senior','male','medium','low','DELL','Windows', 'Yes')
INSERT INTO DuLieu VALUES('senior','female','low','medium','SONY','Windows', 'No')
INSERT INTO DuLieu VALUES('middle-aged','male','high','low','HP','Linux', 'No')
INSERT INTO DuLieu VALUES('youth','male','medium','high','HP','Linux', 'No')
INSERT INTO DuLieu VALUES('senior','female','medium','low','APPLE','Mac OS', 'Yes')
INSERT INTO DuLieu VALUES('senior','female','low','medium','APPLE','Mac OS', 'No')
INSERT INTO DuLieu VALUES('youth','female','medium','medium','ASUS','Windows', 'Yes')
INSERT INTO DuLieu VALUES('middle-aged','male','low','high','SAMSUNG','Windows', 'No')
INSERT INTO DuLieu VALUES('youth','female','high','medium','DELL','Windows', 'Yes')
INSERT INTO DuLieu VALUES('youth','male','low','high','ASUS','Linux', 'No')


INSERT INTO DuLieu VALUES('middle-aged','female','medium','medium','APPLE','Mac OS', 'No')
INSERT INTO DuLieu VALUES('senior','male','high','medium','SONY','Windows', 'Yes')
INSERT INTO DuLieu VALUES('senior','male','medium','high','APPLE','Mac OS', 'Yes')
INSERT INTO DuLieu VALUES('middle-aged','female','high','medium','APPLE','Mac OS', 'No')
INSERT INTO DuLieu VALUES('youth','male','medium','medium','APPLE','Mac OS', 'Yes')

INSERT INTO DuLieu VALUES('senior','female','low','high','ASUS','Linux', 'Yes')
INSERT INTO DuLieu VALUES('middle-aged','male','low','low','APPLE','Mac OS', 'No')
INSERT INTO DuLieu VALUES('senior','male','high','high','ASUS','Windows', 'Yes')
INSERT INTO DuLieu VALUES('senior','female','high','low','DELL','Windows','Yes')
INSERT INTO DuLieu VALUES('middle-aged','female','medium','low','SONY','Windows','Yes')
INSERT INTO DuLieu VALUES('youth','male','medium','low','HP','Linux','Yes')
INSERT INTO DuLieu VALUES('middle-aged','male','high','low','ASUS','Linux','No')
INSERT INTO DuLieu VALUES('senior','female','medium','high','ASUS','Windows','No')
INSERT INTO DuLieu VALUES('youth','female','low','medium','HP','Windows','Yes')
INSERT INTO DuLieu VALUES('middle-aged','female','medium','high','APPLE','Mac OS','Yes')

INSERT INTO DuLieu VALUES('senior','male','medium','high','SONY','Mac OS','No')
INSERT INTO DuLieu VALUES('youth','male','low','medium','SAMSUNG','Linux','Yes')
INSERT INTO DuLieu VALUES('middle-aged','female','high','high','DELL','Windows','Yes')
INSERT INTO DuLieu VALUES('youth','female','medium','low','HP','Linux','No')
INSERT INTO DuLieu VALUES('middle-aged','male','high','medium','DELL','Windows','Yes')
INSERT INTO DuLieu VALUES('middle-aged','male','medium','low','HP','Windows','Yes')
INSERT INTO DuLieu VALUES('senior','female','high','medium','HP','Windows','No')



GO
SELECT * FROM DuLieu
--====================================================================================

--TẠO BẢNG LUẬT
USE TUVANMAYTINH
GO
CREATE TABLE Luat(
	Stt INT IDENTITY PRIMARY KEY,
	Age NVARCHAR(20),
	Sex NVARCHAR(20),
	Income NVARCHAR(20),
	Configuration NVARCHAR(20),
	Manufacturers NVARCHAR(20),
	Os NVARCHAR(20),
	Buy NVARCHAR(20))
GO

Select * from LUAT