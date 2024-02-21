
WITH StoresPurchases AS (
    SELECT 
       StoreID, 
        COUNT(*) AS DuplicateStores
    FROM Purchases p
    GROUP BY p.StoreID 
    HAVING COUNT(*) > 1
)
,
sumPurchasePerStores as (

select p.StoreID,sum(p.TotalAfterTax)as total from
StoresPurchases sp
inner join Purchases p on sp.StoreID = p.StoreID
group by p.StoreID
)
,
sumPurchasePerStoresNamse as (

select s.StoreName,sp.* from
sumPurchasePerStores sp
inner join Stores s on sp.StoreID = s.StoreID

)
select * from sumPurchasePerStoresNamse

