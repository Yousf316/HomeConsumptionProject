CREATE TABLE [dbo].[Item_Sizes] (
    [ItemID] INT        NOT NULL,
    [SizeID] INT        NOT NULL,
    [Price]  SMALLMONEY NULL,
    CONSTRAINT [FK_Item_Sizes_Items] FOREIGN KEY ([ItemID]) REFERENCES [dbo].[Items] ([ItemID]),
    CONSTRAINT [FK_Item_Sizes_Sizes1] FOREIGN KEY ([SizeID]) REFERENCES [dbo].[Sizes] ([SizeID])
);

