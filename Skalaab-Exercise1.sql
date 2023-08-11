SELECT TOP (3)
    O.CustomerId,
    SUM(OD.Qty) AS TotalQuantity,
    SUM(OD.Qty * OD.UnitPrice) AS TotalAmountSpent
FROM Orders AS O
INNER JOIN OrderDetails AS OD ON O.OrderId = OD.OrderId
WHERE YEAR(O.OrderDate) = 2022
GROUP BY O.CustomerId
ORDER BY TotalAmountSpent DESC;