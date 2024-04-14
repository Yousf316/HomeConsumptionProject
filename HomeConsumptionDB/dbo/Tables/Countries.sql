CREATE TABLE [dbo].[Countries] (
    [CountryID]   INT           NOT NULL,
    [CountryName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED ([CountryID] ASC)
);

