CREATE TABLE [dbo].[Sizes] (
    [SizeID]          INT           IDENTITY (1, 1) NOT NULL,
    [SizeName]        NVARCHAR (50) NOT NULL,
    [CreatedByUserID] INT           NULL,
    [UpdatedByUserID] INT           NULL,
    CONSTRAINT [PK_Sizes] PRIMARY KEY CLUSTERED ([SizeID] ASC),
    CONSTRAINT [FK_Sizes_Users] FOREIGN KEY ([CreatedByUserID]) REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [FK_Sizes_Users1] FOREIGN KEY ([UpdatedByUserID]) REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [IX_Sizes] UNIQUE NONCLUSTERED ([SizeName] ASC)
);





