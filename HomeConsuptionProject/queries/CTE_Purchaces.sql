
WITH DuplicateEmails AS (
    SELECT 
       StoreID, 
        COUNT(*) AS DuplicateEmail
    FROM Purchases p
    GROUP BY p.StoreID 
    HAVING COUNT(*) > 1
)
SELECT u.PurchaseID,p.StoreID,s.StoreName,u.TotalAfterTax
FROM DuplicateEmails p
INNER JOIN Stores s ON p.StoreID =s.StoreID inner join Purchases u on u.StoreID= s.StoreID 
order by StoreName