CREATE TABLE [dbo].[People] (
    [PersonID]             INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]            NVARCHAR (20) NOT NULL,
    [SecondName]           NVARCHAR (20) NOT NULL,
    [ThirdName]            NVARCHAR (20) NOT NULL,
    [LastName]             NVARCHAR (20) NULL,
    [PhoneNumber]          NVARCHAR (20) NULL,
    [Email]                NVARCHAR (50) NULL,
    [NationalityCountryID] INT           NULL,
    [CreatedByUserID]      INT           NULL,
    [UpdatedByUserID]      INT           NULL,
    CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED ([PersonID] ASC),
    CONSTRAINT [FK_People_Countries] FOREIGN KEY ([NationalityCountryID]) REFERENCES [dbo].[Countries] ([CountryID])
);



