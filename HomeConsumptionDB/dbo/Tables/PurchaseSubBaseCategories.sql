CREATE TABLE [dbo].[PurchaseSubBaseCategories] (
    [PSCategoryID] INT NOT NULL,
    [PCategoryID]  INT NOT NULL,
    CONSTRAINT [PK_PurchaseSubBaseCategories] PRIMARY KEY CLUSTERED ([PSCategoryID] ASC, [PCategoryID] ASC),
    CONSTRAINT [FK_PurchaseSubBaseCategories_Purchase_Categories] FOREIGN KEY ([PCategoryID]) REFERENCES [dbo].[Purchase_Categories] ([PCategoryID]),
    CONSTRAINT [FK_PurchaseSubBaseCategories_Purchase_SubCategories] FOREIGN KEY ([PSCategoryID]) REFERENCES [dbo].[Purchase_SubCategories] ([PSCategoryID])
);

