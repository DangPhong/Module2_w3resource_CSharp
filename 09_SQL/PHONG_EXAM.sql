﻿-- CÂU 3: THIẾT KẾ VIEW BAO GỒM THÔNG TIN CHI TIẾT TÂT CÁC CÁC CHỨNG TỪ TRONG CSDL
CREATE VIEW view_CHUNGTU2 
AS 
SELECT  CTCT.MACHUNGTU, CTCT.NGAYLAPCHUNGTU, CTCT.MAKHACHHANG, CT.MAHANG, CT.SOLUONG 
FROM dbo.CHUNGTU CTCT JOIN dbo.CHUNGTU_MATHANG CT
ON 
CTCT.MACHUNGTU = CT.MACHUNGTU 
GROUP BY 
CTCT.MACHUNGTU, CTCT.NGAYLAPCHUNGTU, CTCT.MAKHACHHANG, CTCT.MACHUNGTU, CT.MAHANG, CT.SOLUONG 
GO 
SELECT * FROM VIEW_CHUNGTU2


-- CÂU 4: THỦ TỤC HIỆN THÔNG TIN CHI TIẾT TẤT CẢ MẶT HÀNG
create PROC SP_MATHANG2
AS 
BEGIN
 SELECT * FROM dbo.MATHANG
 END 
 GO 
 EXEC SP_MATHANG2
 --cau5
 CREATE PROC sp_Chitiet
 AS
 BEGIN
 IF
 EXISTS(SELECT 1 FROM dbo.CHUNGTU)
 BEGIN
SELECT  CTCT.MACHUNGTU, CTCT.NGAYLAPCHUNGTU, CTCT.MAKHACHHANG, CT.MAHANG, CT.SOLUONG 
FROM dbo.CHUNGTU CTCT JOIN dbo.CHUNGTU_MATHANG CT
ON 
CTCT.MACHUNGTU = CT.MACHUNGTU 
GROUP BY 
CTCT.MACHUNGTU, CTCT.NGAYLAPCHUNGTU, CTCT.MAKHACHHANG, CTCT.MACHUNGTU, CT.MAHANG, CT.SOLUONG 
END
ELSE 
BEGIN
RETURN 0
END

 END
 EXEC sp_Chitiet
 

