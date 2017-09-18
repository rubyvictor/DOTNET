select * from Customers

select CustomerID, isNull(FaxNumber, 'Not Avail') as FN from Customers

Update Customers set MemberCategory ='B' where CustomerID = '1000'