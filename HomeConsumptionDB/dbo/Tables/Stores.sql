CREATE TABLE [dbo].[Stores] (
    [StoreID]       INT            IDENTITY (1, 1) NOT NULL,
    [StoreName]     NVARCHAR (80)  NOT NULL,
    [StoreLocation] NVARCHAR (255) NULL,
    CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED ([StoreID] ASC)
);

