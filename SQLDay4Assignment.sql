Use Northwind
Go

--1. Question 1
CREATE VIEW view_product_order_Sankaramanchi 
   AS  
   SELECT ProductID, ProductName, UnitsOnOrder FROM Products;  
GO 

--2. Question 2
CREATE PROCEDURE sp_product_order_quantity_Sankaramanchi @ProductID int  
   AS  
   BEGIN  
      -- The print statement returns text to the user  
      PRINT 'Products having ID ' + CAST(@ProductID AS int);  
      -- A second statement starts here  
      SELECT UnitsOnOrder FROM view_product_order_Sankaramanchi    
   END  
GO 

--3. Question 3

CREATE PROCEDURE sp_product_order_city_Sankaramanchi @ProductName nvarchar  
   AS  
   BEGIN  
      -- The print statement returns text to the user  
      PRINT 'Products having ID ' + CAST(@ProductName as nvarchar(40));  
      -- A second statement starts here  
      SELECT TOP 5 City FROM Customers    
   END  
GO 

--6. Question 6
--An inner join to pick up the rows where the primary key exists in both tables, but there is a difference in the value of one or more of the other columns. This would pick up changed rows in original.
