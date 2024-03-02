CREATE TABLE [dbo].[Purchase_Categories] (
    [PCategoryID]  INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Purchase_Categories] PRIMARY KEY CLUSTERED ([PCategoryID] ASC),
    CONSTRAINT [IX_Purchase_Categories] UNIQUE NONCLUSTERED ([CategoryName] ASC)
);

