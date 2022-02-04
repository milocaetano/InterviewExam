SELECT
  (Firstname + ' ' + LastName) as 'full name',
  Age as age,
  o.OrderID as orderid,
  o.DateCreated as datecreated, 
  o.MethodofPurchase as 'Purchase Method',
  od.ProductNumber,
  od.ProductOrigin
FROM
  Customers person
  INNER JOIN Orders o on person.PersonID = o.PersonID
  INNER JOIN OrderDetails od on o.OrderID = od.OrderId
WHERE od.ProductId = 1112222333