CREATE TABLE [dbo].[Purchase_SubCategories] (
    [PSCategoryID]    INT           IDENTITY (1, 1) NOT NULL,
    [SubCategoryName] NVARCHAR (50) NOT NULL,
    [PCategoryID]     INT           NOT NULL,
    CONSTRAINT [PK_Purchase_SubCategories] PRIMARY KEY CLUSTERED ([PSCategoryID] ASC),
    CONSTRAINT [FK_Purchase_SubCategories_Purchase_Categories] FOREIGN KEY ([PCategoryID]) REFERENCES [dbo].[Purchase_Categories] ([PCategoryID])
);

