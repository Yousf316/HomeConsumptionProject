CREATE TABLE [dbo].[Item_Sizes] (
    [ItemID]          INT        NOT NULL,
    [SizeID]          INT        NOT NULL,
    [Price]           SMALLMONEY NULL,
    [CreatedByUserID] INT        NULL,
    [UpdatedByUserID] INT        NULL,
    CONSTRAINT [FK_Item_Sizes_Items] FOREIGN KEY ([ItemID]) REFERENCES [dbo].[Items] ([ItemID]),
    CONSTRAINT [FK_Item_Sizes_Sizes1] FOREIGN KEY ([SizeID]) REFERENCES [dbo].[Sizes] ([SizeID]),
    CONSTRAINT [FK_Item_Sizes_Users] FOREIGN KEY ([CreatedByUserID]) REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [FK_Item_Sizes_Users1] FOREIGN KEY ([UpdatedByUserID]) REFERENCES [dbo].[Users] ([UserID])
);



