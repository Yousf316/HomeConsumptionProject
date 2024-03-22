CREATE TABLE [dbo].[Purchase_SubCategories] (
    [PSCategoryID]    INT           IDENTITY (1, 1) NOT NULL,
    [SubCategoryName] NVARCHAR (50) NOT NULL,
    [CreatedByUserID] INT           NULL,
    [UpdatedByUserID] INT           NULL,
    CONSTRAINT [PK_Purchase_SubCategories] PRIMARY KEY CLUSTERED ([PSCategoryID] ASC),
    CONSTRAINT [FK_Purchase_SubCategories_Users] FOREIGN KEY ([CreatedByUserID]) REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [FK_Purchase_SubCategories_Users1] FOREIGN KEY ([UpdatedByUserID]) REFERENCES [dbo].[Users] ([UserID])
);





