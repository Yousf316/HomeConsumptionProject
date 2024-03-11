CREATE TABLE [dbo].[Purchases] (
    [PurchaseID]    INT        IDENTITY (1, 1) NOT NULL,
    [IssueDate]     DATE       NOT NULL,
    [Type]          INT        NOT NULL,
    [TotalBeforTax] SMALLMONEY NOT NULL,
    [Discount]      SMALLMONEY NULL,
    [TaxAmount]     SMALLMONEY NOT NULL,
    [TotalAfterTax] SMALLMONEY NOT NULL,
    [StoreID]       INT        NOT NULL,
    [PCategoryID]   INT        NOT NULL,
    [PSCategoryID]  INT        NULL,
    CONSTRAINT [PK_Purchases] PRIMARY KEY CLUSTERED ([PurchaseID] ASC),
    CONSTRAINT [FK_Purchases_Purchase_Categories] FOREIGN KEY ([PCategoryID]) REFERENCES [dbo].[Purchase_Categories] ([PCategoryID]),
    CONSTRAINT [FK_Purchases_Purchase_SubCategories] FOREIGN KEY ([PSCategoryID]) REFERENCES [dbo].[Purchase_SubCategories] ([PSCategoryID]),
    CONSTRAINT [FK_Purchases_Stores] FOREIGN KEY ([StoreID]) REFERENCES [dbo].[Stores] ([StoreID])
);






GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'1-simple 2-Normal', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Purchases', @level2type = N'COLUMN', @level2name = N'Type';

