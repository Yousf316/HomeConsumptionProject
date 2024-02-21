with SalesOneTimesforCustomers as(
SELECT 
      S.name as [NameofCustomer]
      ,Count(*) as Times
  FROM [BusinessAnalystDB].[dbo].[Sales_Invoices] S
  group by  S.name
  Having Count(*) =1
  )
  ,
  ItemSales as (
  
  select si.NameofItem ,Count(*) as Sold from 
  SalesOneTimesforCustomers so
  inner join [BusinessAnalystDB].[dbo].[Sales_Invoices_Sub] si on so.[NameofCustomer] = si.[NameofCustomer]
  group by NameofItem
  )
  ,
  ItemSalesQuantity as (
  
  select si.NameofItem ,st.Sold,sum(si.val) as SoldQuantity ,sum(si.PriceBeforTax) as totalamountSold from 
  ItemSales st
  inner join [BusinessAnalystDB].[dbo].[Sales_Invoices_Sub] si on st.NameofItem = si.NameofItem
  group by si.NameofItem,st.Sold
  )
  select * from ItemSalesQuantity
  order by Sold desc