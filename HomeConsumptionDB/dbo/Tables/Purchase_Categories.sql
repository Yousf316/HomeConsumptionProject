CREATE TABLE [dbo].[Purchase_Categories] (
    [PCategoryID]     INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName]    NVARCHAR (50) NOT NULL,
    [CreatedByUserID] INT           NULL,
    [UpdatedByUserID] INT           NULL,
    CONSTRAINT [PK_Purchase_Categories] PRIMARY KEY CLUSTERED ([PCategoryID] ASC),
    CONSTRAINT [FK_Purchase_Categories_Users] FOREIGN KEY ([CreatedByUserID]) REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [FK_Purchase_Categories_Users1] FOREIGN KEY ([UpdatedByUserID]) REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [IX_Purchase_Categories] UNIQUE NONCLUSTERED ([CategoryName] ASC)
);



