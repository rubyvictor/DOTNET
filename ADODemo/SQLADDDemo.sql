select * from Customers

select CustomerID, isNull(FaxNumber, 'Not Avail') as FN from Customers

Update Customers set MemberCategory ='B' where CustomerID = '1000'

select RentalPrice from Movies where VideoCode='1'
select Rating, count(MovieTitle) from Movies group by Rating
select * from Movies
select * from IssueTran
select * from Producers

select * from Customers
--USE TRANSACTION BLOCK creation for multiple updates

Begin Tran
update Customers set memberCategory = 'Y' where CustomerID = '1000'
select * from Customers
update Customers set memberCategory = 'Y' where CustomerID = '1001'
select * from Customers
Commit


select p.producerName, m.MovieTitle
from Movies m, Producers p
where m.producerID = p.ProducerID
and m.producerID = 'Walt'

select * from ProducerWebSite

select c.CustomerID, c.CustomerName,c.CountryCode, cc.CountryName
from Customers c, Country cc
where c.CountryCode = cc.CountryCode
and c.CustomerID = '1000'

    