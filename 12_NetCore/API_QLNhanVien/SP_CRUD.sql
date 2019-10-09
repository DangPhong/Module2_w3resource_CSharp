SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dang Phong
-- Create date: 2019/10/03
-- Description:	create new department
-- =============================================
CREATE PROCEDURE TaoPhongBan 
	@MaPhongBan NVARCHAR(5),
	@TenPhongBan NVARCHAR(50)
AS
BEGIN
	

INSERT INTO [dbo].[PhongBan]
           ([MaPhongBan]
           ,[TenPhongBan]
           ,[DaXoa])
     VALUES
           (@MaPhongBan
           ,@TenPhongBan
           ,0)
DECLARE @Id INT
SET @Id = SCOPE_IDENTITY()
SELECT @Id AS Id
END

-- =============================================
-- Author:		Dang Phong
-- Create date: 2019/10/03
-- Description:	update department
-- =============================================
CREATE PROCEDURE SuaPhongBan 
	@Id Int,
	@MaPhongBan NVARCHAR(5),
	@TenPhongBan NVARCHAR(50)
AS
BEGIN
UPDATE [dbo].[PhongBan]
   SET [MaPhongBan] = @MaPhongBan
      ,[TenPhongBan] = @TenPhongBan
 WHERE Id = @Id
SELECT @Id AS Id
END

-- =============================================
-- Author:		Dang Phong
-- Create date: 2019/10/03
-- Description:	delete department
-- =============================================
CREATE PROCEDURE XoaPhongBan 
	@Id Int
AS
BEGIN
UPDATE [dbo].[PhongBan]
   SET [DaXoa] = 1
 WHERE Id = @Id
SELECT @Id AS Id
END

-- =============================================
-- Author:		Dang Phong
-- Create date: 2019/10/03
-- Description:	get list of department
-- =============================================
CREATE PROCEDURE DanhSachPhongBan 
	
AS
BEGIN
SELECT [ID]
      ,[MaPhongBan]
      ,[TenPhongBan]
  FROM [dbo].[PhongBan]
WHERE DaXoa = 0
END

-- =============================================
-- Author:		Dang Phong
-- Create date: 2019/10/03
-- Description:	get  department by Id
-- =============================================
CREATE PROCEDURE LayPhongBanID 
	@Id Int
AS
BEGIN

IF (NOT EXISTS (SELECT * FROM [dbo].[PhongBan] WHERE DaXoa = 0 AND Id = @Id))
BEGIN
	RAISERROR ('Invalid Department',1,100)
	RETURN
END

SELECT [ID]
      ,[MaPhongBan]
      ,[TenPhongBan]
  FROM [dbo].[PhongBan]
WHERE Id=@Id
END