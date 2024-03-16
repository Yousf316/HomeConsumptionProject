CREATE TABLE [dbo].[Purchase_SubCategories] (
    [PSCategoryID]    INT           IDENTITY (1, 1) NOT NULL,
    [SubCategoryName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Purchase_SubCategories] PRIMARY KEY CLUSTERED ([PSCategoryID] ASC)
);



