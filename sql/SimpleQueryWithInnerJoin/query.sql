SELECT
  (Firstname + ' ' + LastName) as Fullname,
  age,
  o.OrderID,
  od.ProductNumber,
  od.ProductOrigin
FROM
  Customers person
  INNER JOIN Orders o on person.PersonID = o.PersonID
  INNER JOIN OrderDetails od on o.OrderID = od.OrderId