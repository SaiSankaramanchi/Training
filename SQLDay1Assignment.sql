Use AdventureWorks2019
Go

--1. Question 1

Select ProductID, Name, Color, ListPrice
From Production.Product

--2. Question 2

Select ProductID, Name, Color, ListPrice
From Production.Product
Where ListPrice != 0

--3. Question 3

Select ProductID, Name, Color, ListPrice
From Production.Product
Where Color IS NULL

--4. Question 4

Select ProductID, Name, Color, ListPrice
From Production.Product
Where Color IS NOT NULL

--5. Question 5

Select ProductID, Name, Color, ListPrice
From Production.Product
Where Color IS NOT NULL and ListPrice > 0

--6. Question 6

SELECT Name + ' ' + Color AS [Name & Color]
FROM Production.Product
Where Color IS NOT NULL

--7. Question 7

SELECT 'NAME: ' + Name + ' -- COLOR: ' + Color AS [Name & Color] 
FROM Production.Product
Where Name in ('LL Crankarm', 'ML Crankarm', 'HL Crankarm', 'Chainring Bolts', 'Chainring Nut', 'Chainring')

--8. Question 8

Select ProductID, Name
From Production.Product
Where ProductID between 400 and 500

--9. Question 9

Select ProductID, Name, Color
From Production.Product
Where Color in ('Black', 'Blue')

--10. Question 10

Select * 
From Production.Product
Where Name like 'S%'

--11. Question 11

Select Name, ListPrice
From Production.Product
Where Name like 'S%'
ORDER BY Name 
--12. Question 12

Select Name, ListPrice
From Production.Product
Where Name like 'A%' or Name like 'S%'
ORDER BY Name 

--13. Question 13

Select *
From Production.Product
Where Name like 'SPO%'and Name not like 'SPOK%'

--14. Question 14

Select distinct Color 
From Production.Product
order by Color desc

--15. Question 15

Select distinct ProductSubcategoryID, Color   
From Production.Product
Where ProductSubcategoryID IS NOT NULL and Color IS NOT NULL

