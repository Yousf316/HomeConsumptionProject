CREATE TABLE [dbo].[Sizes] (
    [SizeID]   INT           NOT NULL,
    [SizeName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Sizes] PRIMARY KEY CLUSTERED ([SizeID] ASC),
    CONSTRAINT [IX_Sizes] UNIQUE NONCLUSTERED ([SizeName] ASC)
);

