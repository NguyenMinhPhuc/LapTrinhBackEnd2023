CREATE DATABASE Data_DemoWeb;
GO
USE Data_DemoWeb;
GO
CREATE TABLE Product
(
    ID INT IDENTITY(1, 1) PRIMARY KEY,
    ProName NVARCHAR(50) NOT NULL,
    Color NVARCHAR(50),
    Price INT
);
GO
--them dữ liệu demo
INSERT INTO Product
(
    ProName,
    Color,
    Price
)
VALUES
(N'Tai nghe khong day', 'pink', 500000),
(N'Máy tính Asus', 'Silver', 24000000),
(N'Điện thoại Iphone 14 Pro', 'White', 34000000),
(N'Xe máy Lead', 'Red', 55000000);

GO
--Tạo thủ tục lấy danh sách sản phẩm
CREATE PROC PSP_Product_Select
AS
SELECT [ID],
       [ProName],
       [Color],
       [Price]
FROM dbo.Product;

GO
--Thủ tục lấy sản phẩm theo ID
CREATE PROC PSP_Product_SelectByID @ID INT
AS
SELECT [ID],
       [ProName],
       [Color],
       [Price]
FROM dbo.Product
WHERE ID = @ID;

GO
EXEC dbo.PSP_Product_SelectByID @ID = 1; -- int
