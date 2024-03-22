CREATE TABLE [dbo].[Items] (
    [ItemID]          INT            IDENTITY (1, 1) NOT NULL,
    [ItemName_AR]     NVARCHAR (255) NOT NULL,
    [ItemName_EN]     VARCHAR (500)  NULL,
    [CategoryID]      INT            NOT NULL,
    [Price]           SMALLMONEY     NOT NULL,
    [ImagePath]       NVARCHAR (MAX) NULL,
    [CreatedByUserID] INT            NULL,
    [UpdatedByUserID] INT            NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([ItemID] ASC),
    CONSTRAINT [FK_Items_Categories] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Categories] ([CategoryID]),
    CONSTRAINT [FK_Items_Users] FOREIGN KEY ([CreatedByUserID]) REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [FK_Items_Users1] FOREIGN KEY ([UpdatedByUserID]) REFERENCES [dbo].[Users] ([UserID])
);



