Use AdventureWorks2019
Go

--1. Question 1

SELECT COUNT(ProductID) AS NumberOfProducts
FROM Production.Product

--2. Question 2

SELECT COUNT(ProductID) AS NumberOfProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL;

--3. Question 3

Select p.ProductSubcategoryID, count (p.ProductSubCategoryID) as CountedProducts
From Production.Product p
GROUP BY p.ProductSubcategoryID

--4. Question 4

SELECT COUNT(ProductID) AS NumberOfProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NULL;

--5. Question 5

SELECT SUM(Quantity) AS SumOfQuantity
FROM Production.ProductInventory 

--6. Question 6

Select ProductID, (Select TOP 40 sum (ProductID * LocationID)) as TheSum
From Production.ProductInventory  
GROUP BY ProductID, LocationID
HAVING sum(ProductID*LocationID) < 100 

--7. Question 7

Select Shelf, ProductID, (Select TOP 40 sum (ProductID * LocationID)) as TheSum
From Production.ProductInventory  
GROUP BY ProductID, Shelf, LocationID
HAVING sum(ProductID*LocationID) < 100 

--8. Question 8

Select AVG(Quantity) as AvgQuantity
From Production.ProductInventory
Where LocationID = 10

--9. Question 9

Select ProductID, Shelf, avg(Quantity) as TheAvg
From Production.ProductInventory
GROUP BY ProductID, Shelf

--10. Question 10

Select ProductID, Shelf, avg(Quantity) as TheAvg
From Production.ProductInventory
Where Shelf != 'N/A'
GROUP BY ProductID, Shelf

--11. Question 11

Select Color, Class, Count(ProductID) as TheCount, Avg(ListPrice) as AvgPrice
From Production.Product
Where Color IS NOT NULL and Class IS NOT NULL
Group by Color, Class

--12. Question 12

SELECT c.Name as Country, s.Name as Province
FROM Person.CountryRegion c LEFT JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
GROUP BY c.Name,s.Name

--13. Question 13

SELECT c.Name as Country, s.Name as Province
FROM Person.CountryRegion c LEFT JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
Where c.Name = 'Germany' or c.Name = 'Canada'
GROUP BY c.Name,s.Name

Use Northwind
Go

--14. Question 14

SELECT DISTINCT  Products.ProductName
FROM  [Products]  RIGHT JOIN    [Order Details] on Products.ProductID = [Order Details].ProductID Right join Orders on [Order Details].OrderID=Orders.OrderID
WHERE Orders.OrderDate Between '1/1/1997' and '1/1/2022' 

--15. Question 15

SELECT  Top 5 ShipPostalCode, UnitsOnOrder
FROM  [Products]  RIGHT JOIN    [Order Details] on Products.ProductID = [Order Details].ProductID Right join Orders on [Order Details].OrderID=Orders.OrderID
Where ShipPostalCode IS NOT NULL 
Group by ShipPostalCode, UnitsOnOrder

--16. Question 16

SELECT  Top 5 ShipPostalCode, UnitsOnOrder
FROM  [Products]  RIGHT JOIN    [Order Details] on Products.ProductID = [Order Details].ProductID Right join Orders on [Order Details].OrderID=Orders.OrderID
Where ShipPostalCode IS NOT NULL and Orders.OrderDate Between '1/1/1997' and '1/1/2022'
Group by ShipPostalCode, UnitsOnOrder

--17. Question 17

SELECT City, count(ContactName) as NumCustomers
FROM  [Products] p RIGHT JOIN    [Order Details] od on p.ProductID = od.ProductID Right join Orders o on od.OrderID=o.OrderID Right join Customers c on o.CustomerID=c.CustomerID
Group by City

--22. Question 22

SELECT c.CustomerID 
FROM  [Products] p RIGHT JOIN    [Order Details] od on p.ProductID = od.ProductID Right join Orders o on od.OrderID=o.OrderID Right join Customers c on o.CustomerID=c.CustomerID
Group by c.CustomerID
Having count(p.ProductID) >100

--24. Question 24

SELECT OrderDate, ProductName
FROM  [Products] p RIGHT JOIN    [Order Details] od on p.ProductID = od.ProductID Right join Orders o on od.OrderID=o.OrderID Right join Customers c on o.CustomerID=c.CustomerID
Group by OrderDate, ProductName



