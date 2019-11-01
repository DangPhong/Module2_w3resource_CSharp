CREATE DATABASE BookManagement 
USE BookManagement
GO	
---Table Book---

CREATE TABLE Books 
(
	ID INT IDENTITY PRIMARY KEY,
	Avatar NVARCHAR(200),
	Name NVARCHAR(200) NOT NULL,
	Author NVARCHAR(50) NOT NULL, 
	Description NVARCHAR(200) NOT NULL,
	Year INT NOT NULL,
	Number INT NOT NULL,
	CateloryID INT NOT NULL,
	IsDelete BIT DEFAULT 0 NOT NULL,
	FOREIGN KEY (CateloryID) REFERENCES	[dbo].[Catelories] (ID)
)
--- Table Catelories ---
GO
CREATE TABLE Catelories
(
	ID INT IDENTITY	PRIMARY KEY,
	CateloryName NVARCHAR(50)
)
--- insert value into Catelory table ---
GO	
INSERT  dbo.Catelories
        (  CateloryName )
VALUES  ( 
          N'Horror '  -- CateloryName - nvarchar(50)
         )
--- insert value into Books table ---
INSERT	dbo.Books
        ( 
          Avatar ,
          Name ,
          Author ,
          Description ,
          Year ,
          Number ,
          CateloryID ,
          IsDelete
        )
VALUES  (
          N'....' , -- Avatar - nvarchar(200)
          N'DC' , -- Name - nvarchar(200)
          N'Malcolm' , -- Author - nvarchar(50)
          N'abc' , -- Description - nvarchar(200)
          1934 , -- Year - int
          10 , -- Number - int
          1 , -- CateloryID - int
          0  -- IsDelete - bit
        )
