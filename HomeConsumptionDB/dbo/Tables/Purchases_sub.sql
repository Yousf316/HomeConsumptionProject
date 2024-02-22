CREATE TABLE [dbo].[Purchases_sub] (
    [PurchaseID]  INT            NOT NULL,
    [P_subID]     INT            NOT NULL,
    [ItemID]      INT            NOT NULL,
    [ItemName]    NVARCHAR (255) NOT NULL,
    [Size]        INT            NULL,
    [Description] NVARCHAR (MAX) NULL,
    [ItemPrice]   SMALLMONEY     NOT NULL,
    [Quantity]    INT            NOT NULL,
    [TotalAmount] SMALLMONEY     NOT NULL,
    CONSTRAINT [PK_Purchases_sub] PRIMARY KEY CLUSTERED ([PurchaseID] ASC, [P_subID] ASC),
    CONSTRAINT [FK_Purchases_sub_Items] FOREIGN KEY ([ItemID]) REFERENCES [dbo].[Items] ([ItemID]),
    CONSTRAINT [FK_Purchases_sub_Purchases] FOREIGN KEY ([PurchaseID]) REFERENCES [dbo].[Purchases] ([PurchaseID]),
    CONSTRAINT [FK_Purchases_sub_Sizes] FOREIGN KEY ([Size]) REFERENCES [dbo].[Sizes] ([SizeID])
);

