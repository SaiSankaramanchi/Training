Use Northwind
Go

--1. Question 1

SELECT City
FROM Customers
Intersect
SELECT City
FROM Employees


--2. Question 2

SELECT sub.City
  FROM (
        SELECT City
          FROM Customers
         Except
        SELECT City
          FROM Employees
       ) sub


SELECT City
FROM Customers
Except
SELECT City
FROM Employees

--3. Question 3

Select ProductName, QuantityPerUnit ,SUM(UnitsInStock + UnitsOnOrder) as TotalQuantityOfStocks
From Products
Group by ProductName, QuantityPerUnit

--4. Question 4

Select City as CustomerCity, ProductName, UnitsOnOrder as TotalOrders
From Customers c join Orders o on c.CustomerID=o.CustomerID join [Order Details] od on o.OrderID=od.OrderID join Products p on od.ProductID=p.ProductID
Group by City, ProductName, UnitsOnOrder

--5. Question 5

Select City
From Customers
Group by City
Having COUNT(CustomerID)>2
Union 
Select City
From Customers
Group by City
Having COUNT(CustomerID)>2

Select sub.City
From (Select City
		From Customers
		Group by City
		Having COUNT(CustomerID)>2)
		sub

--6. Question 6

Select sub.City
From (Select City
		From Customers c join Orders o on o.CustomerID=c.CustomerID join [Order Details] od on od.OrderID=o.OrderID join Products p on od.ProductID=p.ProductID
		Group by City
		Having COUNT(p.ProductID)>2)
		sub
Order by City

--7. Question 7
-- With Sub Query
Select sub.ContactName, sub.City, sub.ShipCity
From (Select ContactName, City, ShipCity
		From Customers c join Orders o on o.CustomerID=c.CustomerID 
		Where c.City != o.ShipCity
		Group by ContactName, City, ShipCity)
		sub
-- Whithout Sub Queary
Select ContactName, City, ShipCity
		From Customers c join Orders o on o.CustomerID=c.CustomerID 
		Where c.City != o.ShipCity
		Group by ContactName, City, ShipCity
		
--8. Question 8
Select Top 5 sub.ProductName,sub.AvgPrice as AvgPrice,sub.City  
From(
 SELECT p.ProductName,avg(od.UnitPrice) as AvgPrice, c.City, COUNT(o.OrderID) AS NumOfOrders, RANK() OVER(ORDER BY COUNT(o.OrderID) DESC) AS RNK
From Products p join [Order Details] od on od.ProductID=p.ProductID join Orders o on o.OrderID=od.OrderID join Customers c on c.CustomerID=o.CustomerID
Group by p.ProductName, c.City,Quantity, p.ProductID)sub
Where RNK <= 5

--9. Question 9
--Without Sub Query
Select  c.City
From Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID
Where od.Quantity = 0 and o.EmployeeID IS NOT NULL

--With Sub Query

Select sub.City
From (Select c.City From Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID
		Where od.Quantity = 0 and o.EmployeeID IS NOT NULL)
		sub

--10. Question 10
SELECT top 1 y.City, y.NumOfOrders
From(
	SELECT  c.City, COUNT(o.OrderID) AS NumOfOrders, RANK() OVER(ORDER BY COUNT(o.OrderID) DESC) AS RNK
	From Products p join [Order Details] od on od.ProductID=p.ProductID join Orders o on o.OrderID=od.OrderID join Customers c on c.CustomerID=o.CustomerID
	Group by p.ProductName, c.City,Quantity, p.ProductID
	) as x
	join
	(SELECT  c.City, COUNT(o.OrderID) AS NumOfOrders, RANK() OVER(ORDER BY COUNT(o.OrderID) DESC) AS RNK
	From Products p join [Order Details] od on od.ProductID=p.ProductID join Orders o on o.OrderID=od.OrderID join Customers c on c.CustomerID=o.CustomerID
	Group by p.ProductName, c.City,Quantity, p.ProductID
	) as y on x.NumOfOrders=y.NumOfOrders

--11. Question 11
-- It can be done by using CTE (Common Table Expression) which eleiminates the reduntant data from the resultant table by removing the duplicates. An example of CTE is as follows as learned in the morning session of day 3.

SELECT c.ContactName, c.City, dt.TotalNum
FROM Customers c LEFT JOIN (
SELECT CustomerID, COUNT(OrderID) TotalNum FROM Orders 
GROUP BY CustomerID
) dt ON c.CustomerID = dt.CustomerID;

WITH OrderCountCTE
AS(
SELECT CustomerID, COUNT(OrderID) TotalNum FROM Orders 
GROUP BY CustomerID
)
SELECT c.ContactName, c.City, cte.TotalNum
FROM Customers c LEFT JOIN OrderCountCTE cte ON c.CustomerID = CTE.CustomerID

