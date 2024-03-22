CREATE TABLE [dbo].[Categories] (
    [CategoryID]      INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName]    NVARCHAR (50) NOT NULL,
    [CreatedByUserID] INT           NULL,
    [UpdatedByUserID] INT           NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([CategoryID] ASC),
    CONSTRAINT [FK_Categories_Users] FOREIGN KEY ([CreatedByUserID]) REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [FK_Categories_Users1] FOREIGN KEY ([UpdatedByUserID]) REFERENCES [dbo].[Users] ([UserID])
);



