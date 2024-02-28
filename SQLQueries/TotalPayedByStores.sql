SELECT StoreName,sum(TotalAfterTax) as Total
  FROM [HomeConsumptionDB].[dbo].[View_PurchasesInfo]
  group by StoreName
  order by Total desc

